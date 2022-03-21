using NumberFinder.Game.Enums;
using NumberFinder.Game.Models;
using NumberFinder.Game.Repositories;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace NumberFinder.Game.Forms
{
    public partial class GamePlayForm : Form
    {

        private GamePlay gamePlay;
        private readonly IGamePlayRepository gamePlayRepository;


        public GamePlayForm(GameType gameType)
        {
            InitializeComponent();

            gamePlayRepository = new GamePlayRepository();
            gamePlay = new GamePlay();

            gamePlay.GameType = gameType;
            gamePlayRepository.SetTargetNumber(ref gamePlay);


        }


        private void GamePlayForm_Load(object sender, EventArgs e)
        {

            SetBeginingGameInfo();


        }



        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.MainMenuForm f = new Forms.MainMenuForm();
            f.ShowDialog();
            this.Close();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(NumberTextBox.Text)) {
                    MessageBox.Show("Please Set A Number"); return;
                }        
                    
                               
                if (gamePlay.GeneralPredictionCount != 0)
                {

                    int predictionNumber = Convert.ToInt16(NumberTextBox.Text);

                    gamePlay.Predictions.Add(predictionNumber);

                    if (predictionNumber > gamePlay.TargetNumber)
                    {
                        gamePlay.PredictionCount += 1;
                        SituationLabel.Text = "Up";
                        SituationLabel.ForeColor = System.Drawing.Color.DarkBlue;
                        LogDataGridView.Rows.Add(predictionNumber, "Up");
                        this.LogDataGridView.Sort(LogDataGridView.Columns["Number"], ListSortDirection.Descending);
                    }
                    else if (predictionNumber < gamePlay.TargetNumber)
                    {
                        gamePlay.PredictionCount += 1;
                        SituationLabel.Text = "Down";
                        SituationLabel.ForeColor = System.Drawing.Color.Red;
                        LogDataGridView.Rows.Add(predictionNumber, "Down");
                        this.LogDataGridView.Sort(LogDataGridView.Columns["Number"], ListSortDirection.Descending);
                    }
                    else
                    {
                        
                        //SetScore
                        gamePlayRepository.CalculateScore(ref gamePlay);


                        gamePlay.PredictionCount = 0;
                        gamePlay.KnowNumber += 1;
                        gamePlayRepository.SetTargetNumber(ref gamePlay);

                        SituationLabel.Text = "Success";
                        SituationLabel.ForeColor = System.Drawing.Color.Green;


                        LogDataGridView.Rows.Clear();                       

                    }




                    gamePlay.GeneralPredictionCount -= 1;
                    SetDynamicGameInfo();



                }
                else
                {
                    //Game Finished
                    PlayButton.Enabled = false;
                    SituationLabel.Text = String.Empty;
                    MessageBox.Show("Game Finished.. Your score is " + gamePlay.CurrentScore);
                }

                

            }
            catch (Exception ex)
            {
                throw;
            }
        
        }

        void SetBeginingGameInfo() {
            
            SetStaticGameInfo();
            SetDynamicGameInfo();
        }

        void SetStaticGameInfo() {

            if (gamePlay.GameType == GameType.type_0_100)
            {
                GameTypeLabel.Text = "Game Type : 0 - 100";
                NumberTextBox.MaxLength = 2;
            }
            else if (gamePlay.GameType == GameType.type_0_1000)
            {
                GameTypeLabel.Text = "Game Type : 0 - 1000";
                NumberTextBox.MaxLength = 3;
            }
            else
            {
                GameTypeLabel.Text = "Game Type : 0 - 10000";
                NumberTextBox.MaxLength = 4;
            }
        }

        void SetDynamicGameInfo() {

            NumberTextBox.Text = String.Empty;
            GamePredictionLabel.Text = "Prediction : " + gamePlay.GeneralPredictionCount;
            KnowLabel.Text = "Know : " + gamePlay.KnowNumber;
            GameScoreLabel.Text = gamePlay.CurrentScore.ToString();

        }

        private void NumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
           
        }


    }
}

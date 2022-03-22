using NumberFinder.Game.Enums;
using NumberFinder.Game.Models;
using NumberFinder.Game.Repositories;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace NumberFinder.Game.Forms
{
    public partial class GamePlayForm : BaseForm
    {

        private GamePlay gamePlay;
        private readonly IGamePlayRepository gamePlayRepository;
        private readonly IScoreRepository scoreRepository;


        public GamePlayForm(GameType gameType)
        {
            InitializeComponent();

            gamePlayRepository = new GamePlayRepository();
            scoreRepository = new ScoreRepository();

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
            DialogResult result = MessageBox.Show("Are You Sure Exit ? Current Score Will Not Be Saved", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                this.Hide();
                Forms.MainMenuForm f = new Forms.MainMenuForm();
                f.ShowDialog();
                this.Close();
            }
           
           
        }


        private void PlayButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(NumberTextBox.Text)) {
                    MessageBox.Show("Please Set A Number"); return;
                }        
                                                                   
                int predictionNumber = Convert.ToInt16(NumberTextBox.Text);
 

                if (predictionNumber > gamePlay.TargetNumber)
                {
                    gamePlay.PredictionCount += 1;
                    SituationLabel.Text = "Up";
                    SituationLabel.ForeColor = System.Drawing.Color.DarkBlue;

                    LogDataGridView.Rows.Add(predictionNumber, "Up");
                    LogDataGridView.Sort(LogDataGridView.Columns["Number"], ListSortDirection.Descending);
                    LogDataGridView.ClearSelection();
                }
                else if (predictionNumber < gamePlay.TargetNumber)
                {
                    gamePlay.PredictionCount += 1;
                    SituationLabel.Text = "Down";
                    SituationLabel.ForeColor = System.Drawing.Color.Red;

                    LogDataGridView.Rows.Add(predictionNumber, "Down");
                    LogDataGridView.Sort(LogDataGridView.Columns["Number"], ListSortDirection.Descending);
                    LogDataGridView.ClearSelection();
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


                if (gamePlay.GeneralPredictionCount == 0)
                {

                    //Game Finished
                    if (gamePlay.CurrentScore > 0) {
                        Score score = new Score { ScoreValue = gamePlay.CurrentScore, ScoreDate = System.DateTime.Now };
                        scoreRepository.Create(score);
                    }
                    

                    PlayButton.Enabled = false;
                    SituationLabel.Text = String.Empty;

                    DialogResult result = MessageBox.Show("Game Finished.. Your score is " + gamePlay.CurrentScore, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result.Equals(DialogResult.OK))
                    {
                        this.Hide();
                        Forms.MainMenuForm f = new Forms.MainMenuForm();
                        f.ShowDialog();
                        this.Close();
                    }
                   

                }


            }
            catch (Exception)
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

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

        private GamePlay gameSession;
        private readonly IGamePlayRepository gamePlayRepository;


        public GamePlayForm(GameType gameType)
        {
            InitializeComponent();

            gamePlayRepository = new GamePlayRepository();
            gameSession = new GamePlay();

            gameSession.GameType = gameType;
            gameSession.TargetNumber = gamePlayRepository.SetTargetNumber(gameSession.GameType);
            


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
                    
                               
                if (gameSession.GeneralPredictionCount != 0)
                {

                    int predictionNumber = Convert.ToInt16(NumberTextBox.Text);                    

                    gameSession.Predictions.Add(predictionNumber);

                    if (predictionNumber > gameSession.TargetNumber)
                    {
                        gameSession.PredictionCount += 1;
                        SituationLabel.Text = "Up";
                        SituationLabel.ForeColor = System.Drawing.Color.DarkBlue;
                    }
                    else if (predictionNumber < gameSession.TargetNumber)
                    {
                        gameSession.PredictionCount += 1;
                        SituationLabel.Text = "Down";
                        SituationLabel.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        gameSession.PredictionCount = 0;
                        gameSession.KnowNumber += 1;

                        SituationLabel.Text = "Success";
                        SituationLabel.ForeColor = System.Drawing.Color.Green;
                        
                        gameSession.CurrentScore += 10;                        

                    }

                    


                    gameSession.GeneralPredictionCount -= 1;
                    SetDynamicGameInfo();



                }
                else
                {
                    //Game Finished
                    PlayButton.Enabled = false;
                    SituationLabel.Text = String.Empty;
                    MessageBox.Show("Game Finished.. Your score is " + gameSession.CurrentScore);
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

            if (gameSession.GameType == GameType.type_0_100)
            {
                GameTypeLabel.Text = "Game Type : 0 - 100";
                NumberTextBox.MaxLength = 2;
            }
            else if (gameSession.GameType == GameType.type_0_1000)
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
            GamePredictionLabel.Text = "Prediction : " + gameSession.GeneralPredictionCount;
            KnowLabel.Text = "Know : " + gameSession.KnowNumber;
            GameScoreLabel.Text = gameSession.CurrentScore.ToString();

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

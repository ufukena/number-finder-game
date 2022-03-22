using NumberFinder.Game.Repositories;
using System;
using System.Linq;

namespace NumberFinder.Game.Forms
{
    public partial class ScoresForm : BaseForm
    {
        private readonly IScoreRepository scoreRepository;

        public ScoresForm()
        {
            InitializeComponent();

            scoreRepository = new ScoreRepository();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.MainMenuForm f = new Forms.MainMenuForm();
            f.ShowDialog();
            this.Close();
        }

        private void ScoresForm_Load(object sender, EventArgs e)
        {
            try
            {
                ScoreDataGridView.DataSource = scoreRepository.Get().ToList();
                ScoreDataGridView.ClearSelection();
            }
            catch (Exception)
            {

                throw;
            }
           
        }
    }
}

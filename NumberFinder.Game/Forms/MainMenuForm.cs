using System;
using System.Drawing;
using System.Windows.Forms;

namespace NumberFinder.Game.Forms
{
    public partial class MainMenuForm : BaseForm
    {
        public MainMenuForm()
        {
           
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {

        }

        private void ScoresButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.ScoresForm f = new Forms.ScoresForm();
            f.ShowDialog();
            this.Close();
        }

        private void RulesButton_Click(object sender, EventArgs e)
        {
           // Forms.Ru
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

       

       
    }
}

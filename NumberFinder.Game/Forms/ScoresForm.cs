using System;

namespace NumberFinder.Game.Forms
{
    public partial class ScoresForm : BaseForm
    {
        public ScoresForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.MainMenuForm f = new Forms.MainMenuForm();
            f.ShowDialog();
            this.Close();
        }
    }
}

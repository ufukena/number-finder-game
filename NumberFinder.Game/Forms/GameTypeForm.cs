using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberFinder.Game.Forms
{
    public partial class GameTypeForm : BaseForm
    {
        public GameTypeForm()
        {
            InitializeComponent();
        }

        private void GameType1Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.GamePlayForm f = new Forms.GamePlayForm(Enums.GameType.type_0_100);
            f.ShowDialog();
            this.Close();
        }

        private void GameType2Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.GamePlayForm f = new Forms.GamePlayForm(Enums.GameType.type_0_1000);
            f.ShowDialog();
            this.Close();
        }

        private void GameType3Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.GamePlayForm f = new Forms.GamePlayForm(Enums.GameType.type_0_10000);
            f.ShowDialog();
            this.Close();
        }
    }
}

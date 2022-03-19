using System;
using System.Drawing;
using System.Windows.Forms;

namespace NumberFinder.Game.Forms
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            
            this.Text = "NUMBER FINDER";
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            

            this.Move += new System.EventHandler(BaseForm_Move);

        }

        private void BaseForm_Move(object sender, EventArgs e)
        {
            Point pt = new Point((Screen.GetWorkingArea(this).Width - this.Width) / 2, (Screen.GetWorkingArea(this).Height - this.Height) / 2);
            this.Location = pt;
        }

      


    }
}

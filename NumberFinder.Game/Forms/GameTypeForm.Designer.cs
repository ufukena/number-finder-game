namespace NumberFinder.Game.Forms
{
    partial class GameTypeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GameType1Button = new System.Windows.Forms.Button();
            this.GameType2Button = new System.Windows.Forms.Button();
            this.GameType3Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameType1Button
            // 
            this.GameType1Button.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GameType1Button.Location = new System.Drawing.Point(12, 12);
            this.GameType1Button.Name = "GameType1Button";
            this.GameType1Button.Size = new System.Drawing.Size(260, 100);
            this.GameType1Button.TabIndex = 0;
            this.GameType1Button.Text = "0 - 100";
            this.GameType1Button.UseVisualStyleBackColor = true;
            this.GameType1Button.Click += new System.EventHandler(this.GameType1Button_Click);
            // 
            // GameType2Button
            // 
            this.GameType2Button.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GameType2Button.Location = new System.Drawing.Point(12, 130);
            this.GameType2Button.Name = "GameType2Button";
            this.GameType2Button.Size = new System.Drawing.Size(260, 100);
            this.GameType2Button.TabIndex = 1;
            this.GameType2Button.Text = "0 - 1000";
            this.GameType2Button.UseVisualStyleBackColor = true;
            this.GameType2Button.Click += new System.EventHandler(this.GameType2Button_Click);
            // 
            // GameType3Button
            // 
            this.GameType3Button.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GameType3Button.Location = new System.Drawing.Point(12, 249);
            this.GameType3Button.Name = "GameType3Button";
            this.GameType3Button.Size = new System.Drawing.Size(260, 100);
            this.GameType3Button.TabIndex = 2;
            this.GameType3Button.Text = "0 - 10000";
            this.GameType3Button.UseVisualStyleBackColor = true;
            this.GameType3Button.Click += new System.EventHandler(this.GameType3Button_Click);
            // 
            // GameTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.GameType3Button);
            this.Controls.Add(this.GameType2Button);
            this.Controls.Add(this.GameType1Button);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NUMBER FINDER";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GameType1Button;
        private System.Windows.Forms.Button GameType2Button;
        private System.Windows.Forms.Button GameType3Button;
    }
}
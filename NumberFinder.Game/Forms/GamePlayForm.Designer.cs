namespace NumberFinder.Game.Forms
{
    partial class GamePlayForm
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
            this.LogDataGridView = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpDown = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExitButton = new System.Windows.Forms.Button();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.PlayButton = new System.Windows.Forms.Button();
            this.GameTypeLabel = new System.Windows.Forms.Label();
            this.GamePredictionLabel = new System.Windows.Forms.Label();
            this.KnowLabel = new System.Windows.Forms.Label();
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SituationLabel = new System.Windows.Forms.Label();
            this.GameScoreLabel = new System.Windows.Forms.Label();
            this.ScoreGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogDataGridView)).BeginInit();
            this.InfoGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ScoreGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogDataGridView
            // 
            this.LogDataGridView.AllowUserToAddRows = false;
            this.LogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LogDataGridView.ColumnHeadersVisible = false;
            this.LogDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.UpDown});
            this.LogDataGridView.Enabled = false;
            this.LogDataGridView.Location = new System.Drawing.Point(12, 92);
            this.LogDataGridView.Name = "LogDataGridView";
            this.LogDataGridView.ReadOnly = true;
            this.LogDataGridView.RowHeadersVisible = false;
            this.LogDataGridView.RowTemplate.Height = 25;
            this.LogDataGridView.Size = new System.Drawing.Size(150, 257);
            this.LogDataGridView.TabIndex = 2;
            // 
            // Number
            // 
            this.Number.Frozen = true;
            this.Number.HeaderText = "NumberColumn";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 75;
            // 
            // UpDown
            // 
            this.UpDown.Frozen = true;
            this.UpDown.HeaderText = "UpDownColumn";
            this.UpDown.Name = "UpDown";
            this.UpDown.ReadOnly = true;
            this.UpDown.Width = 75;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(12, 389);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(360, 60);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumberTextBox.Location = new System.Drawing.Point(173, 12);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(199, 61);
            this.NumberTextBox.TabIndex = 4;
            this.NumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberTextBox_KeyPress);
            // 
            // PlayButton
            // 
            this.PlayButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlayButton.ForeColor = System.Drawing.Color.Blue;
            this.PlayButton.Location = new System.Drawing.Point(173, 92);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(199, 47);
            this.PlayButton.TabIndex = 5;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // GameTypeLabel
            // 
            this.GameTypeLabel.AutoSize = true;
            this.GameTypeLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GameTypeLabel.Location = new System.Drawing.Point(6, 26);
            this.GameTypeLabel.Name = "GameTypeLabel";
            this.GameTypeLabel.Size = new System.Drawing.Size(108, 19);
            this.GameTypeLabel.TabIndex = 6;
            this.GameTypeLabel.Text = "Game Type : --";
            // 
            // GamePredictionLabel
            // 
            this.GamePredictionLabel.AutoSize = true;
            this.GamePredictionLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GamePredictionLabel.Location = new System.Drawing.Point(6, 57);
            this.GamePredictionLabel.Name = "GamePredictionLabel";
            this.GamePredictionLabel.Size = new System.Drawing.Size(102, 19);
            this.GamePredictionLabel.TabIndex = 7;
            this.GamePredictionLabel.Text = "Prediction : --";
            // 
            // KnowLabel
            // 
            this.KnowLabel.AutoSize = true;
            this.KnowLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KnowLabel.ForeColor = System.Drawing.Color.Black;
            this.KnowLabel.Location = new System.Drawing.Point(6, 90);
            this.KnowLabel.Name = "KnowLabel";
            this.KnowLabel.Size = new System.Drawing.Size(70, 19);
            this.KnowLabel.TabIndex = 8;
            this.KnowLabel.Text = "Know : --";
            // 
            // InfoGroupBox
            // 
            this.InfoGroupBox.Controls.Add(this.GameTypeLabel);
            this.InfoGroupBox.Controls.Add(this.KnowLabel);
            this.InfoGroupBox.Controls.Add(this.GamePredictionLabel);
            this.InfoGroupBox.Location = new System.Drawing.Point(173, 223);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.Size = new System.Drawing.Size(200, 126);
            this.InfoGroupBox.TabIndex = 9;
            this.InfoGroupBox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SituationLabel);
            this.groupBox2.Location = new System.Drawing.Point(173, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 61);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // SituationLabel
            // 
            this.SituationLabel.AutoSize = true;
            this.SituationLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SituationLabel.ForeColor = System.Drawing.Color.Red;
            this.SituationLabel.Location = new System.Drawing.Point(48, 16);
            this.SituationLabel.Name = "SituationLabel";
            this.SituationLabel.Size = new System.Drawing.Size(0, 37);
            this.SituationLabel.TabIndex = 9;
            this.SituationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameScoreLabel
            // 
            this.GameScoreLabel.AutoSize = true;
            this.GameScoreLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GameScoreLabel.ForeColor = System.Drawing.Color.Green;
            this.GameScoreLabel.Location = new System.Drawing.Point(37, 17);
            this.GameScoreLabel.Name = "GameScoreLabel";
            this.GameScoreLabel.Size = new System.Drawing.Size(61, 37);
            this.GameScoreLabel.TabIndex = 10;
            this.GameScoreLabel.Text = "----";
            this.GameScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreGroupBox
            // 
            this.ScoreGroupBox.Controls.Add(this.GameScoreLabel);
            this.ScoreGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ScoreGroupBox.Location = new System.Drawing.Point(12, 4);
            this.ScoreGroupBox.Name = "ScoreGroupBox";
            this.ScoreGroupBox.Size = new System.Drawing.Size(150, 69);
            this.ScoreGroupBox.TabIndex = 11;
            this.ScoreGroupBox.TabStop = false;
            this.ScoreGroupBox.Text = "SCORE";
            // 
            // GamePlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.ScoreGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.InfoGroupBox);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LogDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GamePlayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Number Finder";
            this.Load += new System.EventHandler(this.GamePlayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogDataGridView)).EndInit();
            this.InfoGroupBox.ResumeLayout(false);
            this.InfoGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ScoreGroupBox.ResumeLayout(false);
            this.ScoreGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView LogDataGridView;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Label GameTypeLabel;
        private System.Windows.Forms.Label GamePredictionLabel;
        private System.Windows.Forms.Label KnowLabel;
        private System.Windows.Forms.GroupBox InfoGroupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label SituationLabel;
        private System.Windows.Forms.Label GameScoreLabel;
        private System.Windows.Forms.GroupBox ScoreGroupBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpDown;
    }
}
namespace NumberFinder.Game.Forms
{
    partial class ScoresForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ScoreDataGridView = new System.Windows.Forms.DataGridView();
            this.RowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScoreValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScoreDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(12, 339);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(260, 60);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ScoreDataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ScoreDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ScoreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScoreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowNumber,
            this.ScoreValue,
            this.ScoreDate});
            this.ScoreDataGridView.Location = new System.Drawing.Point(12, 10);
            this.ScoreDataGridView.MultiSelect = false;
            this.ScoreDataGridView.Name = "ScoreDataGridView";
            this.ScoreDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ScoreDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ScoreDataGridView.RowHeadersVisible = false;
            this.ScoreDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ScoreDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ScoreDataGridView.RowTemplate.Height = 25;
            this.ScoreDataGridView.Size = new System.Drawing.Size(260, 310);
            this.ScoreDataGridView.TabIndex = 1;
            // 
            // RowNumber
            // 
            this.RowNumber.DataPropertyName = "RowNumber";
            this.RowNumber.Frozen = true;
            this.RowNumber.HeaderText = "NO";
            this.RowNumber.Name = "RowNumber";
            this.RowNumber.ReadOnly = true;
            this.RowNumber.Width = 50;
            // 
            // ScoreValue
            // 
            this.ScoreValue.DataPropertyName = "ScoreValue";
            this.ScoreValue.Frozen = true;
            this.ScoreValue.HeaderText = "SCORE";
            this.ScoreValue.Name = "ScoreValue";
            this.ScoreValue.ReadOnly = true;
            this.ScoreValue.Width = 90;
            // 
            // ScoreDate
            // 
            this.ScoreDate.DataPropertyName = "ScoreDate";
            dataGridViewCellStyle2.Format = "yyyy-MM-dd HH:mm";
            dataGridViewCellStyle2.NullValue = null;
            this.ScoreDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.ScoreDate.Frozen = true;
            this.ScoreDate.HeaderText = "DATE";
            this.ScoreDate.Name = "ScoreDate";
            this.ScoreDate.ReadOnly = true;
            // 
            // ScoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.ScoreDataGridView);
            this.Controls.Add(this.ExitButton);
            this.Name = "ScoresForm";
            this.Load += new System.EventHandler(this.ScoresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScoreDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGridView ScoreDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScoreValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScoreDate;
    }
}
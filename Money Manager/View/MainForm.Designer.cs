namespace Money_Manager.View
{
    partial class MainForm
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
            this.BudgetTextBox = new System.Windows.Forms.TextBox();
            this.BudgetLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BudgetTextBox
            // 
            this.BudgetTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BudgetTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.BudgetTextBox.Location = new System.Drawing.Point(416, 35);
            this.BudgetTextBox.Name = "BudgetTextBox";
            this.BudgetTextBox.ReadOnly = true;
            this.BudgetTextBox.Size = new System.Drawing.Size(72, 33);
            this.BudgetTextBox.TabIndex = 0;
            this.BudgetTextBox.TabStop = false;
            // 
            // BudgetLabel
            // 
            this.BudgetLabel.AutoSize = true;
            this.BudgetLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BudgetLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BudgetLabel.Location = new System.Drawing.Point(411, 9);
            this.BudgetLabel.Name = "BudgetLabel";
            this.BudgetLabel.Size = new System.Drawing.Size(75, 24);
            this.BudgetLabel.TabIndex = 1;
            this.BudgetLabel.Text = "Budget";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(496, 466);
            this.Controls.Add(this.BudgetLabel);
            this.Controls.Add(this.BudgetTextBox);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Money Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox BudgetTextBox;
        private Label BudgetLabel;
    }
}
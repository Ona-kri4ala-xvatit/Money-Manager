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
            this.SetBudgetTextBox = new System.Windows.Forms.TextBox();
            this.SetBudgetLabel = new System.Windows.Forms.Label();
            this.SetBudgetButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BudgetTextBox
            // 
            this.BudgetTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BudgetTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.BudgetTextBox.Location = new System.Drawing.Point(653, 32);
            this.BudgetTextBox.Name = "BudgetTextBox";
            this.BudgetTextBox.Size = new System.Drawing.Size(72, 33);
            this.BudgetTextBox.TabIndex = 0;
            this.BudgetTextBox.TabStop = false;
            // 
            // BudgetLabel
            // 
            this.BudgetLabel.AutoSize = true;
            this.BudgetLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BudgetLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BudgetLabel.Location = new System.Drawing.Point(575, 40);
            this.BudgetLabel.Name = "BudgetLabel";
            this.BudgetLabel.Size = new System.Drawing.Size(72, 25);
            this.BudgetLabel.TabIndex = 1;
            this.BudgetLabel.Text = "Budget";
            // 
            // SetBudgetTextBox
            // 
            this.SetBudgetTextBox.Location = new System.Drawing.Point(308, 191);
            this.SetBudgetTextBox.Name = "SetBudgetTextBox";
            this.SetBudgetTextBox.Size = new System.Drawing.Size(100, 23);
            this.SetBudgetTextBox.TabIndex = 2;
            // 
            // SetBudgetLabel
            // 
            this.SetBudgetLabel.AutoSize = true;
            this.SetBudgetLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SetBudgetLabel.Location = new System.Drawing.Point(165, 162);
            this.SetBudgetLabel.Name = "SetBudgetLabel";
            this.SetBudgetLabel.Size = new System.Drawing.Size(103, 25);
            this.SetBudgetLabel.TabIndex = 3;
            this.SetBudgetLabel.Text = "Set Budget";
            // 
            // SetBudgetButton
            // 
            this.SetBudgetButton.Location = new System.Drawing.Point(308, 220);
            this.SetBudgetButton.Name = "SetBudgetButton";
            this.SetBudgetButton.Size = new System.Drawing.Size(100, 31);
            this.SetBudgetButton.TabIndex = 4;
            this.SetBudgetButton.Text = "Set Budget";
            this.SetBudgetButton.UseVisualStyleBackColor = true;
            this.SetBudgetButton.Click += new System.EventHandler(this.SetBudgetButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(737, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMonthToolStripMenuItem,
            this.toolStripMenuItem1});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newMonthToolStripMenuItem
            // 
            this.newMonthToolStripMenuItem.Name = "newMonthToolStripMenuItem";
            this.newMonthToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.newMonthToolStripMenuItem.Text = "New Month";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 6);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(737, 472);
            this.Controls.Add(this.SetBudgetButton);
            this.Controls.Add(this.SetBudgetLabel);
            this.Controls.Add(this.SetBudgetTextBox);
            this.Controls.Add(this.BudgetLabel);
            this.Controls.Add(this.BudgetTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Money Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox BudgetTextBox;
        private Label BudgetLabel;
        private TextBox SetBudgetTextBox;
        protected internal Label SetBudgetLabel;
        private Button SetBudgetButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newMonthToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
    }
}
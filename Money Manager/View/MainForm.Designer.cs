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
            this.BudgetLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.labelDisplayBudget = new System.Windows.Forms.Label();
            this.budgetPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.budgetPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BudgetLabel
            // 
            this.BudgetLabel.AutoSize = true;
            this.BudgetLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BudgetLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BudgetLabel.Location = new System.Drawing.Point(577, 41);
            this.BudgetLabel.Name = "BudgetLabel";
            this.BudgetLabel.Size = new System.Drawing.Size(72, 25);
            this.BudgetLabel.TabIndex = 1;
            this.BudgetLabel.Text = "Budget";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
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
            this.newMonthToolStripMenuItem.Click += new System.EventHandler(this.newMonthToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 6);
            // 
            // labelDisplayBudget
            // 
            this.labelDisplayBudget.AutoSize = true;
            this.labelDisplayBudget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDisplayBudget.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDisplayBudget.Location = new System.Drawing.Point(0, 0);
            this.labelDisplayBudget.Name = "labelDisplayBudget";
            this.labelDisplayBudget.Size = new System.Drawing.Size(81, 25);
            this.labelDisplayBudget.TabIndex = 6;
            this.labelDisplayBudget.Text = "LBudget";
            // 
            // budgetPanel
            // 
            this.budgetPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.budgetPanel.Controls.Add(this.labelDisplayBudget);
            this.budgetPanel.Location = new System.Drawing.Point(651, 40);
            this.budgetPanel.Name = "budgetPanel";
            this.budgetPanel.Size = new System.Drawing.Size(74, 25);
            this.budgetPanel.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(737, 472);
            this.Controls.Add(this.budgetPanel);
            this.Controls.Add(this.BudgetLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Money Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.budgetPanel.ResumeLayout(false);
            this.budgetPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label BudgetLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newMonthToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private Label labelDisplayBudget;
        private Panel budgetPanel;
    }
}
namespace Money_Manager.View
{
    partial class AddBudgetForm
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
            this.SetBudgetButton = new System.Windows.Forms.Button();
            this.SetBudgetTextBox = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SetBudgetButton
            // 
            this.SetBudgetButton.Location = new System.Drawing.Point(12, 255);
            this.SetBudgetButton.Name = "SetBudgetButton";
            this.SetBudgetButton.Size = new System.Drawing.Size(189, 31);
            this.SetBudgetButton.TabIndex = 7;
            this.SetBudgetButton.Text = "Set Budget";
            this.SetBudgetButton.UseVisualStyleBackColor = true;
            this.SetBudgetButton.Click += new System.EventHandler(this.SetBudgetButton_Click);
            // 
            // SetBudgetTextBox
            // 
            this.SetBudgetTextBox.Location = new System.Drawing.Point(101, 11);
            this.SetBudgetTextBox.Name = "SetBudgetTextBox";
            this.SetBudgetTextBox.Size = new System.Drawing.Size(100, 23);
            this.SetBudgetTextBox.TabIndex = 5;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(27, 81);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Budget";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select the first day of the month";
            // 
            // AddBudgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(215, 300);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.SetBudgetButton);
            this.Controls.Add(this.SetBudgetTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AddBudgetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Budget";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SetBudgetButton;
        private TextBox SetBudgetTextBox;
        private MonthCalendar monthCalendar1;
        private Label label1;
        private Label label2;
    }
}
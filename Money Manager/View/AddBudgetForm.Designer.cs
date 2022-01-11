namespace Money_Manager.View
{
    partial class addBudgetForm
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
            this.SetBudgetLabel = new System.Windows.Forms.Label();
            this.SetBudgetTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SetBudgetButton
            // 
            this.SetBudgetButton.Location = new System.Drawing.Point(158, 178);
            this.SetBudgetButton.Name = "SetBudgetButton";
            this.SetBudgetButton.Size = new System.Drawing.Size(100, 31);
            this.SetBudgetButton.TabIndex = 7;
            this.SetBudgetButton.Text = "Set Budget";
            this.SetBudgetButton.UseVisualStyleBackColor = true;
            this.SetBudgetButton.Click += new System.EventHandler(this.SetBudgetButton_Click);
            // 
            // SetBudgetLabel
            // 
            this.SetBudgetLabel.AutoSize = true;
            this.SetBudgetLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SetBudgetLabel.Location = new System.Drawing.Point(40, 130);
            this.SetBudgetLabel.Name = "SetBudgetLabel";
            this.SetBudgetLabel.Size = new System.Drawing.Size(103, 25);
            this.SetBudgetLabel.TabIndex = 6;
            this.SetBudgetLabel.Text = "Set Budget";
            // 
            // SetBudgetTextBox
            // 
            this.SetBudgetTextBox.Location = new System.Drawing.Point(158, 132);
            this.SetBudgetTextBox.Name = "SetBudgetTextBox";
            this.SetBudgetTextBox.Size = new System.Drawing.Size(100, 23);
            this.SetBudgetTextBox.TabIndex = 5;
            // 
            // addBudgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(396, 248);
            this.Controls.Add(this.SetBudgetButton);
            this.Controls.Add(this.SetBudgetLabel);
            this.Controls.Add(this.SetBudgetTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "addBudgetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Budget";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SetBudgetButton;
        protected internal Label SetBudgetLabel;
        private TextBox SetBudgetTextBox;
    }
}
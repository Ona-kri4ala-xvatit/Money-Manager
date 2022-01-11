namespace Money_Manager.View
{
    public partial class MainForm : Form, IViewDisplayBudget
    {
        public MainForm()
        {
            InitializeComponent();
            //exitToolStripMenuItem.Click += (s,e) => { this.Close(); };
        }

        public void DisplayBudget(decimal value)
        {
            BudgetTextBox.Text = value.ToString("N2");
        }

        private void newMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addBudgetForm addBudgetForm = new addBudgetForm();
            addBudgetForm.ShowDialog();
        }
    }
}


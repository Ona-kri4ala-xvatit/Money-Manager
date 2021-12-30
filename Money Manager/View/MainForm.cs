namespace Money_Manager.View
{
    public partial class MainForm : Form, IView
    {
        public MainForm()
        {
            InitializeComponent();

        }

        public void SetBudget(decimal value)
        {
            BudgetTextBox.Text = value.ToString("N2");
        }

        public decimal InputBudget => Convert.ToDecimal(SetBudgetTextBox.Text);

        public event EventHandler<EventArgs> GetBudget;

        private void SetBudgetButton_Click(object sender, EventArgs e)
        {
            if (GetBudget != null)
            {
                GetBudget(this, EventArgs.Empty);
            }
        }
    }
}


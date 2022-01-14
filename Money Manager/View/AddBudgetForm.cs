namespace Money_Manager.View
{
    public partial class AddBudgetForm : Form, IViewInputBudget
    {
        public AddBudgetForm()
        {
            InitializeComponent();   
        }

        public decimal InputBudget
        {
            get { return Convert.ToDecimal(SetBudgetTextBox.Text); }
        }

        public event EventHandler<EventArgs>? GetBudget;

        private void SetBudgetButton_Click(object sender, EventArgs e)
        {
            GetBudget?.Invoke(this, EventArgs.Empty);
            this.Close();
        }
    }
}

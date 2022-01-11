namespace Money_Manager.View
{
    public partial class addBudgetForm : Form, IViewInputBudget
    {
        public addBudgetForm()
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
            if (GetBudget != null)
            {
                GetBudget(this, EventArgs.Empty);
            }
            this.Close();
        }

    }
}

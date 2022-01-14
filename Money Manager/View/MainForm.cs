using Money_Manager.Presenter;

namespace Money_Manager.View
{
    public partial class MainForm : Form, IViewDisplayBudget
    {
        public MainForm()
        {
            InitializeComponent();
            //exitToolStripMenuItem.Click += (s,e) => { Close(); };
            
        }

        public void DisplayBudget(decimal value)
        {
            labelDisplayBudget.Text = value.ToString("N2");
        }

        private void newMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBudgetForm addBudgetForm = new();
            AddBudgetFormPresenter presenter = new(addBudgetForm);
            addBudgetForm.ShowDialog();
        }
    }
}


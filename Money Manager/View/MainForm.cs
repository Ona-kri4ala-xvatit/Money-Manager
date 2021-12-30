using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Money_Manager.Presenter;

namespace Money_Manager.View
{
    public partial class MainForm : Form, IView
    {  
        public MainForm()
        {
            InitializeComponent();

        }

        public void SetBudget(decimal value, DateTime date)
        {
            BudgetTextBox.Text = value.ToString();
            //DateLabel.Text = date.ToShortDateString().ToString();            
        }
    }
}


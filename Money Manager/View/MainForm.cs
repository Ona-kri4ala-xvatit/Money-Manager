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

        public void SetBudget(decimal value)
        {
            BudgetTextBox.Text = value.ToString();
            
        }

        public void SetFood(decimal value)
        {
            RentPropTextBox.Text = value.ToString();
            MunicipalServTextBox.Text = value.ToString();
            TransportConstsTextBox.Text = value.ToString();
            EntertainmentTextBox.Text = value.ToString();
            ClothesTextBox.Text = value.ToString();
            HealthTextBox.Text = value.ToString();
            FoodTextBox.Text = value.ToString();
            DebtTextBox.Text = value.ToString();
            OtherTextBox.Text = value.ToString();
        }
    }
}


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

        public void SetClothes(decimal value)
        {
            ClothesTextBox.Text = value.ToString();
        }

        public void SetDebt(decimal value)
        {
            DebtTextBox.Text = value.ToString();
        }

        public void SetEntertainment(decimal value)
        {
            EntertainmentTextBox.Text = value.ToString();
        }

        public void SetFood(decimal value)
        {
            FoodTextBox.Text = value.ToString();
        }

        public void SetHealth(decimal value)
        {
           HealthTextBox.Text = value.ToString();   
        }

        public void SetMunicipalService(decimal value)
        {
            MunicipalServTextBox.Text = value.ToString();
        }

        public void SetOther(decimal value)
        {
            OtherTextBox.Text = value.ToString();
        }

        public void SetRentingProperties(decimal value)
        {
            RentPropTextBox.Text = value.ToString();
        }

        public void SetTransportCosts(decimal value)
        {
            TransportConstsTextBox.Text = value.ToString();
        }
    }
}


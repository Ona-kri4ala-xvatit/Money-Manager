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
    public partial class MainForm : Form, Interface
    {  
        public MainForm()
        {
            InitializeComponent();      
        }

       

        public void ShowdData(decimal value)
        {
            textBox1.Text = value.ToString();
        }
    }
}


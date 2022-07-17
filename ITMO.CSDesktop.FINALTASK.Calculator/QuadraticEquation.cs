using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class QuadraticEquation : Form
    {
        public QuadraticEquation()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text = mehanizmcalkulyatora.QuadraticEquationCalculate(aCofficient.Text, bCofficient.Text, cCofficient.Text);
            }
            catch(Exception)
            {
                textBox4.Text = ("Неверный формат данных");
            }
        }

        private void btnSbros_Click(object sender, EventArgs e)
        {
            aCofficient.Text = "";
            bCofficient.Text = "";
            cCofficient.Text = "";
        }
    }
}

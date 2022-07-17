using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class EngineerCalc : Calculator.Calc
    {
        public EngineerCalc()
        {
            InitializeComponent();
        }

        private void btnStepen_Click(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.Stepen);
        }

        private void btnKoren_Click(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.KvadratnuiKoren);
            txtOutput.Text = mehanizmcalkulyatora.ZnakRavno();
            mehanizmcalkulyatora.Sbros();
        }

        private void btnObratnoe_Click(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.ObratnoeChislo);
            txtOutput.Text = mehanizmcalkulyatora.ZnakRavno();
            mehanizmcalkulyatora.Sbros();
        }

        private void btnKvadrat_Click(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.KvadratChisla);
            txtOutput.Text = mehanizmcalkulyatora.ZnakRavno();
            mehanizmcalkulyatora.Sbros();
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.Factorial);
            txtOutput.Text = mehanizmcalkulyatora.ZnakRavno();
            mehanizmcalkulyatora.Sbros();
        }

        private void btnKubKoren_Click(object sender, EventArgs e)
        {
            mehanizmcalkulyatora.DeystvieCalculatora(mehanizmcalkulyatora.Deystvie.KubKoren);
            txtOutput.Text = mehanizmcalkulyatora.ZnakRavno();
            mehanizmcalkulyatora.Sbros();
        }

        private void btnQuadraticEquation_Click(object sender, EventArgs e)
        {
            QuadraticEquation qe = new QuadraticEquation();
            qe.Show();
        }
    }
}

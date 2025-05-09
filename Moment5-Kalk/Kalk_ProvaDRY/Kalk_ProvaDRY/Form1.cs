using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalk_ProvaDRY
{
    public partial class btnEql : Form //  Det var det här jag råkade komma åt vet inte hur..
    {
        private double firstNum = 0;
        private Kör selectedOpr = Kör.None;
        //Uppdaterad Version för DRY (See hur jag löste den i tidigare version......) 
        private void NumButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                if (txtDisplay.Text == "0")
                    txtDisplay.Text = btn.Text;
                else
                    txtDisplay.Text += btn.Text;
            }
        }
        // EventKnapp för comma
        private void DecimalButton_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains(","))
            {
                if (string.IsNullOrEmpty(txtDisplay.Text))
                    txtDisplay.Text = "0,";
                else
                    txtDisplay.Text += ",";
            }
        }

        enum Kör { None,Plus, Min, Multi, Div} // ENUM FÖR UTRÄKNING DIREKT I METODERNA.

        private double Räkna(double x, double y, Kör op) // vet inte om vi fick göra en annan .NET version men det går att lösa på ett annant sätt... 

            /*
             private double Räkna(double x, double y, Kör op)
        {
            return op switch
            {
                Kör.Plus => x + y,
                Kör.Min => x - y,
                Kör.Multi => x * y,
                Kör.Div => x / y,

            };
        }
            */
        {
            switch (op)
            {
                case Kör.Plus:
                    return x + y;
                case Kör.Min:
                    return x - y;
                case Kör.Multi:
                    return x * y;
                case Kör.Div:
                    return x / y;
                default:
                    return 0; // Om ingen operation är vald
            }
        }

        public btnEql() // Jag kom åt något så vet inte varför den heter btnEql men om jag ändrar den så kommer allt sluta fungera.
        {
            InitializeComponent();
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        //Div knapp
        private void btnDiv_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(txtDisplay.Text);
            selectedOpr = Kör.Div;
            txtDisplay.Clear();
        }

        //Multi Knapp
        private void btnX_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(txtDisplay.Text);
            selectedOpr = Kör.Multi;
            txtDisplay.Clear();

        }
        //Sub knapp
        private void btnMin_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(txtDisplay.Text);
            selectedOpr = Kör.Min;
            txtDisplay.Clear();
        }
        //Plus knapp
        private void btnPlus_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(txtDisplay.Text);
            selectedOpr = Kör.Plus;
            txtDisplay.Clear();
        }
        //Clear Text 
        private void btnC_Click(object sender, EventArgs e)
        {
          txtDisplay.Text = "0";
          selectedOpr = Kör.None;
          firstNum = 0;
        }

       
        // Det blev lite wonky pga btnEql... så den fick heta btnRäkna istället..
        private void btnRäkna_Click(object sender, EventArgs e)
        {
            double secondNum = double.Parse(txtDisplay.Text);
            double result = Räkna(firstNum, secondNum, selectedOpr);
            txtDisplay.Text = result.ToString();
            selectedOpr = Kör.None;
        }
    }
}

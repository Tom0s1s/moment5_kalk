using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_ShortFort_Calculator
{
    public partial class Form1 : Form
    {
        //Data typer för nummer och kör matte
        double firstNum, secNum;
        string kör;

        public Form1()
        {
            InitializeComponent();
        }
        // ==== FÖR KNAPPAR 0-9 === ///
        private void btn7_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0") 
            {
                Display.Text = "7";
            }
            else
                {
                Display.Text = Display.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0")
            {
                Display.Text = "8";
            }
            else
            {
                Display.Text = Display.Text + "8";
            }

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0")
            {
                Display.Text = "9";
            }
            else
            {
                Display.Text = Display.Text + "9";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0")
            {
                Display.Text = "4";
            }
            else
            {
                Display.Text = Display.Text + "4";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0")
            {
                Display.Text = "6";
            }
            else
            {
                Display.Text = Display.Text + "6";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0")
            {
                Display.Text = "2";
            }
            else
            {
                Display.Text = Display.Text + "2";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0")
            {
                Display.Text = "1";
            }
            else
            {
                Display.Text = Display.Text + "1";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0")
            {
                Display.Text = "5";
            }
            else
            {
                Display.Text = Display.Text + "5";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0")
            {
                Display.Text = "3";
            }
            else
            {
                Display.Text = Display.Text + "3";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0")
            {
                Display.Text = "0";
            }
            else
            {
                Display.Text = Display.Text + "0";
            }
        }
        // === KNAPPAR 0-9 === //

        // === KNAPPAR FÖR OPERATORS == //
        private void btnPlus_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(Display.Text);
            kör = "+";
            Display.Text = "";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(Display.Text);
            kör = "-";
            Display.Text = "";
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(Display.Text);
            kör = "*";
            Display.Text = "";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(Display.Text);
            kör = "/";
            Display.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            Display.Text = "0";
        }
        // === KNAPPAR FÖR OPERATORS === //

        // == SWITCH CASE FÖR Eql == //

        private void btnEql_Click(object sender, EventArgs e)
        {
            secNum = double.Parse(Display.Text);

            switch (kör)
            {
                case "+":
                    Display.Text = (firstNum + secNum).ToString();
                    break;

                case "-":
                    Display.Text = (firstNum - secNum).ToString();
                    break;

                case "*":
                    Display.Text = (firstNum * secNum).ToString();
                    break;

                case "/":
                    Display.Text = (firstNum / secNum).ToString();
                    break;

                default:
                    break;
            }
        }

        // === KNAPP FÖR , === //
        private void btnCom_Click(object sender, EventArgs e) // Glömde lägga till den ... 
        {
            if (!Display.Text.Contains(","))
            {
                Display.Text += ",";
            }
        }

        private void Display_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalk_M5_1


{
    enum Operation // Ger Operation en "order"
    {
        None,
        Add,
        Subtract,
        Multiply,
        Divide,

    }
    public partial class Form1 : Form

    {
        double firstNum, secNum; // Sätter första och andra nummret till en double (som hanterar flyt tal)
        Operation selectedOperation = Operation.None; //Inget val är gjort än 

        public Form1()
        {
            InitializeComponent(); // Startar forms1

       }
        // Ger funktion till Add, Sub, Multi och div.
            private double Add (double x, double y)
        {
            return x + y;
        }
        private double Subtract(double x, double y)
        {
            return x - y;
        }
        private double Multiply(double x, double y)
        {
            return x * y;
        }
        private double Divide(double x, double y)
        {
            if (y != 0)
                return x / y;
            else
                throw new DivideByZeroException("Error: Kan inte dividera med 0");
        }
        private double getInput()
        {
            if (double.TryParse(textBox1.Text, out double value))
            {
                return value;
            }
            else
            {
                MessageBox.Show("Error: Ange ett giltigt tal.");
                return 0; 
            }
        }
        private void ClearInput()
        {
            textBox1.Text = string.Empty;
        }
        private void DisplayResult(double result)
        {
            textBox1.Text = result.ToString();
        }



        //Konstruktors
        private void textBox1_TextChanged(object sender, EventArgs e) // Display 
        {
            
        }

        private void btnTimes_Click(object sender, EventArgs e) // * metod
        {
            firstNum = getInput();
            selectedOperation = Operation.Multiply;
            ClearInput();

        }

        private void btnPlus_Click(object sender, EventArgs e) // + metod
        {
            firstNum = getInput();
            selectedOperation = Operation.Add;
            ClearInput();
        }

        private void btnDiv_Click(object sender, EventArgs e) // / metod
        {
            firstNum = getInput();
            selectedOperation = Operation.Divide;
            ClearInput();
        }

        private void btnMin_Click(object sender, EventArgs e) // - metod
        {
            firstNum = getInput();
            selectedOperation = Operation.Subtract;
            ClearInput();

        }

        private void btnClear_Click(object sender, EventArgs e) // Rensa metod
        {
            firstNum = 0;
            secNum = 0;
            selectedOperation = Operation.None;
            textBox1.Text = string.Empty;

        }

        private void btnDec_Click(object sender, EventArgs e) // decimal metod 
        {
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
            }
        }

        //Knappar 0-9 
        private void btn8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void bnt4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void bnt7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }

        }

        private void btnEql_Click(object sender, EventArgs e) // = metod 
        {
            secNum = getInput();
            double result = 0;
            try
            {
                switch (selectedOperation)
                {
                    case Operation.Add:
                        result = Add(firstNum, secNum);
                        break;
                    case Operation.Subtract:
                        result = Subtract(firstNum, secNum);
                        break;
                    case Operation.Multiply:
                        result = Multiply(firstNum, secNum);
                        break;
                    case Operation.Divide:
                        result = Divide(firstNum, secNum);
                        break;
                    default:
                        MessageBox.Show("Error: Ingen operation vald.");
                        return;
                }

                DisplayResult(result);
                selectedOperation = Operation.None;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

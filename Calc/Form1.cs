using System;
using System.Windows.Forms;

namespace Calc
{
    public partial class CalcBody : Form
    {
        double number;
        string operation;
        public CalcBody()
        {
            InitializeComponent();
        }

        private void btNequals_Click(object sender, EventArgs e)
        {
            double number2;
            double result;

            number2 = Convert.ToDouble(Display.Text);

            if (operation == "+")
            {
                result = number + number2;
                Display.Text = Convert.ToString(result);
                number = result;
            }

            if (operation == "-")
            {
                result = number - number2;
                Display.Text = Convert.ToString(result);
                number = result;
            }

            if (operation == "/")
            {
                if (number2 == 0)
                {
                    Display.Text = "Stop playing with zeroes, pal";
                }
                else
                {
                    result = number / number2;
                    Display.Text = Convert.ToString(result);
                    number = result;
                }
            }
            if (operation == "*")
            {
                result = number * number2;
                Display.Text = Convert.ToString(result);
                number = result;
            }
            if (operation == "^")
            {
                result = Math.Pow(number, number2);
                Display.Text = Convert.ToString(result);
                number = result;
            }
        }

        private void btNmult_Click(object sender, EventArgs e)
        {
            number = Convert.ToDouble(Display.Text);
            Display.Text = "0";
            operation = "*";
        }

        private void btN2_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "2";
            }
            else
            {
                Display.Text += "2";
            }

        }

        private void btNadd_Click(object sender, EventArgs e)
        {
            number = Convert.ToDouble(Display.Text);
            Display.Text = "0";
            operation = "+";
        }

        private void btNclear_Click(object sender, EventArgs e)
        {
            Display.Text = "0";
        }

        private void btN1_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "1";
            }
            else
            {
                Display.Text += "1";
            }
        }

        private void Display_TextChanged(object sender, EventArgs e)
        {

        }

        private void btN3_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "3";
            }
            else
            {
                Display.Text += "3";
            }
        }

        private void btN4_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "4";
            }
            else
            {
                Display.Text += "4";
            }
        }

        private void btN5_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "5";
            }
            else
            {
                Display.Text += "5";
            }
        }

        private void btN6_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "6";
            }
            else
            {
                Display.Text += "6";
            }
        }

        private void btN7_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "7";
            }
            else
            {
                Display.Text += "7";
            }
        }

        private void btN8_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "8";
            }
            else
            {
                Display.Text += "8";
            }
        }

        private void btN9_Click(object sender, EventArgs e)
        {
            if (Display.Text == "0" && Display.Text != null)
            {
                Display.Text = "9";
            }
            else
            {
                Display.Text += "9";
            }
        }

        private void btN0_Click(object sender, EventArgs e)
        {
          if (Display.Text != "0")
            {
                Display.Text += "0";
            }
            else
            {
                Display.Text = "0";
            }
           
        }

        private void btNsubt_Click(object sender, EventArgs e)
        {
            number = Convert.ToDouble(Display.Text);
            Display.Text = "0";
            operation = "-";
        }

        private void btNdiv_Click(object sender, EventArgs e)
        {
            number = Convert.ToDouble(Display.Text);
            Display.Text = "0";
            operation = "/";
        }

        private void btNpoint_Click(object sender, EventArgs e)
        {
            if (Display.Text.Contains(".")) { }

            else { Display.Text += "."; }
            
        }

        private void btNoneDiv_Click(object sender, EventArgs e)
        {
            number = Convert.ToDouble(Display.Text);
            Display.Text = Convert.ToString(1 / number);
        }

        private void btNsquared_Click(object sender, EventArgs e)
        {
            number = Convert.ToDouble(Display.Text);
            Display.Text = Convert.ToString(number * number);
        }

        private void btNxtopowy_Click(object sender, EventArgs e)
        {
            number = Convert.ToDouble(Display.Text);
            Display.Text = "0";
            operation = "^";
        }
    }
}

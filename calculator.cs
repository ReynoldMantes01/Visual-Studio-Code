using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Calculator : Form
    {
        private decimal valueFirst = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal result = 0.0m;
        private string operators = "+";
        public Calculator()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "0";
            }
            else
            {
                textBox.Text += "0";
            }
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (!textBox.Text.Contains("."))
            {
                textBox.Text += ".";
            }
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "1";
            }
            else
            {
                textBox.Text += "1";
            }
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "2";
            }
            else
            {
                textBox.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "3";
            }
            else
            {
                textBox.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "4";
            }
            else
            {
                textBox.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "5";
            }
            else
            {
                textBox.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "6";
            }
            else
            {
                textBox.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "7";
            }
            else
            {
                textBox.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "8";
            }
            else
            {
                textBox.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "9";
            }
            else
            {
                textBox.Text += "9";
            }
        }

        private void buttonMinusPlus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                // Remove the last character
                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
            }

            // If the textbox becomes empty after backspace, set it to "0" for better UX
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = "0";
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(textBox.Text);
            operators = "-";
            textBox.Text += "-";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(textBox.Text);
            operators = "+";
            textBox.Text += "+";
        }

        private void buttonDevide_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(textBox.Text);
            operators = "/";
            textBox.Text += "/";
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(textBox.Text);
            operators = "x";
            textBox.Text += "x";
        }

        private void buttonModule_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(textBox.Text);
            operators = "%";
            textBox.Text += "%";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            try
            {
                int operatorIndex = textBox.Text.IndexOfAny(new char[] { '+', '-', 'x', '/', '%' });

                if (operatorIndex > 0)
                {

                    string firstPart = textBox.Text.Substring(0, operatorIndex);
                    string secondPart = textBox.Text.Substring(operatorIndex + 1);

                    valueFirst = decimal.Parse(firstPart.Trim());
                    valueSecond = decimal.Parse(secondPart.Trim());

                    char operation = textBox.Text[operatorIndex];
                    switch (operation)
                    {
                        case '+':
                            result = valueFirst + valueSecond;
                            break;
                        case '-':
                            result = valueFirst - valueSecond;
                            break;
                        case 'x':
                            result = valueFirst * valueSecond;
                            break;
                        case '/':
                            if (valueSecond == 0)
                            {
                                textBox.Text = "Error: Division by zero";
                                return;
                            }
                            result = valueFirst / valueSecond;
                            break;
                        case '%':
                            result = valueFirst % valueSecond;
                            break;
                    }

                    textBox.Text = result.ToString();
                }
                else
                {
                    throw new FormatException("Invalid input format");
                }
            }
            catch (FormatException)
            {
                textBox.Text = "Error: Invalid input";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            valueFirst = 0.0m;
            valueSecond = 0.0m;
            textBox.Text = "0";
        }

        private void label8_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Hide();
        }
    }
}

using CalculatorLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorUI
{
    public partial class CalcuatorForm : Form
    {
        double result = 0;
        string operation = "";
        double firstNumber = 0;
        double secondNumber = 0;
        bool check = false;
        private readonly ICalcOperations Operation;

        //CalculatorForm class constructor
        public CalcuatorForm(ICalcOperations operations)
        {
            InitializeComponent();
            Operation = operations;
        }

        //method to handle click events for number and dot(.) buttons
        private void number_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string buttonText = button.Text;

            if (operation == "" && check == true)
            {
                resultTextBox.Text = "0";
            }

            if (resultTextBox.Text == "0" && buttonText == "0" || resultTextBox.Text.IndexOf(".") >= 0 && buttonText == ".")
            {
                return;
            }

            if (resultTextBox.Text == "0" && buttonText != ".")
            {
                resultTextBox.Clear();
            }

            if (resultTextBox.Text.Length < 13)
            {
                resultTextBox.Text = resultTextBox.Text + buttonText;
            }
            check = false;
        }

        //method to handle click events for operator buttons
        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            
            if (firstNumber != 0)
            {
                equalButton.PerformClick();
                operation = button.Text;
            }
            else
            {
                operation = button.Text;
                firstNumber = double.Parse(resultTextBox.Text);
            }

            subView.Text = firstNumber + $" {operation}";

            if (subView.Text.Length > 12)
            {
                subView.Text = $"{firstNumber:E6} {operation}";
            }

            resultTextBox.Text = "0";
        }

        //method to handle click events for +/-, <, C and CE buttons
        private void mutation_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string buttonText = button.Text;

            if (buttonText == "+/-")
            {
                if (resultTextBox.Text == "0")
                {
                    return;
                }
                else if (resultTextBox.Text.IndexOf("-") >= 0)
                {
                    resultTextBox.Text = resultTextBox.Text.Substring(1);
                }
                else
                {
                    resultTextBox.Text = "-" + resultTextBox.Text;
                }
                return;
            }

            if (buttonText == "<")
            {
                resultTextBox.Text = resultTextBox.Text.Substring(0, resultTextBox.Text.Length - 1);

                if (resultTextBox.Text == "-" || resultTextBox.Text == "")
                {
                    resultTextBox.Text = "0";
                }
            }

            if (buttonText == "C")
            {
                resultTextBox.Text = "0";
            }

            if (buttonText == "CE")
            {
                resultTextBox.Text = "0";
                result = 0;
                firstNumber = 0;
                secondNumber = 0;
                subView.Text = "";
            }
        }

        //method to handle click events for equal sign button
        private void equal_click(object sender, EventArgs e)
        {
            secondNumber = double.Parse(resultTextBox.Text);
            try
            {
                //call CalculatorLibrary Equal method
                result = Operation.Equal(firstNumber, operation, secondNumber);
            }
            catch (Exception)
            {
                resultTextBox.Text = "ERR";
            }

            operation = "";
            firstNumber = result;

            if (resultTextBox.Text != "ERR")
            {
                resultTextBox.Text = result.ToString();
            }

            if (resultTextBox.Text.Length > 12)
            {
                resultTextBox.Text = result.ToString("E6");
            }
            check = true;

            subView.Text = "";
        }
    }
}

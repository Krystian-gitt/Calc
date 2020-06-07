using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }


        #region Form_Load ; Clean_Button; TextBox_Field


        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 5;
            textBox.Enabled = false; // Blocking opportunities for enter variables or text in textBox
            textBox1.Enabled = false; // Blocking opportunities for enter variables or text in textBox1

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Text box used to display the result
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            //Text box used to display first variable , math operator and second variable
        }

        private void bClean_Click(object sender, EventArgs e)
        {
            // Cleans all variable, after select ' C ' button
            mathOperator = '\0'; // same as char = null
            firstOperator = '\0';
            textBox.Text = null;
            textBox1.Text = null;
            firstNumber = null;
            secondNumber = null;


        }


        #endregion

        #region Variables declaration
        // Declaring variables used in program 
        string firstNumber;
        string secondNumber;
        char mathOperator = '\0';
        char firstOperator; // Example: user selected 2+2 and then selected √. This variable saved operator '+'

        #endregion

        #region Class constructor

        ClassLogicalOperation counter = new ClassLogicalOperation();

        #endregion


        #region Definition of method - for display and use in program first and second number


        public void MathOperation(int number)
        {



            if (mathOperator == '\0')
            {

                firstNumber += number;
                textBox1.Text = firstNumber; // To display first number 
            }
            else if (mathOperator == '√')
            {
                textBox.Text = "Najpierw wybierz liczbę"; // To use square root, first user must choose first number
            }

            else
            {

                secondNumber += number;
                textBox1.Text = firstNumber + " " + mathOperator + " " + secondNumber; //// To display first and second chosen number with math operator between them


            }




        }

        #endregion

        #region Logical button

        private void bPlus_Click(object sender, EventArgs e)
        {

            mathOperator = '+';
            textBox1.Text = firstNumber + " " + mathOperator; // To display first chosen number with math operator
            firstOperator = mathOperator;
            secondNumber = null; // To delete chosen second number when user select '+' again
        }

        private void bSubtract_Click(object sender, EventArgs e)
        {
            mathOperator = '-';
            textBox1.Text = firstNumber + " " + mathOperator; // To display first chosen number with math operator
            firstOperator = mathOperator;
            secondNumber = null; // To delete chosen second number when user select '+' again
        }

        private void bMultiply_Click(object sender, EventArgs e)
        {
            mathOperator = '*';
            textBox1.Text = firstNumber + " " + mathOperator; // To display first chosen number with math operator
            firstOperator = mathOperator;
            secondNumber = null; // To delete chosen second number when user select '+' again
        }

        private void bDivide_Click(object sender, EventArgs e)
        {
            mathOperator = '/';
            textBox1.Text = firstNumber + " " + mathOperator; // To display first chosen number with math operator
            firstOperator = mathOperator;
            secondNumber = null; // To delete chosen second number when user select '+' again
        }
        private void bSquare_Click(object sender, EventArgs e)
        {
            mathOperator = '√';

            if (firstNumber != null && secondNumber == null)
            {
                textBox1.Text = mathOperator + firstNumber; // To display first chosen number with math operator
                textBox.Text = counter.SquareRoot(double.Parse(firstNumber)).ToString();
            }

            else if (firstNumber != null && long.Parse(secondNumber) == 0) // First number different from 0 but second equal 0
            {
                textBox.Text = "Nie wolno dzielic przez 0";
                textBox1.Text = mathOperator + " ( " + firstNumber + " " + firstOperator + " " + secondNumber + " )";
            }
            else if (firstNumber != null && secondNumber != null) // When user select for example 2+2, this function adding first and then using the result   
            {
                switch (firstOperator)
                {
                    case '+':
                        textBox.Text = counter.SquareRoot(counter.Sum(long.Parse(firstNumber), long.Parse(secondNumber))).ToString();
                        textBox1.Text = mathOperator + " ( " + firstNumber + " " + firstOperator + " " + secondNumber + " )";
                        break;

                    case '-':
                        if (long.Parse(firstNumber) > long.Parse(secondNumber))
                        {
                            textBox.Text = counter.SquareRoot(counter.Minus(long.Parse(firstNumber), long.Parse(secondNumber))).ToString();
                            textBox1.Text = mathOperator + " ( " + firstNumber + " " + firstOperator + " " + secondNumber + " )";
                        }
                        else
                        {
                            textBox.Text = "Nieokreślony";
                            textBox1.Text = mathOperator + " ( " + firstNumber + " " + firstOperator + " " + secondNumber + " )";
                        }

                        break;

                    case '*':
                        textBox.Text = counter.SquareRoot(counter.Multiply(long.Parse(firstNumber), long.Parse(secondNumber))).ToString();
                        textBox1.Text = mathOperator + " ( " + firstNumber + " " + firstOperator + " " + secondNumber + " )";
                        break;

                    case '/':
                        textBox.Text = counter.SquareRoot(counter.Divide(long.Parse(firstNumber), long.Parse(secondNumber))).ToString();
                        textBox1.Text = mathOperator + " ( " + firstNumber + " " + firstOperator + " " + secondNumber + " )";
                        break;
                }
                // Clean variables
                firstNumber = null;
                firstOperator = ' ';
                mathOperator = ' ';
                secondNumber = null;

            }
            // If both selected variables equal 0
            else if (firstNumber == null && secondNumber == null)
            {
                textBox.Text = "0";
                textBox1.Text = "0";
            }

            //First variable is equal 0 and second  not
            else
            {
                textBox.Text = counter.SquareRoot(long.Parse(secondNumber)).ToString();
                textBox1.Text = mathOperator + " 0 " + " " + firstOperator + secondNumber;
            }


        }

        #endregion

        #region Equal - switch-case structure
     
        private void bEqual_Click(object sender, EventArgs e)
        {
            // After click button equal. In based on mathoperator are selected different math operations
            switch (mathOperator)
            {


                case ('+'):

                    if (firstNumber == null && secondNumber != null)
                    {
                        textBox.Text = counter.Sum(0, long.Parse(secondNumber)).ToString();
                    }

                    else if (firstNumber != null && secondNumber == null)
                    {
                        textBox.Text = counter.Sum(long.Parse(firstNumber), long.Parse(firstNumber)).ToString();
                        textBox1.Text = firstNumber + " " + mathOperator + " " + firstNumber;
                    }

                    else if (firstNumber == null && secondNumber == null)
                    {
                        textBox.Text = counter.Sum(0, 0).ToString();
                    }

                    else
                    {

                        textBox.Text = counter.Sum(long.Parse(firstNumber), long.Parse(secondNumber)).ToString();
                    }
                    break;

                case '-':

                    if (firstNumber == null && secondNumber != null)
                    {
                        textBox.Text = counter.Minus(0, long.Parse(secondNumber)).ToString();
                    }

                    else if (firstNumber != null && secondNumber == null)
                    {
                        textBox.Text = counter.Minus(long.Parse(firstNumber), long.Parse(firstNumber)).ToString();
                        textBox1.Text = firstNumber + " " + mathOperator + " " + firstNumber;
                    }

                    else if (firstNumber == null && secondNumber == null)
                    {
                        textBox.Text = counter.Minus(0, 0).ToString();
                    }

                    else
                    {
                        textBox.Text = counter.Minus(long.Parse(firstNumber), long.Parse(secondNumber)).ToString();
                    }
                    break;

                case '*':

                    if (firstNumber == null && secondNumber != null)
                    {
                        textBox.Text = counter.Multiply(0, long.Parse(secondNumber)).ToString();
                    }

                    else if (firstNumber != null && secondNumber == null)
                    {
                        textBox.Text = counter.Multiply(long.Parse(firstNumber), long.Parse(firstNumber)).ToString();
                        textBox1.Text = firstNumber + " " + mathOperator + " " + firstNumber;
                    }

                    else if (firstNumber == null && secondNumber == null)
                    {
                        textBox.Text = counter.Multiply(0, 0).ToString();
                    }

                    else
                    {
                        textBox.Text = counter.Multiply(long.Parse(firstNumber), long.Parse(secondNumber)).ToString();
                    }
                    break;

                case '/':

                    if (firstNumber == null && secondNumber != null)
                    {
                        textBox.Text = counter.Divide(0, long.Parse(secondNumber)).ToString();
                    }

                    else if (firstNumber != null && secondNumber == null)
                    {
                        textBox.Text = counter.Divide(long.Parse(firstNumber), long.Parse(firstNumber)).ToString();
                        textBox1.Text = firstNumber + " " + mathOperator + " " + firstNumber;
                    }

                    else if (firstNumber == null && secondNumber == null)
                    {
                        textBox.Text = counter.Divide(0, 0).ToString();
                    }
                    // If user select second number equal 0
                    else if (firstNumber != null && long.Parse(secondNumber) == 0)
                    {
                        textBox.Text = "Nie można dzielić przez 0";
                    }

                    else
                    {
                        textBox.Text = counter.Divide(double.Parse(firstNumber), double.Parse(secondNumber)).ToString();
                    }
                    break;

            }
            // Clean variables
            mathOperator = '\0';
            firstOperator = '\0';
            firstNumber = null;
            secondNumber = null;
        }

        #endregion

        #region Numerical button

        private void b0_Click(object sender, EventArgs e)
        {
            MathOperation(0);
        }
        private void b1_Click(object sender, EventArgs e)
        {
            MathOperation(1);
        }
        private void b2_Click(object sender, EventArgs e)
        {
            MathOperation(2);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            MathOperation(3);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            MathOperation(4);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            MathOperation(5);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            MathOperation(6);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            MathOperation(7);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            MathOperation(8);
        }

        private void b9_Click(object sender, EventArgs e)
        {
            MathOperation(9);
        }



        #endregion




    }
}

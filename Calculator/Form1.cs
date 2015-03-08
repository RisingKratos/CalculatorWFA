using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string userInput = string.Empty;        //user's previous inputs' storage
        string firstOperand = string.Empty;     //first operand number
        string secondOperand = string.Empty;      //second operand number
        char operation;                         //type of operation
        double result = 0.0;                    //result, get from equal 
        
        //Unknown function, represents Form, but don't  know, how to use
        public Form1()
        {
            InitializeComponent();
        }

        //also unknown function, represents textbox changes
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void one_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            userInput += "1";
            this.textBox1.Text += userInput; 
        }   

        private void two_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            userInput += "2";
            this.textBox1.Text += userInput; 
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            userInput += "3";
            this.textBox1.Text += userInput;
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            userInput += "4";
            this.textBox1.Text += userInput;
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            userInput += "5";
            this.textBox1.Text += userInput;
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            userInput += "6";
            this.textBox1.Text += userInput;
        }
        
        private void seven_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            userInput += "7";
            this.textBox1.Text += userInput;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            userInput += "8";
            this.textBox1.Text += userInput;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            userInput += "9";
            this.textBox1.Text += userInput;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            userInput += "0";
            this.textBox1.Text += userInput;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            firstOperand = userInput;
            operation = '+';
            userInput = string.Empty;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            firstOperand = userInput;
            operation = '-';
            userInput = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void multiply_Click(object sender, EventArgs e)
        {
            firstOperand = userInput;
            operation = '*';
            userInput = string.Empty;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            firstOperand = userInput;
            operation = '/';
            userInput = string.Empty;
        }
                

        private void clear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.userInput = string.Empty;
            this.firstOperand = string.Empty;
            this.secondOperand = string.Empty;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            userInput += ".";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            
            double firstNum, secondNum;
            double.TryParse(firstOperand, out firstNum);
            
            if (operation == '+')
            {
                secondOperand = userInput;
                double.TryParse(secondOperand, out secondNum);
                result = firstNum + secondNum;
                textBox1.Text = result.ToString();
            }
            else if (operation == '-')
            {
                secondOperand = userInput;
                double.TryParse(secondOperand, out secondNum);
                result = firstNum - secondNum;
                textBox1.Text = result.ToString();
            }
            else if (operation == '*')
            {
                secondOperand = userInput;
                double.TryParse(secondOperand, out secondNum);
                result = firstNum * secondNum;
                textBox1.Text = result.ToString();
            }
            else if (operation == '/')
            {
                secondOperand = userInput;
                double.TryParse(secondOperand, out secondNum);
                result = firstNum / secondNum;
                textBox1.Text = result.ToString();
            }
            else if (operation == 's') 
            {
                result = Math.Sin(firstNum);
                textBox1.Text = result.ToString();
            }
            else if (operation == 'c') 
            {
                result = Math.Cos(firstNum);
                textBox1.Text = result.ToString();
            }
            else if (operation == 't') 
            {
                result = Math.Tan(firstNum);
                textBox1.Text = result.ToString();
            }
            else if (operation == 'p') 
            {
                secondOperand = userInput;
                double.TryParse(secondOperand, out secondNum);
                result = 1;
                for (int i = 0; i < secondNum; ++i) 
                {
                    result *= firstNum; 
                }
                textBox1.Text = result.ToString();
            }
            else if (operation == 'q') 
            {
                result = Math.Sqrt(firstNum);
                textBox1.Text = result.ToString();
            }
            else if (operation == 'o')
            {
                secondOperand = userInput;
                double.TryParse(secondOperand, out secondNum);
                int secondConvertedNum = Convert.ToInt32(secondNum);                
                if (firstNum == 0)
                {
                    Console.WriteLine('0');
                }
                else
                {
                    int firstConvertedNum = Convert.ToInt32(firstNum);
                    string Changed = Convert.ToString(firstConvertedNum, secondConvertedNum);
                    textBox1.Text = Changed;
                }            
            }
        }

        private void sin_Click(object sender, EventArgs e)
        {
            firstOperand = userInput;
            operation = 's';
            userInput = string.Empty;  
        }

        private void cos_Click(object sender, EventArgs e)
        {
            firstOperand = userInput;
            operation = 'c';
            userInput = string.Empty; 
        }

        private void tan_Click(object sender, EventArgs e)
        {
            firstOperand = userInput;
            operation = 't';
            userInput = string.Empty; 
        }

        private void power_Click(object sender, EventArgs e)
        {
            firstOperand = userInput;
            operation = 'p';
            userInput = string.Empty; 
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            firstOperand = userInput;
            operation = 'q';
            userInput = string.Empty;
        }

        private void ToOtherSystem_Click(object sender, EventArgs e)
        {
            firstOperand = userInput;
            operation = 'o';
            userInput = string.Empty;
        }
    }
}


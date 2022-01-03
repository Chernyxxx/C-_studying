using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_Calculator_WinForms
{
    public partial class Form1 : Form
    {
        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userInput = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";            // Очистка дисплея
            userInput +=1;                          // В переменную userInput дописываем 1
            CalculatorDisplay.Text =userInput;      // Выводим на дисплей userInput
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += 2;
            CalculatorDisplay.Text = userInput;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += 3;
            CalculatorDisplay.Text = userInput;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += 4;
            CalculatorDisplay.Text = userInput;
        }

         private void button5_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += 5;
            CalculatorDisplay.Text = userInput;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += 6;
            CalculatorDisplay.Text = userInput;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += 7;
            CalculatorDisplay.Text = userInput; 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += 8;
            CalculatorDisplay.Text = userInput;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += 9;
            CalculatorDisplay.Text = userInput;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += 0;
            CalculatorDisplay.Text = userInput;
        }

        private void button_comma_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += ',';
            CalculatorDisplay.Text = userInput;
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            first = userInput;              // В первое число присваиваем ввод с клавиш
            userInput = "";                 // Очищаем переменную userInput
            function = '+';                 
            CalculatorDisplay.Text = first; // Выводим на дисплей первое число вместо 
                                            // очищенного userInput ( на дисплее всё 
                                            // останется так же)
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            first = userInput;
            userInput = "";
            function = '-';
            CalculatorDisplay.Text = first;

        }

        private void button_mult_Click(object sender, EventArgs e)
        {
            first = userInput;
            userInput = "";
            function = '*';
            CalculatorDisplay.Text = first;
        }

        private void button_dev_Click(object sender, EventArgs e)
        {
            first = userInput;
            userInput = "";
            function = '/';
            CalculatorDisplay.Text = first;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            userInput = "";                       // После нажатия С очищаем userInput
                                                  // в нем находился результат операции
            CalculatorDisplay.Text = "0";          
        }

        private void button_egual_Click(object sender, EventArgs e)
        {
            second = userInput;             // После ввода + - * или / userInput был очищен
                                            // Далее в него было введено с клавиш второе
                                            // число. После нажатия = присваиваем userInput
                                            //  в second
            if (function == '+')
            {
                result = double.Parse(first) + double.Parse(second);
            }
            else if (function == '-')
            {
                result = double.Parse(first) - double.Parse(second);
            }
            else if (function == '*')
            {
                result = double.Parse(first) * double.Parse(second);
            }
            else if (function == '/')
            {
                if(double.Parse(second) == 0.0)
                {
                    CalculatorDisplay.Text = "ERROR";
                }
                else
                {
                    result = double.Parse(first) / double.Parse(second);
                }              
            }
            CalculatorDisplay.Text = result.ToString();     // Выводим результат
            userInput = result.ToString();                  // Присваиваем в userInput
                                                            // результат последнего 
                                                 // вычисления, чтобы можно было сразу 
                                                 // выполнять следующее действие
        }
    }
}

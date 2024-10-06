using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class CalculatorForm : Form
    {
        private CalculatorModel _model;

        private double _currentNumber;
        private double _bufferNumber;
        private bool _isSignBeforeNumberNeeded = true;
        private MathOperations _choosenMathOperation;


        public CalculatorForm()
        {
            InitializeComponent();
            _model = new CalculatorModel();
        }

       
        private void One_button_Click(object sender, EventArgs e) => InputField_textBox.Text = InputField_textBox.Text + 1;
        private void Zero_button_Click(object sender, EventArgs e) => InputField_textBox.Text = InputField_textBox.Text + 0;
        private void Two_button_Click(object sender, EventArgs e) => InputField_textBox.Text = InputField_textBox.Text + 2;
        private void Three_button_Click_1(object sender, EventArgs e) => InputField_textBox.Text = InputField_textBox.Text + 3;
        private void Four_button_Click(object sender, EventArgs e) => InputField_textBox.Text = InputField_textBox.Text + 4;
        private void Five_button_Click(object sender, EventArgs e) => InputField_textBox.Text = InputField_textBox.Text + 5;
        private void Six_button_Click(object sender, EventArgs e) => InputField_textBox.Text = InputField_textBox.Text + 6; 
        private void Seven_button_Click(object sender, EventArgs e) => InputField_textBox.Text = InputField_textBox.Text + 7;
        private void Eight_button_Click(object sender, EventArgs e) => InputField_textBox.Text = InputField_textBox.Text + 8;
        private void Nine_button_Click(object sender, EventArgs e) => InputField_textBox.Text = InputField_textBox.Text + 9;

        private void Comma_button_Click(object sender, EventArgs e)
        {
            InputField_textBox.Text = InputField_textBox.Text + ".";
            // место для обработки ситуации когда какой-то хер захочет поставить подряд несколько запятых
        }

        private void All_Clear_button_Click(object sender, EventArgs e) => InputField_textBox.Clear();

        private void ClearOne_button_Click(object sender, EventArgs e)
        {
            int lenght = InputField_textBox.Text.Length - 1;
            string text = InputField_textBox.Text;
            InputField_textBox.Clear();

            for (int i = 0; i < lenght; i++)
                InputField_textBox.Text = InputField_textBox.Text + text[i];
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            _currentNumber = double.Parse(InputField_textBox.Text);
            InputField_textBox.Clear();
            _choosenMathOperation = MathOperations.Add;
            _isSignBeforeNumberNeeded = true;

        }
        private void Substract_button_Click(object sender, EventArgs e)
        {
            _currentNumber = double.Parse(InputField_textBox.Text);
            InputField_textBox.Clear();
            _choosenMathOperation = MathOperations.Subtract;
            _isSignBeforeNumberNeeded = true;
        }

        private void Multiple_button_Click(object sender, EventArgs e)
        {
            _currentNumber = double.Parse(InputField_textBox.Text);
            InputField_textBox.Clear();
            _choosenMathOperation = MathOperations.Multiple;
            _isSignBeforeNumberNeeded = true;
        }

        private void Division_button_Click(object sender, EventArgs e)
        {
            _currentNumber = double.Parse(InputField_textBox.Text);
            InputField_textBox.Clear();
            _choosenMathOperation = MathOperations.Division;
            _isSignBeforeNumberNeeded = true;
        }

        private void Percent_button_Click(object sender, EventArgs e)
        {
            _currentNumber = double.Parse(InputField_textBox.Text);
            InputField_textBox.Clear();
            _choosenMathOperation = MathOperations.Division;
            _isSignBeforeNumberNeeded = false;
        }

        private void ChangeSign_button_Click(object sender, EventArgs e)
        {
            if(_isSignBeforeNumberNeeded)
            {
                InputField_textBox.Text = "-" + InputField_textBox.Text;
                _isSignBeforeNumberNeeded = false;
            }
            else if (!_isSignBeforeNumberNeeded)
            {
                InputField_textBox.Text = InputField_textBox.Text.Replace("-", "");
                _isSignBeforeNumberNeeded = true;
            }
        }

        private void Calculate_button_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {
            switch (_choosenMathOperation)
            {
                case MathOperations.Add:
                    _bufferNumber = _currentNumber + double.Parse(InputField_textBox.Text);
                    InputField_textBox.Text = _bufferNumber.ToString();
                    break;

                case MathOperations.Subtract:
                    _bufferNumber = _currentNumber - double.Parse(InputField_textBox.Text);
                    InputField_textBox.Text = _bufferNumber.ToString();
                    break;

                case MathOperations.Multiple:
                    _bufferNumber = _currentNumber * double.Parse(InputField_textBox.Text);
                    InputField_textBox.Text = _bufferNumber.ToString();
                    break;

                case MathOperations.Division:
                    double divider;
                    divider = double.Parse(InputField_textBox.Text);
                    
                    if (divider == 0.0)
                        MessageBox.Show("На 0 делить запрещено");
                    else
                    {
                        _bufferNumber = _currentNumber / double.Parse(InputField_textBox.Text);
                        InputField_textBox.Text = _bufferNumber.ToString();
                    }
                    break;
                case MathOperations.Percent:
                    _bufferNumber = _currentNumber % double.Parse(InputField_textBox.Text);
                    InputField_textBox.Text = _bufferNumber.ToString();
                    break;

                default:
                    break;      
            }
        }

        enum MathOperations
        {
            Add,
            Subtract,
            Multiple,
            Division,
            Percent
        }
    }
}

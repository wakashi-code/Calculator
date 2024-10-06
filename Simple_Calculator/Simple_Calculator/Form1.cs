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
        
        public CalculatorForm()
        {
            InitializeComponent();
            _model = new CalculatorModel();
        }

        public void UpdateUI()
        {
            NumberInputField_label.Text = _model.CurrentNumber;
        }

        private void One_button_Click(object sender, EventArgs e)
        {
            InputField_textBox.Text = InputField_textBox.Text + 1;
            UpdateUI();
        }

        private void Zero_button_Click(object sender, EventArgs e)
        {
            InputField_textBox.Text = InputField_textBox.Text + 0;
            UpdateUI();
        }

        private void Two_button_Click(object sender, EventArgs e)
        {
            InputField_textBox.Text = InputField_textBox.Text + 2;
            UpdateUI();
        }

        private void Three_button_Click_1(object sender, EventArgs e)
        {
            InputField_textBox.Text = InputField_textBox.Text + 3;
            UpdateUI();
        }

        private void Four_button_Click(object sender, EventArgs e)
        {
            InputField_textBox.Text = InputField_textBox.Text + 4;
            UpdateUI();
        }

        private void Five_button_Click(object sender, EventArgs e)
        {
            InputField_textBox.Text = InputField_textBox.Text +5;
            UpdateUI();
        }

        private void Six_button_Click(object sender, EventArgs e)
        {
            InputField_textBox.Text = InputField_textBox.Text + 6;
            UpdateUI();
        }

        private void Seven_button_Click(object sender, EventArgs e)
        {
            InputField_textBox.Text = InputField_textBox.Text + 7;
            UpdateUI();
        }

        private void Eight_button_Click(object sender, EventArgs e)
        {
            InputField_textBox.Text = InputField_textBox.Text + 8;
            UpdateUI();
        }

        private void Nine_button_Click(object sender, EventArgs e)
        {
            InputField_textBox.Text = InputField_textBox.Text + 9;
            UpdateUI();
        }

        private void Comma_button_Click(object sender, EventArgs e)
        {
            InputField_textBox.Text = InputField_textBox.Text + ".";
    
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void All_Clear_button_Click(object sender, EventArgs e)
        {
            InputField_textBox.Clear();
        }

        private void ClearOne_button_Click(object sender, EventArgs e)
        {
            int lenght = InputField_textBox.Text.Length - 1;
            string text = InputField_textBox.Text;
            InputField_textBox.Clear();

            for (int i = 0; i < lenght; i++)
                InputField_textBox.Text = InputField_textBox.Text + text[i];
        }
    }
}

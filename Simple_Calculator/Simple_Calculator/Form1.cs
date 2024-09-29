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
            _model.InputCurrentNumber("1");
            UpdateUI(); 
            // fl3lf3
        }
    }
}

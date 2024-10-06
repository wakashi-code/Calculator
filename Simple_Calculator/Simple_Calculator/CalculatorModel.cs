using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    internal class CalculatorModel
    {
        string _currentNumber;
        string _bufferNumber;
        string _currentOperation;

        double _dCurrentNumber;
        double _dBufferNumber;

        private CalculatorForm _form;

        public string CurrentNumber => _currentNumber;
        public string BufferNumber => _bufferNumber;
        public string Operation => _currentOperation;


        public void InputCurrentNumber()
        {
            _dCurrentNumber = int.Parse(_currentNumber);
        }

        public void InputCurrentOperation()
        {
           // _currentOperation
        }

        public void InputBufferNumber()
        {
            _dBufferNumber = int.Parse(_bufferNumber);
        }

        public void ClearAllInput()
        {
            _currentNumber = null;
            _bufferNumber = null;
            _currentOperation = null;
            
        }

        public void ClearOneSymbol()
        {

        }

        public void InputComma() { }

        public void Calculate() { }


    }
}

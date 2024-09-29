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

        public string CurrentNumber => _currentNumber;
        public string BufferNumber => _bufferNumber;
        public string Operation => _currentOperation;


        public void InputCurrentNumber(string currentNumber)
        {
            currentNumber = _currentNumber;
        }

        public void InputCurrentOperation(string currentOperation)
        {
            currentOperation = _currentOperation;
        }

        public void InputBufferNumber(string bufferNumber)
        {
            _bufferNumber = bufferNumber;
        }

        public void ClearAllInput() { }

        public void ClearOneSymbol() { }

        public void InputComma() { }

        public void Calculate() { }


    }
}

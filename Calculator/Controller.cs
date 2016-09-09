using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Controller
    {
        private CalculatorView CalculatorView;
        private Calculator Calculator;

        public Controller()
        {
            Calculator = new Calculator();
            CalculatorView = new CalculatorView();
        }

        public void start()
        {
            string input = CalculatorView.AskDateOfBirth();
            DateTime dateOfBirth;

            if (Calculator.ParseInput(input, out dateOfBirth))
            {
                CalculatorView.PrintAge(Calculator.CalculateAge(dateOfBirth));
            }
            else
            {
                CalculatorView.PrintWrongInput();
            }

            start();
        }
    }
}

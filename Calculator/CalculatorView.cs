using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CalculatorView
    {
        public string AskDateOfBirth()
        {
            Console.WriteLine("=== Voer je geboorte datum in (dd-mm-yyyy) ===");
            String input = Console.ReadLine();
            return input;
        }

        public void PrintAge(int age)
        {
            Console.WriteLine("Je leeftijd is: {0}", age);
        }

        public void PrintWrongInput()
        {
            Console.WriteLine("Verkeerde input, probeer nog eens.");
        }
    }
}

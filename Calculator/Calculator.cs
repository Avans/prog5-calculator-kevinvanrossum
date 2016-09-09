using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator : IAgeCalculator
    {

        public bool ParseInput(string input, out DateTime result)
        {
            if (DateTime.TryParseExact(input, "dd-MM-yyyy",
                           CultureInfo.InvariantCulture,
                           DateTimeStyles.None,
                           out result))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int CalculateAge(DateTime dateOfBirth)
        {
            DateTime now = DateTime.Now;
            int age = now.Year - dateOfBirth.Year;

            if (now.Month < dateOfBirth.Month || (now.Month == dateOfBirth.Month && now.Day < dateOfBirth.Day))
                age--;

            return age;
        }
    }
}

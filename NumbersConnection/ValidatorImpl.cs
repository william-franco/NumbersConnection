using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersConnection
{
    public class ValidatorImpl : IValidator
    {
        // Check if the number is positive
        public void NumberIsPositive(int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Number must be positive.");
            }
        }

        // Check if the number is valid
        public void NumberIsString(string value) 
        {
            if (!int.TryParse(value, out _))
            {
                throw new ArgumentException("Value must be a number.");
            }
        }

        public int ValidateInput(string value)
        {
            NumberIsString(value);
            NumberIsPositive(Convert.ToInt32(value));
            return Convert.ToInt32(value);
        }
    }
}

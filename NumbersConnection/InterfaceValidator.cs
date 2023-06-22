using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersConnection
{
    public interface IValidator
    {
        public void NumberIsPositive(int value) { }

        public void NumberIsString(string value) { }

        public int ValidateInput(string value)
        {
            return 0;
        }
    }
}

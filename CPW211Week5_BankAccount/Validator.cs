using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211Week5_BankAccount
{
    public static class Validator
    {
        public static bool IsWithinRange(double minValue, double maxValue, double valueToTest)
        {
            if (valueToTest >= minValue && valueToTest <= maxValue)
            {
                return true;
            }
            return false;
        }
    }
}

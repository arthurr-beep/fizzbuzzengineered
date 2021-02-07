using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace FizzBuzz.Services.Services
{
    public class NumberRule : Rules
    {
        public override string RuleSatisfied(int number)
        {
            return number.ToString(CultureInfo.InvariantCulture);
        }
    }
}

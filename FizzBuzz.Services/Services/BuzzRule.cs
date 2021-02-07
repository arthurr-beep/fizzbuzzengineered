using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.Services.Services
{
    public class BuzzRule : Rules
    {
        public override string RuleSatisfied(int number)
        {
            if (number % 5 == 0)
                return "Buzz";
            return Next.RuleSatisfied(number);
        }
    }
}

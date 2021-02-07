using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.Services.Services
{
    public class FizzRule : Rules
    {
        public override string RuleSatisfied(int number)
        {
            if (number % 3 == 0)
                return "Fizz";

            return Next.RuleSatisfied(number);
        }
    }
}

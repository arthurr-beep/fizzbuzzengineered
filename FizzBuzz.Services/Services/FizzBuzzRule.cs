using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.Services.Services
{
    public class FizzBuzzRule : Rules
    {
        public override string RuleSatisfied(int number)
        {
            if (number % 15 == 0)
                return "FizzBuzz";

            return Next.RuleSatisfied(number);
        }
    }
}

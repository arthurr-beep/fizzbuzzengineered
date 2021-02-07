using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace FizzBuzz.Services.Services
{
    public abstract class Rules
    {
        public Rules ChainNext(Rules next)
        {
            Next = next;
            return Next;
        } 

        protected Rules Next { get; private set; }

        public abstract string RuleSatisfied(int number);
    }

    public class RulesChain
    {
        private RulesChain()
        {
            Head = new FizzBuzzRule();
            Head.ChainNext(new BuzzRule())
                .ChainNext(new FizzRule())
                .ChainNext(new NumberRule());

        }
        private Rules Head { get; set; }

        public static string Check(int number)
        {
            return _rulesChain.Head.RuleSatisfied(number);
        }

        private static readonly RulesChain _rulesChain = new RulesChain();
    }
}

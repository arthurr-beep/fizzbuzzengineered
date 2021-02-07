using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz.Services.Interfaces;

namespace FizzBuzz.Services.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public string Check(int number)
        {
            var response = RulesChain.Check(number);
            return response;
        }
    }
}

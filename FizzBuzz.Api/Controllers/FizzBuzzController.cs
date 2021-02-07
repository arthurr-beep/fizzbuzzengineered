using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzz.Api.Interfaces.IQueryHandlers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzz.Api.Controllers
{
   
    public class FizzBuzzController : BaseApiController
    {
        private readonly IFizzBuzzQueryHandler _fizzBuzzQueryHandler;
        public FizzBuzzController(IFizzBuzzQueryHandler fizzBuzzQueryHandler)
        {
            _fizzBuzzQueryHandler = fizzBuzzQueryHandler;
        }
        
        /// <summary>
        /// A Simple FizzBuzz Checker
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        [HttpGet("check/{number}")]
        public async Task<IActionResult> FizzBuzz(int number)
        {
            var response = await _fizzBuzzQueryHandler.FizzBuzz(number);
            return Ok(response);
        }
    }
}

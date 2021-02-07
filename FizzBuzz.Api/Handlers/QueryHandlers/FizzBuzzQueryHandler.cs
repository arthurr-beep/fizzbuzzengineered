using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzz.Api.Interfaces.IQueryHandlers;
using FizzBuzz.Api.ResponseModels.QueryResponseModels;
using FizzBuzz.Services.Interfaces;

namespace FizzBuzz.Api.Handlers.QueryHandlers
{
    public class FizzBuzzQueryHandler : IFizzBuzzQueryHandler
    {
        private readonly IFizzBuzzService _fizzBuzzService;

        public FizzBuzzQueryHandler(IFizzBuzzService fizzBuzzService)
        {
            _fizzBuzzService = fizzBuzzService;
        }
        public async Task<FizzBuzzResponseModel> FizzBuzz(int number)
        {
            var response = _fizzBuzzService.Check(number);
            var responseModel = new FizzBuzzResponseModel
            {
                Response = response
            };
            return responseModel;
        }
    }
}

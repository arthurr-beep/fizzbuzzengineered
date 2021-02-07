using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzz.Api.ResponseModels.QueryResponseModels;

namespace FizzBuzz.Api.Interfaces.IQueryHandlers
{
    public interface IFizzBuzzQueryHandler
    {
        Task<FizzBuzzResponseModel> FizzBuzz(int number);
    }
}

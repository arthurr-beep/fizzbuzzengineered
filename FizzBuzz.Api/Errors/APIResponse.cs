using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz.Api.Errors
{
    public class APIResponse
    {
        public APIResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessage(statusCode);
        }

       

        public int StatusCode { get; set; }
        public string Message { get; set; }

        private string GetDefaultMessage(in int statusCode)
        {
            return statusCode switch
            {
                400 => "Bad Request",
                404 => "Resource not found",
                500 => "An error Occured, please try again",
                _ => null
            };
        }
    }
}

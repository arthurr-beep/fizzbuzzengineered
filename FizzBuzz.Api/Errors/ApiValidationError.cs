using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz.Api.Errors
{
    public class ApiValidationError : APIResponse
    {
        public ApiValidationError() : base(400)
        {
            
        }

        public IEnumerable<string> Errors { get; set; }
    }
}

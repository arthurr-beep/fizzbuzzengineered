using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzz.Api.Errors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzz.Api.Controllers
{
    [Route("errors/{statusCode}")]
   
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErrorsController : BaseApiController
    {
        public IActionResult Error(int statusCode)
        {
            return new ObjectResult(new APIResponse(statusCode));
        }
    }
}

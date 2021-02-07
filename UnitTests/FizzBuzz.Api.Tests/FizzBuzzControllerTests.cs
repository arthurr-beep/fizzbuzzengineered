using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz.Api.Controllers;
using FizzBuzz.Api.Interfaces.IQueryHandlers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;

namespace FizzBuzz.Api.Tests
{
    public class FizzBuzzControllerTests
    {
        private readonly  Mock<IFizzBuzzQueryHandler> _fizzbuzzQueryMock = new Mock<IFizzBuzzQueryHandler>();
        private readonly FizzBuzzController _fizzBuzzController;

        public FizzBuzzControllerTests()
        {
            _fizzBuzzController = new FizzBuzzController(_fizzbuzzQueryMock.Object);
        }

        [TearDown]
        public void Cleanup()
        {
            _fizzbuzzQueryMock.Reset();
        }

        [Test]
        [TestCase(30)]
        [TestCase(10)]
        [TestCase(12)]
        [TestCase(17)]
        public async Task Check(int number)
        {
            var result = await _fizzBuzzController.FizzBuzz(number);
            var response = result as OkObjectResult;

            Assert.NotNull(result);
            Assert.IsInstanceOf(typeof(OkObjectResult), result);
            Assert.AreEqual(200, response.StatusCode);
        }
    }
}

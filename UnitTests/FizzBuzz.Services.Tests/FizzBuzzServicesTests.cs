using System;
using System.Collections.Generic;
using System.Text;
using FizzBuzz.Services.Interfaces;
using FizzBuzz.Services.Services;
using NUnit.Framework;

namespace FizzBuzz.Services.Test
{
    public class FizzBuzzServicesTests
    {
        private readonly IFizzBuzzService _fizzBuzzService;

        public FizzBuzzServicesTests()
        {
            _fizzBuzzService = new FizzBuzzService();
        }

        [Test]
        [TestCase(45)]
        [TestCase(60)]
        public void TestFizzBuzz(int number)
        {
            var result = _fizzBuzzService.Check(number);

            Assert.NotNull(result);
            Assert.AreEqual("FizzBuzz", result);
        }


        [Test]
        [TestCase(9)]
        [TestCase(81)]
        public void TestFizz(int number)
        {
            var result = _fizzBuzzService.Check(number);

            Assert.NotNull(result);
            Assert.AreEqual("Fizz", result);
        }

        [Test]
        [TestCase(10)]
        [TestCase(25)]
        public void TestBuzz(int number)
        {
            var result = _fizzBuzzService.Check(number);

            Assert.NotNull(result);
            Assert.AreEqual("Buzz", result);
        }

        [Test]
        public void TestNumber()
        {
            var result = _fizzBuzzService.Check(23);

            Assert.NotNull(result);
            Assert.AreEqual("23", result);
        }

    }
}

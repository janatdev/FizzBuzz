using System;
using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTest
{
    [TestClass]
    public class FizzBuzzUnitTest
    {
        [TestMethod]
        public void TestMethodFizzBuzz()
        {
            FizzBuzzBusinessLogic.FizzBuzz(1,20);
        }

        [TestMethod]
        public void TestMethodFizz()
        {
            FizzBuzzBusinessLogic.FizzBuzz(20, 50);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPNCalculator;
namespace UnitTestProject1
{
    [TestClass]
    public class RPNCalculatorTests
    {
        [TestMethod]
        public void SingleNumber()
        {
            Calculator calc = new Calculator();
            double result = calc.EvaluatePostfix("5");
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void SimpleAddition()
        {
            Calculator calc = new Calculator();
            double result = calc.EvaluatePostfix("2 3 +");
            Assert.AreEqual(5, result);
        }
    }
}

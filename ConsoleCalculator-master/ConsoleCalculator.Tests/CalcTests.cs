using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator.Tests
{
	[TestClass()]

	public class CalcTests
	{
		[TestMethod()]

		public void AddTest() // test valid answer (looking for true)
		{
			double num1 = 5, num2 = 6;
			var calc = new ConsoleCalculator.Calculator(num1, num2);
			Assert.IsTrue(calc.Add() == num1 + num2);
		}

        [TestMethod()]

        public void AddTestParam() // test invalid answer (looking for false)
        {
            double num1 = 5, num2 = 6;
            double result = new ConsoleCalculator.Calculator.Add(num1, num2);
			Assert.IsFalse(result == 0);
        }

        [TestMethod()]

        public void SubtractTest() 
        {
            double num1 = 5, num2 = 3;
            var calc = new ConsoleCalculator.Calculator(num1, num2);
            Assert.IsTrue(calc.Subtract() == num1 - num2);
        }

        [TestMethod()]

        public void SubtractTestParam() 
        {
            double num1 = 5, num2 = 3;
            double result = new ConsoleCalculator.Calculator.Subtract(num1, num2);
            Assert.IsFalse(result == 0);
        }

        [TestMethod()]

        public void MultiplyTest() 
        {
            double num1 = 5, num2 = 6;
            var calc = new ConsoleCalculator.Calculator(num1, num2);
            Assert.IsTrue(calc.Multiply() == num1 * num2);
        }

        [TestMethod()]

        public void MultiplyTestParam() 
        {
            double num1 = 5, num2 = 6;
            double result = new ConsoleCalculator.Calculator.Multiply(num1, num2);
            Assert.IsFalse(result == 0);
        }

        [TestMethod()]

        public void DivideTest() 
        {
            double num1 = 15, num2 = 3;
            var calc = new ConsoleCalculator.Calculator(num1, num2);
            Assert.IsTrue(calc.Divide() == num1 / num2);
        }

        [TestMethod()]

        public void DivideTestParam() 
        {
            double num1 = 15, num2 = 3;
            double result = new ConsoleCalculator.Calculator.Divide(num1, num2);
            Assert.IsFalse(result == 0);
        }
    }
}
// testing testing


using Microsoft.VisualStudio.TestTools;
using CalculatorApp.Operations;
using CalculatorApp.Interfaces;
using System;

namespace CalculatorApp.Tests
{
    [TestClass]
    public class OperationTests
    {
        [TestMethod]
        public void TestAddition_PositiveNumbers_ShouldReturnCorrectSum()
        {
            IAddition adder = new Addition();
            double a = 5.5;
            double b = 4.5;
            double expected = 10.0;

            double actual = adder.Add(a, b);

            Assert.AreEqual(expected, actual, "Addition of 5.5 and 4.5 should be 10.0");
        }

        [TestMethod]
        public void TestSubtraction_WithNegativeResult_ShouldReturnCorrectDifference()
        {
            ISubtraction subtractor = new Subtraction();
            double a = 10;
            double b = 20;
            double expected = -10;

            double actual = subtractor.Subtract(a, b);

            Assert.AreEqual(expected, actual, "Subtraction of 10 - 20 should be -10");
        }

        [TestMethod]
        public void TestMultiplication_WithZero_ShouldReturnZero()
        {
            IMultiplication multiplier = new Multiplication();
            double a = 7;
            double b = 0;
            double expected = 0;

            double actual = multiplier.Multiply(a, b);

            Assert.AreEqual(expected, actual, "Multiplication by zero should be zero");
        }


        [TestMethod]
        public void TestDivision_ValidInput_ShouldReturnCorrectQuotient()
        {
            IDivision divider = new Division();
            double a = 20;
            double b = 4;
            double expected = 5;

            double actual = divider.Divide(a, b);

            Assert.AreEqual(expected, actual, "Division of 20 / 4 should be 5");
        }

        [TestMethod]
        public void TestDivision_DivideByZero_ShouldThrowException()
        {
            IDivision divider = new Division();
            Assert.Throws<DivideByZeroException>(() =>
            {
                divider.Divide(10, 0);
            });
        }
    }
}
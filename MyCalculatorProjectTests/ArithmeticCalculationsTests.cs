using NUnit.Framework;
using MyCalculatorProject;
using System;

namespace MyCalculatorProjectTests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add_BothNumbersAreIntegers_ReturnSumOfNumbers()
        {
            var result = ArithmeticCalculations.Add(2, 3);

            Assert.That(result == 5);
        }

        [Test]
        public void Divide_SecondNumberIsZero_ThrowException()
        {
            ArithmeticCalculations calculations = new ArithmeticCalculations();

            Assert.That(() => calculations.Divide(12, 0), Throws.Exception.TypeOf<DivideByZeroException>());
        }

        [Test]
        [TestCase(12, 3, 4)]
        [TestCase(0, 12, 0)]
        public void Divide_InputValues_ReturnDivision(int first, int second, int expected)
        {
            ArithmeticCalculations calculations = new ArithmeticCalculations();

            var results = calculations.Divide(first, second);

            Assert.That(results == expected);
        }
    }
}
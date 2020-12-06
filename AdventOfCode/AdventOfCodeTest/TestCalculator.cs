using NUnit.Framework;
using AdventOfCode;
using System.Collections.Generic;

namespace AdventOfCodeTest
{
    public class TestCalculator
    {
        private Calculator calc;

        [SetUp]
        public void Setup()
        {
            this.calc = new Calculator();
        }

        [Test]
        public void GetTowSummandsTest()
        {
            decimal target = 2020;

            List<decimal> values = new List<decimal>()
            {
                1721,
                979,
                366,
                299,
                675,
                1456
            };

            decimal[] result = calc.GetTwoSummands(values, target);
            Assert.That(1721 == result[0]);
            Assert.That(299 == result[1]);
        }

        [Test]
        public void GetThreeSummandsTest()
        {
            decimal target = 2020;

            List<decimal> values = new List<decimal>()
            {
                1721,
                979,
                366,
                299,
                675,
                1456
            };

            decimal[] result = calc.GetThreeSummands(values, target);
            Assert.That(979 == result[0]);
            Assert.That(366 == result[1]);
            Assert.That(675 == result[2]);
        }
    }
}
using NUnit.Framework;
using AdventOfCode;
using System.Collections.Generic;

namespace AdventOfCodeTest
{
    public class Tests
    {
        private Calculator calc;

        [SetUp]
        public void Setup()
        {
            this.calc = new Calculator();
        }

        [Test]
        public void Test1()
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

            decimal[] result = calc.GetSummands(values, target);
            Assert.That(1721 == result[0]);
            Assert.That(299 == result[1]);
        }
    }
}
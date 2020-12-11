using NUnit.Framework;
using AdventOfCode;
using System.Collections.Generic;
using System;

namespace AdventOfCodeTest
{
    public class TestSeatCalc
    {
        private SeatCalculator sc;

        [SetUp]
        public void SetUp()
        {
            sc = new SeatCalculator();
        }

        [TestCase("FBFBBFFRLR", 357)]
        [TestCase("BFFFBBFRRR", 567)]
        [TestCase("FFFBBBFRRR", 119)]
        [TestCase("BBFFBBFRLL", 820)]
        public void GetSeatTest(string str, int result)
        {
            Assert.AreEqual(result, sc.GetSeatID(str));
        }

        [Test]
        public void GetHighestSeatNrTest()
        {
            List<string> list = new List<string>()
            {
                "FBFBBFFRLR",
                "BFFFBBFRRR",
                "FFFBBBFRRR",
                "BBFFBBFRLL"
            };
            Assert.AreEqual(820, sc.GetHighestSeatNr(list));
        }
    }
}
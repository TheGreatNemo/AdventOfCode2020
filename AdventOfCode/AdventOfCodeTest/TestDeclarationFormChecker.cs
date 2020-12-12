using System;
using NUnit.Framework;
using AdventOfCode;
using System.Collections.Generic;

namespace AdventOfCodeTest
{
    internal class TestDeclarationFormChecker
    {
        private DeclarationFormChecker dfc;

        [SetUp]
        public void SetUp()
        {
            dfc = new DeclarationFormChecker();
        }

        [Test]
        public void CounterTest()
        {
            List<string> list = new List<string>()
            {
                "abc",
                "",
                "a",
                "b",
                "c",
                "",
                "ab",
                "ac",
                "",
                "a",
                "a",
                "a",
                "a",
                "",
                "b"
            };

            Assert.AreEqual(6, dfc.GetMatchingSum(list));
        }

        [Test]
        public void MatchTest()
        {
            List<string> list = new List<string>()
            {
                "abc"
            };

            Assert.AreEqual(3, dfc.GetMatching(list));

            list = new List<string>()
            {
                "abc",
                "abd"
            };

            Assert.AreEqual(2, dfc.GetMatching(list));
        }
    }
}
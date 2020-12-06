using NUnit.Framework;
using AdventOfCode;
using System.Collections.Generic;

namespace AdventOfCodeTest
{
    public class TestPWValidator
    {
        private PWValidator validator;

        [SetUp]
        public void Setup()
        {
            this.validator = new PWValidator();
        }

        [Test]
        public void SimplePWTest()
        {
            Assert.That(validator.IsValid("abcdef", "1-3 a"));
            Assert.That(validator.IsValid("aabcdef", "1-3 a"));
            Assert.That(validator.IsValid("abcadef", "1-3 a"));
            Assert.That(validator.IsValid("abcadefa", "1-3 a"));
            Assert.That(!validator.IsValid("abcadeafa", "1-3 a"));
        }

        [Test]
        public void GetValidCountPWTest()
        {
            List<string> list = new List<string>()
            {
                "1-3 a: abcde",
                "1-3 b: cdefg",
                "2-9 c: ccccccccc",
            };

            Assert.That(validator.GetValidCount(list, 1) == 2);
        }

        [Test]
        public void GetValidCountPWNewRulesTest()
        {
            List<string> list = new List<string>()
            {
                "1-3 a: abcde",
                "1-3 b: cdefg",
                "2-9 c: ccccccccc",
            };

            Assert.That(validator.GetValidCount(list, 2) == 1);
        }
    }
}
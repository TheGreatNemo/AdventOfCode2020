using NUnit.Framework;
using AdventOfCode;
using System.Collections.Generic;

namespace AdventOfCodeTest
{
    public class TestIDValidator
    {
        private IDValidator validator;

        [SetUp]
        public void Setup()
        {
            this.validator = new IDValidator();
        }

        [Test]
        public void IDValidatorTest()
        {
            string values = "ecl:gry pid:860033327 eyr:2020 hcl:#fffffd byr:1937 iyr:2017 cid:147 hgt:183cm ";
            Assert.That(this.validator.IsValid(values));
            values = "ecl:gry pid:860033327 eyr:2020 hcl:#fffffd byr:1937 iyr:2017 hgt:183cm ";
            Assert.That(this.validator.IsValid(values));
            values = "ecl:gry pid:860033327 eyr:2020 hcl:#fffffd byr:1937 iyr:2017 cid:147 ";
            Assert.That(!this.validator.IsValid(values));

        }

        [Test]
        public void GetConcatStringListTest()
        {
            List<string> lines = new List<string>()
            {
                "ecl:gry pid:860033327 eyr:2020 hcl:#fffffd",
                "byr:1937 iyr:2017 cid:147 hgt:183cm",
                "",
                "iyr:2013 ecl:amb cid:350 eyr:2023 pid:028048884",
                "hcl:#cfa07d byr:1929"                
            };
            List<string> result = new List<string>()
            {
                "ecl:gry pid:860033327 eyr:2020 hcl:#fffffd byr:1937 iyr:2017 cid:147 hgt:183cm ",
                "iyr:2013 ecl:amb cid:350 eyr:2023 pid:028048884 hcl:#cfa07d byr:1929 "
            };

            Assert.AreEqual(result, this.validator.GetConcatStringList(lines));
        }

        [Test]
        public void GetValidIDTest()
        {
            List<string> lines = new List<string>()
            {
                "ecl:gry pid:860033327 eyr:2020 hcl:#fffffd",
                "byr:1937 iyr:2017 cid:147 hgt:183cm",
                "",
                "iyr:2013 ecl:amb cid:350 eyr:2023 pid:028048884",
                "hcl:#cfa07d byr:1929",
                "",
                "hcl:#ae17e1 iyr:2013",
                "eyr:2024",
                "ecl:brn pid:760753108 byr:1931",
                "hgt:179cm",
                "",
                "hcl:#cfa07d eyr:2025 pid:166559648",
                "iyr:2011 ecl:brn hgt:59in"
            };

            Assert.AreEqual(2, validator.GetNrOfValidIds(lines));
        }
    }
}
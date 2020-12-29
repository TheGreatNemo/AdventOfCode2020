using NUnit.Framework;
using AdventOfCode;
using System.Collections.Generic;

namespace AdventOfCodeTest
{
    internal class TestBagMixer
    {
        private BagMixer bg;

        [SetUp]
        public void Setup()
        {
            bg = new BagMixer();
        }

        [Test]
        public void TestGetInceptionLevel()
        {
            List<string> list = new List<string>()
            {
                "light red bags contain 1 bright white bag, 2 muted yellow bags.",
                "dark orange bags contain 3 bright white bags, 4 muted yellow bags.",
                "bright white bags contain 1 shiny gold bag.",
                "muted yellow bags contain 2 shiny gold bags, 9 faded blue bags.",
                "shiny gold bags contain 1 dark olive bag, 2 vibrant plum bags.",
                "dark olive bags contain 3 faded blue bags, 4 dotted black bags.",
                "vibrant plum bags contain 5 faded blue bags, 6 dotted black bags.",
                "faded blue bags contain no other bags.",
                "dotted black bags contain no other bags."
            };

            Assert.AreEqual(4, bg.GetNrBagsContaining("shiny gold", list));
        }

        [Test]
        public void TestGetComponents()
        {
            string line = "light red bags contain 1 bright white bag, 2 muted yellow bags.";
            KeyValuePair<string, int> bag = new KeyValuePair<string, int>("light red", 1);
            Dictionary<string, int> contains = new Dictionary<string, int>()
            {
                {"bright white", 1 },
                {"muted yellow", 2 },
            };
            KeyValuePair<string, int> rbag = bg.GetBag(line);
            Assert.AreEqual(bag, rbag);
            Assert.AreEqual(contains, bg.GetContatiningBags(line));
        }

        [Test]
        public void TestGetLine()
        {
            List<string> list = new List<string>()
            {
                "light red bags contain 1 bright white bag, 2 muted yellow bags.",
                "dark orange bags contain 3 bright white bags, 4 muted yellow bags.",
                "bright white bags contain 1 shiny gold bag.",
                "muted yellow bags contain 2 shiny gold bags, 9 faded blue bags.",
                "shiny gold bags contain 1 dark olive bag, 2 vibrant plum bags.",
                "dark olive bags contain 3 faded blue bags, 4 dotted black bags.",
                "vibrant plum bags contain 5 faded blue bags, 6 dotted black bags.",
                "faded blue bags contain no other bags.",
                "dotted black bags contain no other bags."
            };

            Assert.AreEqual("shiny gold bags contain 1 dark olive bag, 2 vibrant plum bags.", bg.GetLine(list, "shiny gold"));
        }

        private static object[] Lists =
        {
            new object[] {
        new List<string>()
            {
                "light red bags contain 1 bright white bag, 2 muted yellow bags.",
                "dark orange bags contain 3 bright white bags, 4 muted yellow bags.",
                "bright white bags contain 1 shiny gold bag.",
                "muted yellow bags contain 2 shiny gold bags, 9 faded blue bags.",
                "shiny gold bags contain 1 dark olive bag, 2 vibrant plum bags.",
                "dark olive bags contain 3 faded blue bags, 4 dotted black bags.",
                "vibrant plum bags contain 5 faded blue bags, 6 dotted black bags.",
                "faded blue bags contain no other bags.",
                "dotted black bags contain no other bags."
            }, 32},
            new object[]{
            new List<string>()
            {
                "shiny gold bags contain 2 dark red bags.",
                "dark red bags contain 2 dark orange bags.",
                "dark orange bags contain 2 dark yellow bags.",
                "dark yellow bags contain 2 dark green bags.",
                "dark green bags contain 2 dark blue bags.",
                "dark blue bags contain 2 dark violet bags.",
                "dark violet bags contain no other bags."
            }, 126} };

        [Test, TestCaseSource(nameof(Lists))]
        public void TestGetRecursice(List<string> list, int expected)
        {
            Assert.AreEqual(expected, bg.RecursiveCount("shiny gold", list));
        }
    }
}
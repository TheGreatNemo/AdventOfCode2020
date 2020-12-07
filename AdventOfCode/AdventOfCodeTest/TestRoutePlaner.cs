using NUnit.Framework;
using AdventOfCode;
using System.Collections.Generic;

namespace AdventOfCodeTest
{
    public class TestRoutePlaner
    {
        private RoutePlaner rp;

        [SetUp]
        public void Setup()
        {
            this.rp = new RoutePlaner();
        }

        [TestCase(1, 1, 2)]
        [TestCase(3, 1, 7)]
        [TestCase(5, 1, 3)]
        [TestCase(7, 1, 4)]
        [TestCase(1, 2, 2)]
        public void RouteplanerTest(int right, int down, int result)
        {
            List<string> map = new List<string>()
            {
                "..##.......",
                "#...#...#..",
                ".#....#..#.",
                "..#.#...#.#",
                ".#...##..#.",
                "..#.##.....",
                ".#.#.#....#",
                ".#........#",
                "#.##...#...",
                "#...##....#",
                ".#..#...#.#"
            };
            int obsticales = rp.GetNumbersOfObsticales(map, right, down);
            Assert.That(result == obsticales);
        }
    }
}
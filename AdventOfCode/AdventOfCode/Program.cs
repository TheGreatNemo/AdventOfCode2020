using System;
using System.Collections.Generic;

namespace AdventOfCode
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            FileReader fr = new FileReader();
            Calculator calc = new Calculator();

            List<decimal> values = fr.ReadDecFromListFile(@".\resources\sample1.txt");

            decimal[] summands = calc.GetTwoSummands(values, 2020);
            Console.WriteLine($"The Values {summands[0]} and {summands[1]} result in {summands[0] * summands[1]}");

            summands = calc.GetThreeSummands(values, 2020);
            Console.WriteLine($"The Values {summands[0]} and {summands[1]} and {summands[2]} result in {summands[0] * summands[1] * summands[2]}");
        }
    }
}
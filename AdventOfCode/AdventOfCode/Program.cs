using System;
using System.Collections.Generic;

namespace AdventOfCode
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dec1();
            Dec2();
            Dec3();
        }

        private static void Dec1()
        {
            FileReader fr = new FileReader();
            Calculator calc = new Calculator();

            List<decimal> values = fr.ReadDecFromListFile(@".\resources\sample1.txt");

            decimal[] summands = calc.GetTwoSummands(values, 2020);
            Console.WriteLine($"The Values {summands[0]} and {summands[1]} result in {summands[0] * summands[1]}");

            summands = calc.GetThreeSummands(values, 2020);
            Console.WriteLine($"The Values {summands[0]} and {summands[1]} and {summands[2]} result in {summands[0] * summands[1] * summands[2]}");
        }

        private static void Dec2()
        {
            FileReader fr = new FileReader();
            PWValidator pwv = new PWValidator();

            List<string> values = fr.ReadLinesFromFile(@".\resources\sample2.txt");
            int validPws = pwv.GetValidCount(values, 1);
            Console.WriteLine($"The list contains {validPws} valid passwords.");

            validPws = pwv.GetValidCount(values, 2);
            Console.WriteLine($"The list contains {validPws} valid passwords, with the new rules.");
        }

        private static void Dec3()
        {
            FileReader fr = new FileReader();
            RoutePlaner rp = new RoutePlaner();

            List<string> values = fr.ReadLinesFromFile(@".\resources\sample3.txt");
            int trees = rp.GetNumbersOfObsticales(values, 3, 1);

            Console.WriteLine($"The route will hit {trees} trees.");

            long r1 = rp.GetNumbersOfObsticales(values, 1, 1);
            long r2 = rp.GetNumbersOfObsticales(values, 3, 1);
            long r3 = rp.GetNumbersOfObsticales(values, 4, 1);
            long r4 = rp.GetNumbersOfObsticales(values, 7, 1);
            long r5 = rp.GetNumbersOfObsticales(values, 1, 2);

            Console.WriteLine($"The 1. sleed will hit: {r1} trees.");
            Console.WriteLine($"The 2. sleed will hit: {r2} trees.");
            Console.WriteLine($"The 3. sleed will hit: {r3} trees.");
            Console.WriteLine($"The 4. sleed will hit: {r4} trees.");
            Console.WriteLine($"The 5. sleed will hit: {r5} trees.");

            Console.WriteLine($"The result of multiplying is : {r1 * r2 * r3 * r4 * r5}.");
        }
    }
}
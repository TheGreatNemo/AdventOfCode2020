using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class FileReader
    {
        internal List<string[]> ReadFromCSV(string path)
        {
            List<string[]> contence = new List<string[]>();
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.Peek() >= 0)
                    {
                        string line = sr.ReadLine();
                        string[] sa = line.Split(',');
                        foreach (string s in sa)
                        {
                            s.Trim();
                        }
                        contence.Add(sa);
                    }
                }
            }
            return contence;
        }

        internal List<decimal> ReadDecFromListFile(string path)
        {
            List<decimal> contence = new List<decimal>();
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.Peek() >= 0)
                    {
                        string line = sr.ReadLine();
                        decimal v = Decimal.Parse(line.Trim());
                        contence.Add(v);
                    }
                }
            }
            return contence;
        }
    }
}
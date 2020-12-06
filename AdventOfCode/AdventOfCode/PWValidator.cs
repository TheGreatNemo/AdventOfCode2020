using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class PWValidator
    {
        public int GetValidCount(List<string> list, int ruleset)
        {
            // ruleset 1 = old ruleset
            // ruleset 2 = new ruleset

            int i = 0;
            foreach (string l in list)
            {
                string[] line = l.Split(":");
                if (ruleset == 1)
                {
                    if (IsValid(line[1].Trim(), line[0].Trim()))
                    {
                        i++;
                    }
                }
                else if (ruleset == 2)
                {
                    if (IsValidNewRules(line[1].Trim(), line[0].Trim()))
                    {
                        i++;
                    }
                }
            }
            return i;
        }

        public bool IsValidNewRules(string pw, string policy)
        {
            string[] pol = policy.Split(' ');
            int first = int.Parse(pol[0].Split('-')[0].Trim());
            int sec = int.Parse(pol[0].Split('-')[1].Trim());
            int o = OccursAt(pw, first, sec, Char.Parse(pol[1]));

            return o == 1;
        }

        public bool IsValid(string pw, string policy)
        {
            string[] pol = policy.Split(' ');
            int minO = int.Parse(pol[0].Split('-')[0].Trim());
            int maxO = int.Parse(pol[0].Split('-')[1].Trim());

            int o = Occurences(pw, Char.Parse(pol[1]));

            return minO <= o && maxO >= o;
        }

        private int Occurences(string str, char c)
        {
            int o = 0;
            foreach (char l in str)
            {
                if (c == l)
                {
                    o++;
                }
            }
            return o;
        }

        private int OccursAt(string str, int pos1, int pos2, char c)
        {
            int o = 0;
            if (str[pos1 - 1] == c)
            {
                o++;
            }
            if (str[pos2 - 1] == c)
            {
                o++;
            }
            return o;
        }
    }
}
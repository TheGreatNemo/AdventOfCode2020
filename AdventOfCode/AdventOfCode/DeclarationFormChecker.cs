using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class DeclarationFormChecker
    {
        public int GetMatchingSum(List<string> list)
        {
            List<int> results = new List<int>();

            List<List<string>> groups = new List<List<string>>();
            List<string> g = new List<string>();
            foreach (string s in list)
            {
                if (s == "")
                {
                    groups.Add(g);
                    g = new List<string>();
                }
                else
                {
                    g.Add(s);
                }
            }
            groups.Add(g);

            foreach (List<string> group in groups)
            {
                results.Add(GetMatching(group));
            }
            return results.Sum();
        }

        public int GetMatching(List<string> group)
        {
            List<char> q = new List<char>();
            foreach (string p in group)
            {
                string a = p;
                while (a.Length > 0)
                {
                    if (ByEveryone(a.First(), group) && !q.Contains(a.First()))
                    {
                        q.Add(a.First());
                    }
                    a = a.Remove(0, 1);
                }
            }
            return q.Count;
        }

        private bool ByEveryone(char c, List<String> group)
        {
            bool result = true;
            foreach (string s in group)
            {
                if (!s.Contains(c))
                {
                    result = false;
                }
            }
            return result;
        }
    }
}
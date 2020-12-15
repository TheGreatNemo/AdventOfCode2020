using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class BagMixer
    {
        public int GetInceptionLevel(List<string> list)
        {
            return 0;
        }

        public int GetNrBagsContaining(string b, List<string> list)
        {
            int count = 0;
            List<string> counted = new List<string>()
            {
                b
            };
            List<string> mem = new List<string>()
            {
                b
            };

            while (mem.Count > 0)
            {
                foreach (string line in list)
                {
                    KeyValuePair<string, int> bag = GetBag(line);

                    Dictionary<string, int> c = GetContatiningBags(line);

                    if (ContainsBag(c, mem.First()) && !counted.Contains(bag.Key))
                    {
                        count++;
                        mem.Add(bag.Key);
                        counted.Add(bag.Key);
                    }
                }
                mem.Remove(mem.First());
            }
            return count;
        }

        public Dictionary<string, int> GetContatiningBags(string line)
        {
            Dictionary<string, int> c = new Dictionary<string, int>();
            string[] parts = line.Split("contain");
            if (parts[1].Trim() == "no other bags.")
            {
                return c;
            }
            string[] bags = parts[1].Split(',');
            foreach (string bag in bags)
            {
                string[] words = bag.Trim().Split(' ');
                c.Add($"{words[1]} {words[2]}", int.Parse(words[0]));
            }
            return c;
        }

        public KeyValuePair<string, int> GetBag(string line)
        {
            string[] parts = line.Split("contain");
            return new KeyValuePair<string, int>(parts[0].Split(" bag")[0], 1);
        }

        public bool ContainsBag(Dictionary<string, int> bag, string target)
        {
            foreach (KeyValuePair<string, int> pair in bag)
            {
                if (pair.Key == target)
                {
                    return true;
                }
            }

            return false; ;
        }
    }
}
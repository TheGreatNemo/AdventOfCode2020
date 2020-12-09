using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class IDValidator
    {
        public bool IsValid(string str)
        {
            string[] pairs = str.Split(' ');
            // last array is "" because of whitespace to separate lines
            if(pairs.Length == 9)
            {
                return true;
            }
            if (pairs.Length == 8 && ! str.Contains("cid:"))
            {
                return true;
            }
            return false;
        }

        public List<string> GetConcatStringList(List<string> original)
        {
            List<string> list = new List<string>();
            string str = string.Empty;

            for (int i = 0; i < original.Count; i++)
            {
                if(original[i] != "") 
                { 
                    str += $"{original[i]} ";
                }
                else
                {
                    list.Add(str);
                    str = string.Empty;
                }
            }
            list.Add(str);

            return list;
        }

        public int GetNrOfValidIds(List<string> list)
        {
            List<string> ids = GetConcatStringList(list);
            int valid = 0;
            foreach(string id in ids)
            {
                valid = IsValid(id) ? valid + 1 : valid + 0;
            }
            return valid;
        }
    }
}
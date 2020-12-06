using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class Calculator
    {
        public decimal[] GetSummands(List<decimal> list, decimal target)
        {
            decimal[] summands = new decimal[2];
            for (int i = 0; i < list.Count; i++)
            {
                decimal r = target - list[i];
                if (list.Contains(r))
                {
                    summands[0] = list[i];
                    summands[1] = r;
                    break;
                }
            }

            return summands;
        }
    }
}
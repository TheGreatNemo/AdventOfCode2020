using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class Calculator
    {
        public decimal[] GetTwoSummands(List<decimal> list, decimal target)
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

        public decimal[] GetThreeSummands(List<decimal> list, decimal target)
        {
            decimal[] summands = new decimal[3];
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    for (int k = j + 1; k < list.Count; k++)
                    {
                        decimal r = list[i] + list[j] + list[k];
                        if (target == r)
                        {
                            summands[0] = list[i];
                            summands[1] = list[j];
                            summands[2] = list[k];
                            break;
                        }
                    }
                }
            }

            return summands;
        }
    }
}
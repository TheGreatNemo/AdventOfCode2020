using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class RoutePlaner
    {
        public int GetNumbersOfObsticales(List<string> map, int right, int down)
        {
            int trees = 0;
            int row = 0;
            for (int i = 0; row < map.Count - 1;)
            {
                i = (i + right) % map[0].Length;
                row = row + down;
                if (map[row][i] == '#')
                {
                    trees++;
                }
            }
            return trees;
        }
    }
}
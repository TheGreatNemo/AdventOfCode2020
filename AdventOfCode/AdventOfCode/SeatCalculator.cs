using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class SeatCalculator
    {
        private int rows;
        private int seat;

        public SeatCalculator()
        {
            rows = 127;
            seat = 8;
        }

        public int GetHighestSeatNr(List<string> list)
        {
            int highestID = 0;
            foreach (string s in list)
            {
                int id = GetSeatID(s);
                highestID = id > highestID ? id : highestID;
            }
            return highestID;
        }

        public int GetSeatID(string str)
        {
            double sstart = 0;
            double send = 7;
            double rstart = 0;
            double rend = 127;
            for (int i = 0; i < 10; i++)
            {
                char c = str.First();
                str = str.Remove(0, 1);
                double t = rend - rstart;
                double s = send - sstart;
                if (c == 'F')
                {
                    rend = rend - Math.Ceiling(t / 2);
                }
                else if (c == 'B')
                {
                    rstart = rstart + Math.Ceiling(t / 2);
                }
                else if (c == 'L')
                {
                    send = send - Math.Ceiling(s / 2);
                }
                else if (c == 'R')
                {
                    sstart = sstart + Math.Ceiling(s / 2);
                }
            }

            return Convert.ToInt32(rstart * 8 + sstart);
        }
    }
}
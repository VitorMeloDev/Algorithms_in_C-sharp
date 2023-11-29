using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Book_Exercises
{
    class Chapter4Exercises
    {
        public static int Sum(int[] list)
        {
            if (list.Length == 0) return 0;

            return list[0] + Sum(list[1..]);
        }

        public static int TotalItens(int[] list)
        {
            if(list.Length == 0) { return 0; }

            return 1 + TotalItens(list[1..]);
        }

        public static int HighestValue(int[] list)
        {
            int high = list[0];

            for(int x = 1; x < list.Length; x++)
            {
                if (high < list[x])
                {
                    high = list[x];
                }
            }

            return high;
        }
    }
}

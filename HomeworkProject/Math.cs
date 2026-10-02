using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkProject
{
    internal class Math
    {
        internal int Max(int[] Numbers)
        {
            int MaxNum = Numbers[0];
            foreach (int Number in Numbers)
            {
                if (MaxNum < Number)
                {
                    MaxNum = Number;
                }
            }
            return MaxNum;
        }

        internal int Min(int[] Numbers)
        {
            int MinNum = Numbers[0];
            foreach (int Number in Numbers)
            {
                if (MinNum > Number)
                {
                    MinNum = Number;
                }
            }
            return MinNum;
        }
    }
}

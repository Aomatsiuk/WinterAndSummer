using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterAndSummer
{
    public class Solution
    {
        public int WinterAndSummer(int[] t)
        {
            var maxTempInWinter = t[0];
            int winterLength = 0;
            foreach(int temp in t)
            {
                if(temp <= maxTempInWinter)
                {
                    maxTempInWinter = Math.Max(temp, maxTempInWinter);
                    winterLength++;
                }
            }
            return winterLength;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryGapFirst
{
    public class Solution
    {
        public int solution(int N)
        {
            int quotient = N;
            int remainder = 0;
            int cnt = 0;
            int longestBinaryGap = 0;
            bool hasOneEncountered = false;

            while (quotient >= 1)
            {
                remainder = quotient % 2;
                quotient = quotient / 2;
                
                if (remainder == 1)
                {
                    hasOneEncountered = true;
                    if (cnt > longestBinaryGap)
                    {
                        longestBinaryGap = cnt;
                    }
                    cnt = 0;
                    continue;
                }
                else
                {
                    if (hasOneEncountered)
                        cnt++;
                }
            }

            return longestBinaryGap;
        }
    }

}

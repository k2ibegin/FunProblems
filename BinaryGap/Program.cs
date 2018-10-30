using System;

namespace BinaryGap
{
   public class Solution
    {
        public int solution(int N)
        {
            double quotient = N;
            int remainder = 0;
            int cnt = 0;
            bool isOneWitnessed = false;
            int longestBinaryGap = 0;

            while (quotient >= 1)
            {
                quotient = quotient / 2;
                remainder = remainder % 2;
                if (remainder == 1)
                {
                    isOneWitnessed = true;
                    if (cnt > longestBinaryGap)
                        longestBinaryGap = cnt;
                    continue;
                }else
                {
                    if (isOneWitnessed)
                    {
                        cnt++;
                        isOneWitnessed = false;
                    }
                }
            }

            return longestBinaryGap;
        }
    }

}

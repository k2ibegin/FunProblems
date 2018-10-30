using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapeEquilibirium
{
    public class TapeClass
    {
        public int solution(int[] A)
        {
            int n = A.Length;
            SortedDictionary<int, bool> B = new SortedDictionary<int,bool>();

            for (int i=1;i<=n-2;i++)
            {
                int sum1 = 0; int sum2 = 0;
                for (int j=0;j<i;j++)
                {
                    sum1 += A[j];
                }

                for (int k = i; k < n; k++)
                {
                    sum2 += A[k];
                }

                B[Math.Abs(sum1 - sum2)] = true;
            }

            int idx = 0;
            
            foreach(KeyValuePair<int,bool> kvp in B)
            {
                idx = kvp.Key;
                break;

            }

            return idx;
        }
    }
}

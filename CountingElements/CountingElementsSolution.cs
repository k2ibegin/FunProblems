using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingElements
{
    public class CountingElementsSolution
    {
        public int[] Solution(int N, int[] A)
        {
            int [] B = new int[N];
            int maxElement = 0;
            int arrLength = A.Length;
            for (int i = 0; i < arrLength; i++)
            {
                if (A[i] >= 0 && A[i] <= N)
                {
                    int idx = A[i];
                    idx = idx - 1;
                    B[idx] += 1;
                    if(B[idx] > maxElement )
                    {
                        maxElement = B[idx];
                    }
                }
                else if( A[i] > N)
                {
                    for (int j = 0;j<N;j++)
                    {
                        B[j] = maxElement;
                    }
                }
            }
            return B;
        }


    }
}

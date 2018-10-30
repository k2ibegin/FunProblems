using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * FrogRiverOne problem
 * Main problem came is that last trick i forgot, just the last number that gets upodated
 * inside the B array would be the actual returned value, whcihever gets updated last 
 * I was thinking to return some values that makes no sense, rather it was pretty easy
 * approach was fine overall for the program, pseudo code worked fine too
 * just last piece of returning value took some time.
 * 
 * TODO: 
 * Please try to run test sample on your pseudo code quicker, so that you havemore time left
 * for debugging the code or change algo if needed
 * 
 * **/
namespace CodilityProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(5, new int[] {
                1,3,1,4,2,3,5,4
            }));
        }

        public static int solution(int X, int[] A)
        {
            int[] B = new int[X];
            for (int i = 0; i < X; i++)
            {
                B[i] = 100001;
            }

            int lastEntry = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (i < B[A[i] - 1])
                {
                    B[A[i] - 1] = i;
                    lastEntry = i;
                }
            }

            for (int i = 0; i < B.Length; i++)
            {
                if (B[i] == 100001)
                    return -1;
            }

            return lastEntry;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumberFind
{
    public class FindOddNumber
    {
        public int FindOddNumberMethod(int []A)
        {
            Dictionary<int, bool> kvp = new Dictionary<int, bool>();
            for (int i=0;i<A.Length;i++)
            {
                if (kvp.ContainsKey(A[i]))
                {
                    kvp.Remove(A[i]);
                }
                else
                {
                    kvp[A[i]] = true;
                }
            }

            int oddNumber= 0;

            foreach (KeyValuePair<int, bool> k in kvp)
            {
                oddNumber = k.Key;
            }

            return oddNumber;
        }
    }
}

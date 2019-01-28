using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class LinearSearch
    {
        public static int search(int[] inputArray, int elementToSearch)
        {
            int i;
            for (i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == elementToSearch)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

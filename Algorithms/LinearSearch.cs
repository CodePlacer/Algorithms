using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class LinearSearch
    {
        public static string search(int[] inputArray, int elementToSearch)
        {
            List<string> output = new List<string>();
            for (int j = 0; j < inputArray.Length - 1; j++)
            {
                if (inputArray[j] > elementToSearch)
                {
                    output.Add(inputArray[j].ToString());
                }
            }
            return string.Join(",", output);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class BinarySearch
    {
        static List<int> output = new List<int>();
        public static string binarySearch(int[] inputArray, int index, int arrayElementCount, int elementToSearch)
        {
            if (arrayElementCount >= index)
            {
                int mid = index + (arrayElementCount - index) / 2;

                //Checking the array index value with input
                if (inputArray[mid] == elementToSearch)
                {
                    output.AddRange(inputArray.Skip(mid + 1));
                    return string.Join(",", output);
                }

                // If element is smaller than mid, then 
                // it can only be present in left subarray 
                if (inputArray[mid] > elementToSearch)
                    return binarySearch(inputArray, index, mid - 1, elementToSearch);

                // Else the element can only be present 
                // in right subarray 
                return binarySearch(inputArray, mid + 1, arrayElementCount, elementToSearch);
            }

            // if we reach here, then element was 
            // not present 
            return string.Join(",", output);
        }
    }
}

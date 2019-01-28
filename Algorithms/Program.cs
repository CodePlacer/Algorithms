using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINEAR SEARCH
            int[] arr = { 1, 10, 30, 15 };
            int x = 30;
            Console.WriteLine("Linear Search Algorithm : " + x + " is present at index " + LinearSearch.search(arr, x));
            Console.Read();
        }
    }
}

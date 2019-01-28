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
            int[] arr = { 1, 10, 30, 15, 23, 44, 62, 1, 4, 8, 6, -6 };
            int x = 30;
            Console.WriteLine("Given Number : " + x );
            Console.WriteLine("Linear Search Algorithm Result : " + LinearSearch.search(arr, x) + " is/are greater than " + x);
            Console.Read();
        }
    }
}

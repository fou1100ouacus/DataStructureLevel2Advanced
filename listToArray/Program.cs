using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listToArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ListNums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arrayNums = ListNums.ToArray();
            Console.WriteLine(string.Join(",", arrayNums));
            Console.ReadKey();
        }
    }
}

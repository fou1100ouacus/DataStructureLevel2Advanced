using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // using built in fun in list
            List<int> list = new List<int>() {43,54,6,2,6,234,64,32 };
         //   list.Sort();
            Console.WriteLine(string.Join(",",list));
        //    list.Reverse();
            Console.WriteLine(string.Join(",", list));

            //   using linq
          //  list.OrderBy(x => x);
            Console.WriteLine(string.Join(",", list));
            list.OrderByDescending(x => x);
            Console.WriteLine(string.Join(",", list));

            // Using custom sorting logic
            list.Sort((a,b)=>Math.Abs(a).CompareTo(b));


        }
    }
}

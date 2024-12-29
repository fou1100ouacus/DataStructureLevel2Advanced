using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, int> sortedList = new SortedList<string, int>();
            sortedList.Add("Banana", 2);
            sortedList.Add("Orange", 3);
            sortedList.Add("Apple", 3);
            Console.WriteLine($"the quantity of Apples: {sortedList["Apple"]}");
            Console.WriteLine("=============================");
            foreach (KeyValuePair<string, int> Item in sortedList)
            {
                Console.WriteLine($"the key is :{Item.Key} ,the value is: {Item.Value} ");
            }
            sortedList.Remove("Apple");
            Console.WriteLine("=============================");
            foreach (KeyValuePair<string, int> Item in sortedList)
            {
                Console.WriteLine($"the key is :{Item.Key} ,the value is: {Item.Value} ");
            }
            Console.ReadKey();

            ///////////////////////////////
            ///

            SortedList<int, string> sortedList2 = new SortedList<int, string>() {
                  {1,"One" },{2,"Two" },{3,"Three" },{4,"Four" } };
                       
            var QueryExpressionSyntax = from kpv in sortedList2
                                        where kpv.Key > 1
                                        select kpv;
            foreach (KeyValuePair<int, string> kpv in QueryExpressionSyntax)
            {
                Console.WriteLine($"the key is: {kpv.Key} the value is: {kpv.Value}");
            }
            Console.WriteLine("========================");
            var MethodSytnax = sortedList2.Where(kpv => kpv.Key > 1);
            foreach (KeyValuePair<int, string> kpv in MethodSytnax)
            {
                Console.WriteLine($"the key is: {kpv.Key} the value is: {kpv.Value}");
            }
            Console.WriteLine("========================");
            int SpecificValue = 2;
            var Filter = sortedList2.Where(kpv => kpv.Key > SpecificValue);
            foreach (KeyValuePair<int, string> kpv in Filter)
            {
                Console.WriteLine($"the key is: {kpv.Key} the value is: {kpv.Value}");
            }
            Console.ReadKey();




        }
    }
}

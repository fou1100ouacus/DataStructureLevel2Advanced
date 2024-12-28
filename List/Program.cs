using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace List
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(0);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Insert(5, 899);

            // -------------------  Filtering Data With Linq ----------------
            //Console.WriteLine(string.Join(" - ", list.Where(n => n % 2 == 0)));
            //Console.WriteLine(string.Join(" - ", list.Where((n, index) => index % 2 == 1)    ));
            //Console.WriteLine(string.Join(" - ", list.Where(n => (n > 3) && (n < 100))));
            // -------------------   Sorting Techniques in C#  ----------------
       
            List<int> numbers = new List<int> { 44, 22, 55, 666, 9, -6, 345, 11, 3, 3 };

            //1.Default Sorting(Ascending Order)
          
            numbers.Sort();
            Console.WriteLine("Sorted in Ascending Order: " + string.Join(", ", numbers));

            // 2.Descending Order Sorting
            numbers.Sort();
            numbers.Reverse();
            Console.WriteLine("Sorted in Descending Order: " + string.Join(", ", numbers));

            // 3.Sorting Using LINQ (order by)
            numbers.Reverse();

            var sortedAscending = numbers.OrderBy(n => n);
            Console.WriteLine("Sorted Ascending with LINQ: " + string.Join(", ", sortedAscending));

            // 4.Custom Sorting Logic
            numbers.Reverse();

            numbers.Sort((a, b) => Math.Abs(a).CompareTo(Math.Abs(b)));
            Console.WriteLine("Sorted by Absolute Values: " + string.Join(", ", numbers));


            // -------------------  Contains, Exists, Find, FindAll, and Any
            List<int> Numbers = new List<int> {44,22,55,666,9,-6,345,11,3,3 };
            Console.WriteLine("Contain 9:"+string.Join(", ",Numbers.Contains(9)));
            Console.WriteLine("Contain negative number: "+string.Join(", ",Numbers.Exists(n=>n<0)));
            Console.WriteLine("find first negative number:" +string.Join(",", Numbers.Find(n => n < 0)));
            Console.WriteLine("find all negative number: "+string.Join(", ",Numbers.FindAll(n=>n<0)));
            Console.WriteLine("any number >100: "+string.Join(", ",Numbers.Any(n => n >100)));


            // ------------------- List of Custom Objects     ----------------
            // -------------------  Filtering Data With Linq ----------------
            // -------------------  Filtering Data With Linq ----------------
            // -------------------  Filtering Data With Linq ----------------


        }
    }
}
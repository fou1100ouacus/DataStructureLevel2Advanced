using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet_with_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HashSet<int> numbers = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("Even Numbers:");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }
            var nums = numbers.Where(n => n > 5);
            Console.WriteLine("\nNumbers Greater Than 5:");
            foreach (var number in nums)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }
    }
}

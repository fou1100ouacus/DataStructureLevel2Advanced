using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> fruits = new HashSet<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Cherry");
            fruits.Add("Apple");
            fruits.Add("Apple");
            fruits.Add("Apple");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            Console.ReadKey();

            int[] array = { 1, 1, 2, 2, 3, 3, 4, 4, 5 };
            HashSet<int> UniqueNumbers = new HashSet<int>(array);
            foreach (int i in UniqueNumbers)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

        }
    }
}

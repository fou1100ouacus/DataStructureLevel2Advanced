using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilizing_LINQ_with_Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, int> Fruits = new Dictionary<string, int>
            { {"Apple",5 },{"Banana",2 },{"Orange",7 }};

            var FruitInfo = Fruits.Select(fruit => new {fruit.Key,fruit.Value });
            foreach (var item in FruitInfo)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            var filteredFruit =
            Fruits.Where(n => n.Value > 3);
            Console.WriteLine("==================Filter=========================");
foreach (var item in filteredFruit)
{
 Console.WriteLine(item.Key + " " + item.Value);
}
            var sortedDictionary = Fruits.OrderBy(kpv =>
kpv.Value);
            Console.WriteLine("==================Sort=========================");
foreach (var item in sortedDictionary)
{
 Console.WriteLine(item.Key + " " + item.Value);
}


            var sortedDictionaryDESC =
            Fruits.OrderByDescending(kpv => kpv.Value);
            Console.WriteLine("==================SortdDESC=========================");
foreach (var item in sortedDictionaryDESC)
{
 Console.WriteLine(item.Key + " " + item.Value);
}
Console.WriteLine($"==========The Sum Is : {Fruits.Sum(k => k.Value)} ============");



        }
    }
}

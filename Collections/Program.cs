using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
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
         //   list.InsertRange(2, new List<int> { 534,454});
          //  list.Remove(2);//value
         //   list.RemoveAt(1);//index
         //list.RemoveAll(n=>n%2==0);
         //   for (int i = 0; i < list.Count; i++)
         //   {
         //       Console.Write(list[i]);
         //       Console.Write(" - ");
         //   }
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            list.ForEach(n => Console.WriteLine(n));
            // method take pararmeter of action type == delegate refarir to method

            Console.WriteLine("Count ===> " +list.Count);

            Console.WriteLine(list.Sum());
            Console.WriteLine(list.Average());
            Console.WriteLine(list.Max());
            Console.WriteLine(list.Min());
            Console.WriteLine(list.Sum());
            Console.WriteLine("------------------");

            Console.WriteLine(string.Join (" - ",list.Where(n=>n%2==0)));
            Console.WriteLine(string.Join(" - ", list.Where(  (n,index) => index%2==1)
                ));
            Console.WriteLine(string.Join(" - ", list.Where(n => (n>3)&&( n< 100))));


        }
    }
}

using System;
using System.Collections;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace kk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   heterogenous data structure 
            //non generic Collection
            //            Memory Management: Although ArrayList does not automatically decrease its
            //    capacity when elements are removed, you can use the TrimToSize() method to
            //reduce the capacity to match the number of elements stored in the list.

            ArrayList arrayList = new ArrayList();
            arrayList.Add(10);
            arrayList.Add(20);
            arrayList.Add(30);
            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("==================================");
            arrayList.Remove(20);
            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("==================================");
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add("Hello");
            list.Add(true);
            Console.WriteLine($"Number of elements: {list.Count}");
            Console.WriteLine("==================================");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();


        }
    }
}

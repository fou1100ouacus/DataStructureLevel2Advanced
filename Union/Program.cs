using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Union
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 4, 5, 6 };
            set1.UnionWith(set2);
            foreach (int i in set1) { Console.WriteLine(i); }
            Console.ReadKey();
            //HashSet<int> set1 = new HashSet<int> { 1, 4, 3 };
            //HashSet<int> set2 = new HashSet<int> { 4, 5, 6 };
            //set1.IntersectWith(set2);
            //foreach (int i in set1) { Console.WriteLine(i); }
            //Console.ReadKey();

            HashSet<int> set11 = new HashSet<int> { 1, 4, 3 };
            HashSet<int> set12 = new HashSet<int> { 4, 5, 6 };
            set11.ExceptWith(set12);
            foreach (int i in set11) { Console.WriteLine(i); }//
            Console.ReadKey();
        
            
            HashSet<int> set1q = new HashSet<int> { 1, 4, 3 };
            HashSet<int> set2q = new HashSet<int> { 4, 5, 6 };
            set1q.SymmetricExceptWith(set2q);
            foreach (int i in set1q)
            { Console.WriteLine(i); }
            Console.ReadKey();


        }
    }
}

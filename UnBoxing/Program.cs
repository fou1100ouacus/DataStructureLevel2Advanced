using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnBoxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;// stored in stack
            object intobj = x; // stored in heap
            Console.WriteLine(x);// boxing
            int unboxing=(int)intobj;
            Console.WriteLine(unboxing);

            Console.WriteLine(intobj);
        }
    }
}

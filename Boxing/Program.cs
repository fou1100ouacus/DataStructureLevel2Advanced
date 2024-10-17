using System;

namespace Boxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;// stored in stack
            object intobj = x; // stored in heap
            Console.WriteLine(x);
            Console.WriteLine(intobj);
        }
    }
}

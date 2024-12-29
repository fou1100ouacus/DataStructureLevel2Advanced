using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryGetValue_Method_in_Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string,int> dic=new Dictionary<string,int>();
            dic.Add("1", 4);
            dic.Add("2", 5);
            dic.Add("3", 6);
            dic.Add("4", 7);
            dic.Add("5", 8);
            dic.Add("6", 9);
            if(dic.TryGetValue("1", out int val) )
            {
                Console.WriteLine($"The value is {val} ");
            }
            else { Console.WriteLine("Not found ");
            }
        }

    }
}

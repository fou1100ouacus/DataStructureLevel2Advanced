using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> dic = new Dictionary<string, int> {
                {"a",1},
             
                {"d",4},
                   {"b",2},
                {"c",3},
                {"e",5},
                {"f",6},
            
            };
            var dic2= dic.Select(  x => new  {x.Key,x.Value}    );

            foreach(var x in dic2)
            {
                Console.WriteLine(x);
            }

            foreach (var x in dic)
            {
                Console.WriteLine(x);
            }

            var dic3 = dic.Where(x => x.Value > 3);
                Console.WriteLine("-----------------------");


            foreach (var x in dic3)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("------ - - sorted dictionary - - - - - ----------");


         var dicsorted =  dic.OrderBy(x => x.Value);


            foreach (var x in dicsorted)
            {
                Console.WriteLine(x);
            }


            Console.WriteLine("-----------------------");
            Console.WriteLine("-----------------------");

        }




    }
}

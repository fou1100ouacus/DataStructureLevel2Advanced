using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedLinqQueriesWithDic
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string,string> dic =
                new  Dictionary<string, string>
                {

                    {"apple","tree" },
                    {"banana","herb" },
                    {"cherry","tree" },
                    {"strww","bush" },
                    {"rasbry","bush" },

                };



            var groupedFruit = dic.GroupBy(x => x.Value);


            foreach (var group in groupedFruit)
            {
                Console.WriteLine("-----------");

                foreach (var item in group)
                {
                    Console.WriteLine(item.Key);
                }
            }
            Console.WriteLine("--------------------------------");



        }
    }
}

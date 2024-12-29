using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListWithLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sortedList = new SortedList<int, string>() 
            {
 { 1,"Apple"},{2,"Banana" },{3,"Cherry"},{4,"Date" },
 {5,"Grape" },{6,"Fig" }, {7,"ElderBerry" }};
           
            
            var Groups = sortedList.GroupBy(kpv => kpv.Value.Length);
            //nested list 
            foreach (var group in Groups)
            {
           Console.WriteLine($"the group of length: {group.Key} is:" + $"" +
               $" {  string.Join(",", group.Select(kpv => kpv.Value))} ");
            }
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable table=new Hashtable();
            table.Add("key1", "value1");
            table.Add("key2", "vafdfslue1");
            table.Add("key3", "value1");
            table.Add("key4", "value1");
            table.Add("key5", "value1");

            Console.WriteLine(table["key2"]);
            table.Remove("key1");
            foreach (DictionaryEntry item in table)
            {
                Console.WriteLine(item.Key +" - "+item.Value);
            }
        }
    }
}

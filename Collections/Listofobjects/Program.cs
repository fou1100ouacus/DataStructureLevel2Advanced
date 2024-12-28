using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listofobjects
{
    class clsPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public clsPerson(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<clsPerson> people = new List<clsPerson> {

 new clsPerson("Alice",30),
 new clsPerson("Bob",25),
 new clsPerson("Charlie",35),
 new clsPerson("David",40),
 new clsPerson("Eve",29),
 new clsPerson("Frank",31),
 new clsPerson("Grace",24),
 new clsPerson("Helen",27),
 };
            Console.WriteLine("Current state of the list: ");


            foreach (clsPerson Person in people)
            {
                Console.WriteLine($"the name: {Person.Name} , the age: {Person.Age}");
            }


            clsPerson person = people.Find(Person => Person.Name == "David");
            if (person != null)
            {
                Console.WriteLine($"Person Found! the name: {person.Name} , the age:  { person.Age}  ");    }
    
            person = people.FirstOrDefault(Person => Person.Name == "Alice");
            if (person != null)
            {
                person.Age = 31;
                Console.WriteLine($"Updated: the name: {person.Name} , the age:   { person.Age} "); 
            
            }

            Console.WriteLine("People over 30: ");
            List<clsPerson> peopleOver30 = people.FindAll(Person => Person.Age > 30);
            foreach (clsPerson Person in peopleOver30)
            {
                Console.WriteLine($"the name: {Person.Name} , the age: {Person.Age}");
            }
            Console.WriteLine($"Is Alice found?: {people.Any(p => p.Name == "Alice")}");
            Console.WriteLine($"Anyone is over 30?: {people.Exists(p => p.Age > 30)}");
            people.RemoveAll(p => p.Age < 30);
            foreach (clsPerson Person in people)
            {
                Console.WriteLine($"the name: {Person.Name} , the age: {Person.Age}");
            }
            Console.ReadKey();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
namespace List
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
                new clsPerson("aya", 34) ,
                  new clsPerson("ay3a", 34) ,
                new clsPerson("ayaa", 43) ,
                new clsPerson("mohamed", 434) ,




            };
            Console.WriteLine("Current state of the list: ");
            foreach (clsPerson Person in people)
            {
                Console.WriteLine($"the name: {Person.Name} , the age: {Person.Age}");
            }
         
            
            
            clsPerson person = people.Find(Person => Person.Name == "David");
            if (person != null)
            {
                Console.WriteLine($"Person Found! the name: {person.Name} , the age:   { person.Age}   ");
            }
            person = people.FirstOrDefault(Person => Person.Name == "Alice");
            if (person != null)
            {
                person.Age = 31;
                Console.WriteLine($"Updated: the name: {person.Name} , the age:   { person.Age}  ");
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Complex_Object_Operations_using_Linq_and_Sotred_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, Employee> sortedList = new SortedList<int, Employee>() {
 { 1,new Employee("Alice","HR",50000)},
 { 2,new Employee("Bob","IT",70000)},
 { 3,new Employee("Charlie","HR",52000)},
 { 4,new Employee("Daisy","IT",80000)},
 { 5,new Employee("Ethan","Marketing",45000)},
 };
            var query = sortedList.Where(e => e.Value.Department == "IT")
            .OrderByDescending(e => e.Value.Salary)
           .Select(e => e.Value.Name);
            foreach (var Name in query)
            {
                Console.WriteLine(Name);
            }

            Console.ReadKey();
        }

    }
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public Employee(string Name, string Department, decimal Salary)
        {
            this.Name = Name;
            this.Department = Department;
            this.Salary = Salary;
        }
    }

}

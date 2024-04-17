using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class LinqToLookUp
    {
        public LinqToLookUp() { }

        public void ToLookupsMethod()
        {
            List<Employee> objEmployee = new List<Employee>()
            {
                new Employee(){ Name="Akshay Tyagi", Department="IT", Country="India"},
                new Employee(){ Name="Vaishali Tyagi", Department="Marketing", Country="Australia"},
                new Employee(){ Name="Arpita Rai", Department="HR", Country="China"},
                new Employee(){ Name="Shubham Ratogi", Department="Sales", Country="USA"},
                new Employee(){ Name="Himanshu Tyagi", Department="Operations", Country="Canada"}
            };

            //objEmployee.ToLookup() method is used to print the value of the data in the pair/collection of items.  
            var Emp = objEmployee.ToLookup(x => x.Country);
            Console.WriteLine("Grouping Employees by Department");
            Console.WriteLine("---------------------------------");
            foreach (var KeyValurPair in Emp)
            {
                Console.WriteLine(KeyValurPair.Key);
                // Lookup employees by Department  
                foreach (var item in Emp[KeyValurPair.Key])
                {
                    Console.WriteLine("\t" + item.Name + "\t" + item.Department + "\t" + item.Country);
                }
            }
            Console.ReadLine();
        }
        class Employee
        {
            public string Name { get; set; }
            public string Department { get; set; }
            public string Country { get; set; }
        }

    }
}

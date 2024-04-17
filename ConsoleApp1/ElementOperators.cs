using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ElementOperators
    {
        //Create an array objList of the type of int  
        int[] objList = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] objDefault = { };

        List<Employee> objEmployee = new List<Employee>()
            {
                new Employee() { Name = "Ramya", Gender = "Male",Location="Chennai" },
                new Employee() { Name = "Rohini", Gender = "Female", Location="Chennai" },
                new Employee() { Name = "Jeny", Gender = "Male",Location="Bangalore" },
                new Employee() { Name = "Julie", Gender = "Male", Location ="Kerla"},
                new Employee() { Name = "Cyril", Gender = "Male", Location="Ooty"}
            };

        public void First()
        {
            //First() method is used to return the first element from the array 'objList'  
            int result = objList.First();// method syntax
            int result1 = (from l in objList select l).First(); //query syntax
            Console.WriteLine("Element from the List: {0}", result);
        }
        public void FirstOrDefault()
        {
            int result = objList.FirstOrDefault();
            int result1 = (from l in objList select l).FirstOrDefault();

            int objdefault = objDefault.FirstOrDefault();
            Console.WriteLine("Element from the List: {0}", result);
            Console.WriteLine("Element from the List: {0}", objdefault);
        }

        public void Last()
        {
            int result = objList.Last();
            int result1 = (from l in objList select l).Last();
            Console.WriteLine(result);
        }
        public void LastOrDefault()
        {
            int result = objList.LastOrDefault();
            int objdef = objDefault.LastOrDefault();
            //int obj = (from l in objList select l).LastOrDefault();
            Console.WriteLine(result);
            Console.WriteLine(objdef);
        }

        public void ElementAt()
        {
            int result = objList.ElementAt(3);
            Console.WriteLine(result);
        }
        public void ElementAtOrDefault()
        {
            int result = objList.ElementAtOrDefault(1);
            Console.WriteLine(result);
            // return the default value '0' because the  array 'a' does not contain any value at index 10 position
            int val1 = objList.ElementAtOrDefault(10);
            Console.WriteLine(val1);

        }
        public void Single()
        {
            //Single method will return only one value
            //var user = objEmployee.SingleOrDefault(s => s.Name != "Cyril").Location; //this statement wil return error
            var user = objEmployee.Single(s => s.Name == "Cyril").Location;
            //In case, if the Single() method found more than one element in collection or no element in the collection, then it will throw the "InvalidOperationException" 
            int val = objList.Single(j => j > 8);
            Console.WriteLine("Element from objStudent: {0}", user);
            Console.WriteLine("Element from objList: {0}", val);
        }
        public void SingleOrDefault()
        {
            //Single method will return only one value
            //var user = objEmployee.SingleOrDefault(s => s.Name != "Cyril").Location; //this statement wil return error
            var user = objEmployee.SingleOrDefault(s => s.Name == "Cyril").Location;
            //In case, if the Single() method found more than one element in collection or no element in the collection, then it will throw the "InvalidOperationException" 
            int val = objList.SingleOrDefault(j => j > 9); //Return default value 0
            Console.WriteLine("Element from objStudent: {0}", user);
            Console.WriteLine("Element from objList: {0}", val);
        }
        public void DefaultIfEmpty()
        {
            var val = objList.DefaultIfEmpty();
            foreach (var item in val)
                Console.WriteLine(item);
        }

    }
}
public class Employee
{
    public string Name { get; set; }
    public string Gender { get; set; }
    public string Location { get; set; }
}

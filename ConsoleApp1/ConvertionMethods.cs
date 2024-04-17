using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ConvertionMethods
    {
        string[] countries = { "US", "UK", "India", "Russia", "China", "Australia", "Argentina" };
        public void ToList()
        {
            //countries.ToList() convert the collection of data into the list.  
            List<string> MethodSyn = countries.ToList(); //Method syntax
            List<string> result = (from x in countries select x).ToList();// Query syntax
            //foreach loop is used to print the information of the student  
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }

        public void ToArray()
        {
            string[] QuerySyn = (from x in countries select x).ToArray();
            string[] countryarray = countries.ToArray();//method syntax
            foreach (string s in countryarray)
            {
                Console.WriteLine(s);
            }
        }

        public void Cast()
        {
            var result = countries.Cast<string>();

            foreach (string s in result)
            {
                Console.WriteLine($"{s}");
            }
        }
        public void OfType()
        {
            //ofType() method will return the value only the specific type  
            IEnumerable<string> result = countries.OfType<string>();
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }
        public void AsEnumerable()
        {
            var result = countries.AsEnumerable();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public void ToDictionary()
        {
            var student = countries.ToDictionary(x => x);
            foreach (var item in student)
            {
                Console.WriteLine(item);
            }
        }
    }
}

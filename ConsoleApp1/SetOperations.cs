using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SetOperations
    {
        string[] country= { "India","Canada", "USA", "UK", "Australia", "UK","China","USA", "Canada" };
        string[] count1 = { "India", "USA", "UK", "Australia" };
        string[] count2 = { "India", "Canada", "UK", "China" };

        public void Union()
        {
            var result = count1.Union(count2);
            foreach (var item in result)
                Console.WriteLine(item);
        }
        public void Intersect()
        {
            var result = count1.Intersect(count2);
            foreach (var item in result)
                Console.WriteLine(item);
        }
        public void Distinct()
        {
            var result = country.Distinct();
            foreach (var item in result)
                Console.WriteLine(item);
        }
        public void Except()
        {
            var result = country.Except(count1);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        public void Concat()
        { 
            var result = country.Concat(count1);
            foreach (var item in result)
                Console.WriteLine(item);
        }



    }
}

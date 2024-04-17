using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Takes
    {
        string[] countries = { "India", "USA", "Russia", "China", "Australia", "Argentina" };

        public void Take()
        {
            IEnumerable<string> result = (from x in countries select x).Take(3);
            var objTake = countries.Take(4);
            Console.WriteLine(objTake);
        }

        public void Skip()
        {
            //skip method is used to with the IEnumerable to return the value which skip the third element of the array */
            IEnumerable<string> skipval = countries.Skip(3);
            Console.WriteLine(skipval);
        }

        public void TakeWhile()
        {
            IEnumerable<string> MethodSyn = countries.TakeWhile(x => x.StartsWith("U"));
            var QuerySyn = (from x in countries select x).TakeWhile(x => x.StartsWith("A"));
            Console.WriteLine(MethodSyn);
            Console.WriteLine(QuerySyn);
        }

        public void Select()
        {
            var MethodSyn = countries.ToArray(); //method syntax
            var QuerySyn = (from x in countries select x).ToArray(); //query syntax

            foreach (var i in MethodSyn)
            {
                Console.WriteLine(i);
            }
        }


    }
}

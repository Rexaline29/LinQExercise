using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ExceptionClass
    {
        public ExceptionClass() { }

        public void ExceptionMethod() 
        {
             int x, y, z;
            Console.WriteLine("Enter X :");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y :");
            y = int.Parse(Console.ReadLine());

            try
            {
                z = x / y;
            }
            catch (Exception ex)
            {
                Console.WriteLine("The value should not be zero");
                while (y == 0)
                {
                    Console.WriteLine("Enter Non zero value for z:");
                }
                z = x / y;
            }
            Console.WriteLine("The Result is:" + z);
        }


    }
}

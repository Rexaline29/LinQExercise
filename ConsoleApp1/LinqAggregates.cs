using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class LinqAggregates
    {
        public LinqAggregates() { }

        public int[] Num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public void FindMax()
        {
            //find max using query syntax
            var QuerySyntax = (from obj in Num
                               select obj).Max();
            //Mthod syntax
            var MethodSyn = Num.Select(obj => obj).Max();

            var max = Num.Max();
            Console.WriteLine("The Maximum Values");
            Console.WriteLine(max);
            Console.WriteLine(QuerySyntax);
            Console.WriteLine(MethodSyn);
        }

        public void FindMin()
        {
            //find min using query syntax
            var QuerySyntax = (from obj in Num
                               where obj > 5
                               select obj).Min();
            //Mthod syntax
            var MethodSyn = Num.Select(obj => obj > 5).Min();

            var min = Num.Min();
            Console.WriteLine("The Minimum Values");
            Console.WriteLine(min);
            Console.WriteLine(QuerySyntax);
            Console.WriteLine(MethodSyn);
        }

        public void FindSum()
        {
            //find sum using query syntax
            var QuerySyntax = (from obj in Num
                               where obj > 5
                               select obj).Sum();
            //Mthod syntax
            var MethodSyn = Num.Select(obj => obj).Sum();

            var sum = Num.Sum();
            Console.WriteLine("The Sum Values");
            Console.WriteLine(sum);
            Console.WriteLine(QuerySyntax);
            Console.WriteLine(MethodSyn);
        }
        public void FindCOunt()
        {
            //find count using query syntax
            var QuerySyntax = (from obj in Num
                               where obj > 5
                               select obj).Count();
            //Mthod syntax
            var MethodSyn = Num.Select(obj => obj).Count();

            var count = Num.Count();
            Console.WriteLine("The Count Values");
            Console.WriteLine(count);
            Console.WriteLine(QuerySyntax);
            Console.WriteLine(MethodSyn);
        }

        public void FindSecondLargeNum()
        {
            var secondMax = Num.OrderByDescending(r => r).Take(4).LastOrDefault();

            //var secondMax = Num.OrderByDescending(r => r).Skip(1).FirstOrDefault(); 
            Console.WriteLine(secondMax);
        }

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinqAggregates aggres = new LinqAggregates();
            //aggres.FindMax();
            //aggres.FindSum();
            //aggres.FindCOunt();

            OrderBy ord= new OrderBy();
            //ord.OrderByAsc();
            //ord.OrderByDesc();
            //ord.ThenByDesc();
            //ord.ToDictionary();
            //ord.GroupBy();
            //ord.Case();

            //LinqToLookUp LookUp = new LinqToLookUp();
            //LookUp.ToLookupsMethod();

            ConvertionMethods ConMet = new ConvertionMethods();
            //ConMet.Cast();
            //ConMet.OfType();
            //ConMet.AsEnumerable();
            //ConMet.ToDictionary();

            ElementOperators eleOpr= new ElementOperators();
            //eleOpr.First();
            //eleOpr.FirstOrDefault();
            //eleOpr.Last();
            //eleOpr.LastOrDefault();
            //eleOpr.ElementAt();
            //eleOpr.ElementAtOrDefault();
            //eleOpr.SingleOrDefault();
            //eleOpr.DefaultIfEmpty();
           
            SetOperations st= new SetOperations();
            //st.Union();
            //st.Intersect();
            //st.Distinct();
            //st.Except();
            //st.Concat();

            LinqJoins joins = new LinqJoins();
            //joins.InnerJoin();
            //joins.LeftOuterJoin();
            //joins.CrossJoin();
            //joins.GroupJoin();

            aggres.FindSecondLargeNum();
            Console.ReadLine();
            //Git hub repository
        }
    }
}

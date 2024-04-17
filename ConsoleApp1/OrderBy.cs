using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class OrderBy
    {
        public int Id { get; set; }

        List<Student> Objstudent = new List<Student>() {
           new Student() {RoleId=1 , Name = "Ramya", Gender = "Female",  Location="Chennai",Subjects = new List<string> { "Maths", "Physics" } },
           new Student() {RoleId=2 , Name = "Jeni", Gender = "Female",   Location="Kerla",Subjects = new List<string> { "Entomology", "Botany" } },
           new Student() {RoleId=3 , Name = "Infancy", Gender = "Female",Location="Bangalore",Subjects = new List<string> { "Science", "Computer" } },
           new Student() {RoleId=4 , Name = "Cyril", Gender = "Male",    Location="Viriyur",Subjects = new List<string> { "Social", "Science" } },
           new Student() {RoleId=5 , Name = "Lilly", Gender = "Female",  Location="Hosur",Subjects = new List<string> { "Maths", "Computer" } }
        };

        public void OrderByAsc()
        {
            //Linq order by asc 
            var MethodSyn = Objstudent.OrderBy(n => n.Name);
            Console.WriteLine("OrderBy Ascending Method syntax");
            foreach (var i in MethodSyn)
            {
                Console.WriteLine(i.Name);
            }
            Console.WriteLine("\n");
            var QuerySyn = (from x in Objstudent select x).OrderBy(x => x.Name);
            Console.WriteLine("OrderBy Ascending Query syntax ");
            foreach (var i in QuerySyn)
            {
                Console.WriteLine(i.Name);
            }

            Console.WriteLine("\n");
        }
        public void OrderByDesc()
        {
            //Linq order by desc 
            var MethodSyn = Objstudent.OrderByDescending(n => n.Name);
            Console.WriteLine("OrderBy Descending Method syntax");
            foreach (var i in MethodSyn)
            {
                Console.WriteLine(i.Name);
            }
            Console.WriteLine("\n");

            var QuerySyn = (from x in Objstudent select x).OrderByDescending(x => x.Name);
            Console.WriteLine("OrderBy Descending Query syntax");
            foreach (var i in QuerySyn)
            {
                Console.WriteLine(i.Name);
            }
            Console.WriteLine("\n");
        }

        public void ThenBy()
        {
            //ThenBy() operator is used here to sort the Information of the student in ascending form on the behalf of the RollNumber

            var MethodSyn = Objstudent.OrderBy(n => n.Name).ThenBy(n => n.Gender);
            Console.WriteLine("ThenBy Ascending Method syntax");
            foreach (var i in MethodSyn)
            {
                Console.WriteLine("Name={0} studentid={1}", i.Name, i.RoleId);
            }
            Console.WriteLine("\n");

            //Query syntax
            var QuerySyn = (from x in Objstudent select x).OrderBy(x => x.Name).ThenBy(x => x.RoleId);
            Console.WriteLine("ThenBy Descending Query syntax");
            foreach (var j in QuerySyn)
            {
                Console.WriteLine("Name={0} studentid={1}", j.Name, j.RoleId);
            }
            Console.WriteLine("\n");
        }
        public void ThenByDesc()
        {
            //ThenBy() operator is used here to sort the Information of the student in ascending form on the behalf of the RollNumber
            var MethodSyn = Objstudent.OrderByDescending(n => n.Name).ThenByDescending(n => n.Gender);
            Console.WriteLine("ThenBy Descending Method syntax");
            foreach (var i in MethodSyn)
            {
                Console.WriteLine("Name={0} studentid={1}", i.Name, i.RoleId);
            }
            Console.WriteLine("\n");

            //Query syntax
            var QuerySyn = (from x in Objstudent select x).OrderByDescending(x => x.Name).ThenByDescending(x => x.RoleId);
            Console.WriteLine("ThenBy Descending Query syntax");
            foreach (var j in QuerySyn)
            {
                Console.WriteLine("Name={0} studentid={1}", j.Name, j.RoleId);
            }
            Console.WriteLine("\n");
        }

        public void ToDictionary()
        {
            var student = Objstudent.ToDictionary(x => x.RoleId, x => x.Name);
            foreach (var item in student)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }
        }
        public void GroupBy()
        {
            //Method syntax
            var objStu = Objstudent.GroupBy(x => x.Gender);
            //Query syntax
            var student = from std in Objstudent
                          group std by std.Gender;
            foreach (var item in student)
            {
                Console.WriteLine(item.Key, item.Count());
                foreach (var stud in item)
                {
                    Console.WriteLine(stud.Name + "\t" + stud.Gender + "\t" + stud.Location);
                }
            }
        }

        public void Case()
        {

            var Student =
            (
                from s in Objstudent
                select new
                {
                    Name=s.Name,Location=s.Location,
                    Gender =
                    (
                        s.Equals("Male") ? 0 : 1 // Need to check for Male condition
                    )
                }
            );
            foreach (var Stud in Student)
                Console.WriteLine(Stud.Name + "\t" + Stud.Gender + "\t" + Stud.Location);
        }
    }
    class Student
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Location { get; set; }
        public List<string> Subjects { get; set; }
    }
}

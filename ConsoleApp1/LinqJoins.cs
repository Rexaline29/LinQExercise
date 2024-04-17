using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class LinqJoins
    {
        List<Department> Dept = new List<Department>()
         {
         new Department{DepId=1,DepName="Maths"},
         new Department{DepId=2,DepName="Science"},
         new Department{DepId=3,DepName="Computer"}
         };
        List<StudentDept> Stud = new List<StudentDept>()
         {
         new StudentDept { Id=1,Name = "Ramya", DeptId=1 },
         new StudentDept { Id=2,Name = "Ajay", DeptId=3 },
         new StudentDept { Id=3,Name = "Roy", DeptId=23},
         new StudentDept { Id=4,Name = "Julie", DeptId =2},
         new StudentDept { Id=5,Name = "Infancy"}
         };
        public void InnerJoin()
        {
            var result = from d in Dept
                         join s in Stud
                         on d.DepId equals s.DeptId
                         select new
                         {
                             StudentName = s.Name,
                             DepartmentName = d.DepName
                         };

            foreach (var item in result)
            {
                Console.WriteLine(item.StudentName + "\t| " + item.DepartmentName);
            }
        }

        public void LeftOuterJoin()
        {
            var result = from s in Stud
                         join d in Dept
                         on s.DeptId equals d.DepId into empDept
                         from ed in empDept.DefaultIfEmpty()
                         select new
                         {
                             StudentName = s.Name,
                             DepartmentName = ed == null ? "No Department" : ed.DepName
                         };
            foreach (var item in result)
            {
                Console.WriteLine(item.StudentName + "\t | " + item.DepartmentName);
            }
        }
        public void CrossJoin()
        {
            var result = from s in Stud

                         from d in Dept
                         select new
                         {
                             StudentName = s.Name,
                             DepartmentName = d.DepName
                         };
            foreach (var Stu in result)
                Console.WriteLine(Stu.StudentName + "\t|" + Stu.DepartmentName);
        }
        public void GroupJoin()
        {
            var result = from d in Dept
                         join s in Stud on d.DepId equals s.DeptId into empDept
                         select new
                         {
                             DepartmentName = d.DepName,
                             Employees = from emp2 in empDept
                                         orderby emp2.Name
                                         select emp2
                         };
            int totalItems = 0;
            foreach (var empGroup in result)
            {
                Console.WriteLine(empGroup.DepartmentName);
                foreach (var item in empGroup.Employees)
                {
                    totalItems++;
                    Console.WriteLine("    {0}", item.Name);
                }
            }
        }

    }
}

class Department
{
    public int DepId { get; set; }
    public string DepName { get; set; }
}
class StudentDept
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int DeptId { get; set; }
}
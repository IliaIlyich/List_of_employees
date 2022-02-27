using System;
using System.Collections.Generic;
using System.Linq;
namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Ivanov", "Ivan", new DateTime(1990, 3, 15), Employee.AcademicDegree.Professor); 
            employee1.Subject[Employee.SubjectList.Math]=100;
            employee1.Article["C# for everyone"]= new Article(new DateTime(2018, 4, 1), "Computer Science");
            employee1.Article["Technical documents quality"]=new Article(new DateTime(2022, 1,20), "Computer Science");
            Console.WriteLine(employee1);
        }
    }
}

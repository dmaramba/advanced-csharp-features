using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LU1Theme2
{
    internal class AnonymousType
    {
        public AnonymousType()
        {
            var student = new { Name = "John$", Surname = "Doe", Age = 19 };
            Console.WriteLine($"Name : {student.Name.ReplaceSpecialCharacters()}");
            Console.WriteLine($"Surname : {student.Surname}");
            Console.WriteLine($"Age : {student.Age}");

            var students = new[]
            {
                new {Name="John", Mark=100},
                new {Name="Marry", Mark=89},
                new {Name="Tracy", Mark=90},
            };

            Console.WriteLine("Marks");
            foreach (var item in students)
            {
                Console.WriteLine($"{item.Name}  - {item.Mark}");
            }
        }
    }
}

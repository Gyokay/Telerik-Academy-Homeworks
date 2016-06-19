using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Extension_Methods_Delegates_Lambda_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            Student[] students = new Student[3]
            {
                new Student { FirstName = "Ivan", LastName = "Ivanov" },
                new Student { FirstName = "Ivanka", LastName = "Ivanova" },
                new Student { FirstName = "Georgi", LastName = "Georgiev" }

            };
        }


        //Problem 3. First before last
        //Write a method that from a given array of students finds 
        //all students whose first name is before its last name alphabetically.
        //Use LINQ query operators.

        public static Student[] FilterStudents(Student[] students)
        {
            Student[] filteredStudents = (from student in students
                                          where student.FirstName.CompareTo(student.LastName) < 0
                                          select student).ToArray();

            return filteredStudents;
        }
    }
}

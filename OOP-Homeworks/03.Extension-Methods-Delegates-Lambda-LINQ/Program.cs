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
                new Student { FirstName = "Ivan", LastName = "Ivanov", Age = 22 },
                new Student { FirstName = "Ivanka", LastName = "Ivanova", Age = 23 },
                new Student { FirstName = "Georgi", LastName = "Georgiev", Age = 99 }

            };
        }


        //Problem 3. First before last
        //Write a method that from a given array of students finds 
        //all students whose first name is before its last name alphabetically.
        //Use LINQ query operators.

        public static Student[] FilterStudentsName(Student[] students)
        {
            Student[] filteredStudents = (from student in students
                                          where student.FirstName.CompareTo(student.LastName) < 0
                                          select student).ToArray();

            return filteredStudents;
        }

        //Problem 4. Age range
        //Write a LINQ query that finds the first name and last 
        //name of all students with age between 18 and 24.

        public static Student[] FilterStudentsAge(Student[] students)
        {
            Student[] studentsFilteredByAge = (from student in students
                                               where student.Age >= 18 && student.Age <= 24
                                               select student).ToArray();

            return studentsFilteredByAge;
        }
    }
}

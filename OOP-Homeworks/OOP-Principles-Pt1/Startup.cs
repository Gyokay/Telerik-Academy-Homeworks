
namespace OOP_Principles_Pt1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            students.Add(new Student("Student", "Four", 5));
            students.Add(new Student("Student", "One", 2));
            students.Add(new Student("Student", "Thre", 4));
            students.Add(new Student("Student", "Five", 6));
            students.Add(new Student("Student", "Two", 3));

            var ordered = from element in students
                          orderby element.Grade ascending
                          select element;

            var workers = new List<Worker>();

            workers.Add(new Worker("Worker", "One", 300, 8));
            workers.Add(new Worker("Worker", "Two", 400, 10));
            workers.Add(new Worker("Worker", "Three", 450, 9));
            workers.Add(new Worker("Worker", "Four", 500, 11));
            workers.Add(new Worker("Worker", "Five", 2020, 5));
            workers.Add(new Worker("Worker", "Six", 23423, 3));

            var orderByMoneyPerHour = from element in workers
                                      orderby element.MoneyPerHour() descending
                                      select element;

            IEnumerable<Animal> dogs = new Animal[]
            {
                new Dog(5, "Rex", Sex.male),
                new Dog(4, "Lolly", Sex.female)
            };

            IEnumerable<Animal> frogs = new Animal[]
            {
                new Frog(3, "Prince", Sex.male),
                new Frog(4, "Princess", Sex.female),
            };

            IEnumerable<Animal> cats = new Animal[]
            {
                new Kitten(5, "Becky"),
                new Tomcat(2, "Josh")
            };

            double dogsAverageAge = Animal.GetAverageAge(dogs);
            double frogsAverageAge = Animal.GetAverageAge(frogs);
            double catsAverageAge = Animal.GetAverageAge(cats);

            Console.WriteLine("Dogs average age: {0:0.0}", dogsAverageAge);
            Console.WriteLine("Frogs average age: {0:0.0}", frogsAverageAge);
            Console.WriteLine("Cats average age: {0:0.0}", catsAverageAge);


        }
    }
}

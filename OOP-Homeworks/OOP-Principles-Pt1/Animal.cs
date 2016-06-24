using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles_Pt1
{
    internal abstract class Animal : ISound
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Sex Sex { get; set; }

        public Animal(int age, string name, Sex sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public void MakeSound()
        {

        }

        public static double GetAverageAge(IEnumerable<Animal> animalsOfKind)
        {
            double totalAge = 0;
            int animalsCount = 0;

            foreach (Animal animal in animalsOfKind)
            {
                totalAge += animal.Age;
                animalsCount++;
            }

            return totalAge / animalsCount;
        }
    }
}

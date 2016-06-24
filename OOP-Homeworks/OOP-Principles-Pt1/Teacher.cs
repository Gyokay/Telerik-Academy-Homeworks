
namespace School
{
    using System.Collections.Generic;

    internal class Teacher : Person
    {
        public IList<Disciplines> Disciplines { get; private set; }

        public Teacher(string name) : base(name)
        {
            this.Disciplines = new List<Disciplines>();
        }

        public void AddDiscipline(Disciplines discipline)
        {
            Disciplines.Add(discipline);
        }
    }
}

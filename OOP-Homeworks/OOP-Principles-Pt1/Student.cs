namespace OOP_Principles_Pt1
{
    using School;
    using System;

    class Student : Human, IComment
    {
        private readonly int iD;
        internal int Grade { get; set; }
        public int MyProperty { get; set; }
        public string Comment { get; set; }
        private Random random;

        internal Student(string firstName, string lastName, int grade) : base(firstName, lastName)
        {
            this.Grade = grade;
            this.random = new Random();
            this.iD = random.Next(0, 4568);
        }

        public int ID
        {
            get { return this.iD; }
        }


    }
}

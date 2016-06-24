namespace School
{
    internal class Discipline
    {
        public Disciplines DisciplineType { get; set; }
        public int NumberOfLectures { get; set; }
        public int NumberOfExercises { get; set; }

        public Discipline(Disciplines discipline, int numberOfLectures, int numberOfExercises)
        {
            this.DisciplineType = discipline;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }
    }
}

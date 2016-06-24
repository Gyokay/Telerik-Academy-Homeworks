namespace OOP_Principles_Pt1
{
    class Worker : Human
    {
        public int WeekSalary { get; set; }
        public int WorkHoursPerDay { get; set; }

        internal Worker(string firstName, string lastName, int weekSalary, int workHorsPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHorsPerDay;
        }

        public int MoneyPerHour()
        {
            return this.WeekSalary / (this.WorkHoursPerDay * 5);
        }

        public override string ToString()
        {
            return string.Format($"Sallary per hour: {MoneyPerHour()}");
        }
    }
}

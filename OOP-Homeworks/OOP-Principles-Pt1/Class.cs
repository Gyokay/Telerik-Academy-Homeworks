namespace School
{
    using System.Collections.Generic;

    internal class Class
    {
        private IList<Teacher> teachers;

        public Class()
        {
            this.teachers = new List<Teacher>();
        }
        
        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }
    }
}

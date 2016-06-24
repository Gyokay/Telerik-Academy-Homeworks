namespace OOP_Principles_Pt1
{
    internal class Kitten : Cat, ISound
    {
        public Kitten(int age, string name) : base(age, name, Sex.female)
        {

        }
    }
}

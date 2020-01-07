namespace Homework_1
{
    internal abstract class Animal
    {
        public string Name { get; protected set; }
        protected int Age;
        protected double Height;

        public virtual string Info()
        {
            return string.Format("{0} с возрастом {1} лет и ростом {2} метра ", Name, Age,Height);
        }
    }
 }
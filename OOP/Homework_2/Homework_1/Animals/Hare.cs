using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal class Hare : Animal
    {
        private readonly string _Tail;
        private readonly string _Profession;

        private readonly string[] TypesOfTail = { "пушистым", "коротким", "длинным", "обрезанным" };
        private readonly string[] TypesOfProfession = { "программистом", "математиком", "физиком" };


        public Hare(string name, int age,  double height)
        {
            _Tail = Randomizer.GetRandomElementFromArray(TypesOfTail).ToString();
            _Profession = Randomizer.GetRandomElementFromArray(TypesOfProfession).ToString();

            Name = name;
            Age = age;
            Height = height;
        }

        public override string Info()
        {
            return base.Info() + string.Format("был он c {0} хвостом и очень хотел стать {1} ", _Tail, _Profession);
        }
    }
}

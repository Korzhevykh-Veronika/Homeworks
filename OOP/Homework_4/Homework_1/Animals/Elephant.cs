using System.Collections.Generic;

namespace Homework_1
{
    internal class Elephant: Animal
    {
        private readonly string _Trunk;
        private readonly string _Preferences;

        private readonly List<string> TypesOfTrunk = new List<string>() { "длинным", "коротким", "волнийстым", "прямым", "кривым" };
        private readonly List<string> TypesOfPreferences = new List<string>() { "танцевать", "рисовать", "петь", "шалить" };

        public Elephant(string name, int age, int height)
        {
            _Trunk = Randomizer.GetRandomElementFromArray(TypesOfTrunk).ToString();
            _Preferences = Randomizer.GetRandomElementFromArray(TypesOfPreferences).ToString();
            Name = name;
            Age = age;
            Height = height;
        }

        public override string Info()
        {
            return base.Info() +
                   string.Format("был он c {0} хобботом и очень он любил {1} ",_Trunk,_Preferences);
        }
    }
}
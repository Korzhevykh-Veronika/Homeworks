using Homework_1.Endings;
using System;

namespace Homework_1
{
    public static class Program
    {
        private static void Main()
        {
            Ending[] endings = 
            {
                new Positive(),
                new Negative()
            };

            Animal[] animals = 
            {
                new Elephant("слоник Тимошка", 5, 4),
                new Elephant("слоник Квадратик", 6, 2),
                new Hare("зайчик Умник", 7, 0.5),
                new Hare("зайчик Доставайчик", 5, 0.2)
            };

            FairyTaleCreator creator = new FairyTaleCreator(endings, animals);

            creator.CreateFairyTeil();

            Console.ReadLine();
        }
    }
}






using Homework_1.Endings;
using System;
using System.Collections.Generic;

namespace Homework_1
{
    public static class Program
    {
        private static void Main()
        {
            List<Ending> endings = new List<Ending>()
            {
                new Positive(),
                new Negative()
            };

            List<Animal> animals = new List<Animal>
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






using Homework_1.Endings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                new Elephant("слониха Маргарита", 6, 2),
                new Hare("зайчик Умник", 7, 0.5)
            };

            FairyTailCreator creator = new FairyTailCreator(endings, animals);

            Console.WriteLine(creator.CreateFairyTeil());

            Console.ReadLine();
        }
    }
}






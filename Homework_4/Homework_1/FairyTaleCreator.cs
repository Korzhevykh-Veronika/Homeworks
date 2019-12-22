using Homework_1.Endings;
using Homework_1.Tree;
using System.Collections.Generic;

namespace Homework_1
{
    class FairyTaleCreator
    {
        private FairyTaleData FairyTaleData;
        List<Ending> Endings;
        List<Animal> Animals;

        public FairyTaleCreator(List<Ending> endings, List<Animal> animals)
        {
            this.Endings = endings;
            this.Animals = animals;
        }

        public void CreateFairyTeil()
        {
            var data = DefineData();
            FairyTaleTreeInitializer initializer = new FairyTaleTreeInitializer(data);

            var rootNode = initializer.Initialize();

            rootNode.Process();
        }

        public FairyTaleData DefineData()
        {
            ConsoleDecorator decorator = new ConsoleDecorator();
            System.Console.WriteLine("Придумываем сказку...");

            var ending = Randomizer.GetRandomElementFromArray<Ending>(Endings);
            var animal1 = Randomizer.GetRandomElementFromArray<Animal>(Animals);
            var animal2 = Randomizer.GetRandomElementFromArray<Animal>(Animals);

            decorator.Decorate();

            return new FairyTaleData(ending, animal1, animal2);
        }
    }
}

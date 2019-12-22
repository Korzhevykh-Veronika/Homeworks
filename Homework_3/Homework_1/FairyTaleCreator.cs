using Homework_1.Endings;
using Homework_1.Tree;

namespace Homework_1
{
    class FairyTaleCreator
    {
        private FairyTaleData FairyTaleData;
        Ending[] Endings;
        Animal[] Animals;

        public FairyTaleCreator(Ending[] endings, Animal[] animals)
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

            var ending = (Ending)Randomizer.GetRandomElementFromArray(Endings);
            var animal1 = (Animal)Randomizer.GetRandomElementFromArray(Animals);
            var animal2 = (Animal)Randomizer.GetRandomElementFromArray(Animals);

            decorator.Decorate();

            return new FairyTaleData(ending, animal1, animal2);
        }
    }
}

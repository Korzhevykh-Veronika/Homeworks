using Homework_1.Endings;
using Homework_1.Tree;

namespace Homework_1
{
    class FairyTaleCreator
    {
        private FairyTaleData FairyTaleData;

        public FairyTaleCreator(Ending[] Endings, Animal[] animals)
        {
            var ending = (Ending)Randomizer.GetRandomElementFromArray(Endings);
            var animal1 = (Animal)Randomizer.GetRandomElementFromArray(animals);
            var animal2 = (Animal)Randomizer.GetRandomElementFromArray(animals);

            FairyTaleData = new FairyTaleData(ending, animal1, animal2);
        }

        public void CreateFairyTeil()
        {
            FairyTaleTreeInitializer initializer = new FairyTaleTreeInitializer(FairyTaleData);

            var rootNode = initializer.Initialize();

            rootNode.Process();           
        }
    }
}

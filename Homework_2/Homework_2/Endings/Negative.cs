namespace Homework_1.Endings
{
    class Negative : Ending
    {
        public override string GetEnding()
        {
            return base.GetEnding() + "Кто не слушал - вам конец.";
        }
    }
}

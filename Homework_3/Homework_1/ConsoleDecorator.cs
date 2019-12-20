using System;

namespace Homework_1
{
    public class ConsoleDecorator
    {
        ConsoleColor[] colors = { ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Yellow };

        public void DryConsole()
        {
            Console.BackgroundColor = (ConsoleColor)Randomizer.GetRandomElementFromArray(colors);
        }
    }
}

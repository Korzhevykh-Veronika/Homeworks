using System;

namespace Homework_1
{
    public class ConsoleDecorator
    {
        ConsoleColor[] colors = { ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Yellow };

        delegate void ProcessEnding();
        event ProcessEnding endFairyTaleEvent;

        public ConsoleDecorator()
        {
            endFairyTaleEvent += DryBackground;
            endFairyTaleEvent += DryText;
        }

        public void Decorate()
        {
            endFairyTaleEvent.Invoke(); 
        }

        private void DryBackground()
        {
            Console.BackgroundColor = Randomizer.GetRandomConsoleColor();
        }

        private void DryText()
        {
            Console.ForegroundColor = Randomizer.GetRandomConsoleColor();
        }
    }
}

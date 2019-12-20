using System;
using System.Collections.Generic;
using System.Threading;

namespace Homework_1
{
    static class Randomizer
    {
        static Random _random = new Random();

        public static object GetRandomElementFromArray(object[] array)
        {
            int mIndex = _random.Next(array.Length);
            Thread.Sleep(1000);

            return array[mIndex];
        }

        public static ConsoleColor GetRandomConsoleColor()
        {
            return (ConsoleColor)_random.Next(15);
        }
    }
}

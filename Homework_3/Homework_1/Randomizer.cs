using System;
using System.Collections.Generic;
using System.Threading;

namespace Homework_1
{
    static class Randomizer
    {
        public static object GetRandomElementFromArray(object[] array)
        {
            Random rnd = new Random();

            int mIndex = rnd.Next(array.Length);
            Thread.Sleep(1000);

            return array[mIndex];
        }
    }
}

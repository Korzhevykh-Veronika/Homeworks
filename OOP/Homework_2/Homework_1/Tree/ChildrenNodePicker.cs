using System;
using System.Collections.Generic;

namespace Homework_1.Tree
{
    public class ChildrenNodePicker : IPicker
    {
        public int PickNode(List<FairyTalePartNode> nodes)
        {
            for (int i = 0; i < nodes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {nodes[i].Description}");
            }

            int index = 0;

            try
            {
                int upperLimit = nodes.Count - 1;
                int lowerLimit = 0;

                do
                {
                    index = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (index >= lowerLimit && index <= upperLimit) break;

                    Console.WriteLine("~Ошибка валидации.");
                } while (true);
            }
            catch (Exception ex)
            {
                index = 0;
                Console.WriteLine("~Неверный формат. Выбран 1 вариант.");
            }

            return index;
        }
    }
}

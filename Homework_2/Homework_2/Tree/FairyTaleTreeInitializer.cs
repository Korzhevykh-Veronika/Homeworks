using System.Collections.Generic;

namespace Homework_1.Tree
{
    public class FairyTaleTreeInitializer
    {
        FairyTaleData Data;

        public FairyTaleTreeInitializer(FairyTaleData data)
        {
            this.Data = data;
        }

        public FairyTalePartNode Initialize()
        {
            var grandChildren3 = new List<FairyTalePartNode>()
            {
                new FairyTalePartNode("Царю царевичу", $"Ой, нашли у кого спросить, мой профиль - управление государством. Нужно было идти к мудрецу за такими вопросами.\n{Data.Ending.GetEnding()}", null),
                new FairyTalePartNode("Королю-королевичу", $"Я считаю, что важнее считать казну и радовать народ.\n{Data.Ending.GetEnding()}", null),
                new FairyTalePartNode("Мудрецу", $"И пошли друзья в деревню к мурдецу. И сидел он в башне непреступной, но услышал вопрос важный и ответил: Математика конечно.\n{Data.Ending.GetEnding()}", null)
            };

            var children = new List<FairyTalePartNode>()
            {
                new FairyTalePartNode("Смысле жизни", $"С биологической точки зрения - дать потомство, ответил {Data.Animal1.Name}", null),
                new FairyTalePartNode("Почему небо голубое", "Какой-то текст. И Была у них:", null),
                new FairyTalePartNode("Что важнее: математика либо рисование?", $"\nОт такого глупого вопроса {Data.Animal2.Name} чуть не поперхнулся яблоком."
               + $"\n- Ты, должно быть, шутишь! – воскликнул {Data.Animal2.Name}."
               + " \n– Рисование самое полезное и важное что может быть в жизни, ведь всех детей учат рисовать с самого детсва." 
               + $"А твоя математика никому не нужна, она вовсе не интересная! Но {Data.Animal1.Name} продолжал:"
               + "\nЭто ты так думаешь! Но я знаю, что математика -это царица наук и она важна в жизни каждого человека и поэтому нам нужен судья, чтобы рассудить нас.Ты согласен ?"
               + $"\n— Конечно! – ответил {Data.Animal2.Name}, все еще недоумевая над вопросом своего друга.\n-Пойдём у кого-то спросим?\n-Тогда пошли к деревне людей и спросим у них. Они самые умные среди всех животных и самые лучшие судьи!"
              + "\nНу пойдём к:", grandChildren3)
            };

            var root = new FairyTalePartNode(
                "", 
                "Давным-давно в далеких индийских джунглях жили :"
                    + $"{Data.Animal1.Info()} и {Data.Animal2.Info()}. Одним солнечным днём, {Data.Animal1.Name} спросил о",
                children);

            return root;
        }
    }
}

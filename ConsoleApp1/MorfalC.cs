using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MorfalC
    {
        public MorfalC()
        {
            Console.WriteLine("Вы находитесь в Морфале ");
            Console.WriteLine("1 Посмотереть свою статистику \n 2 Собрать повозку и отправится в путь \n 3 Поторговатся \n 4 Узнать что творится");
            int user = Convert.ToInt32(Console.ReadLine());
            if (user == 1)
            {
                State state = new State();
            }
            if (user == 2)
            {
                Map map = new Map();
                map.Morfal();
            }
            if (user == 3)
            {
                Console.WriteLine("Покажи, что есть");
                Trade trade = new Trade();
            }
            if (user == 4)
            {
                Console.WriteLine("Старая женщина говорит что она видела дракона");
            }
        }
    }
}


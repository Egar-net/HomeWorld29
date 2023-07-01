using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Trader
    {
        public Trader()
        {
            Trade trade = new Trade();

            Console.WriteLine("Добро пожаловать в торговый центр!");
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Купить");
            Console.WriteLine("2. Продать");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    trade.Buy();
                    break;
                case 2:
                    trade.Sell();
                    break;
                default:
                    Console.WriteLine("Некорректный выбор.");
                    break;
            }

            Console.WriteLine("Остаток денег: " + trade.money);
            Console.ReadLine();
        }
    }
}

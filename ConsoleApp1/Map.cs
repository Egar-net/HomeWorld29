using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Map
    {
        public void Riverwood()
        {
            Console.WriteLine("Вы можете отправится в эти города:\n 1 Вайтран 10.5км \n2 Фолкрит 10.7км");
            int user = Convert.ToInt32(Console.ReadLine());
            if (user == 1)
            {
                Console.WriteLine("Вы отправляетесь в Вайтран");
                Console.WriteLine("Ваш путь состовляет 10.5км");
            }
            else if (user == 2)
            {
                Console.WriteLine("Вы отправляетесь в Вайтран");
                Console.WriteLine("Ваш путь состовляет 10.7км");
            }
        }

        public void Vaitran()
        {
            Console.WriteLine("Вы можете отправится в эти города:\n 1 Маркат - 57.4км \n 2 Морфал - 90.9км \n 3 Данстар - 120.5км \n 4 Витнтерхолд 150.6км \n 5 Рифтен 145 км");
            int user = Convert.ToInt32(Console.ReadLine());
            if (user == 1)
            {
                Console.WriteLine("Вы отправляетесь в Маркат");
                Console.WriteLine("Ваш путь состовляет 57.4км");
            }
            else if (user == 2)
            {
                Console.WriteLine("Вы отправляетесь в Морфал");
                Console.WriteLine("Ваш путь состовляет 90.9км");
            }
            else if (user == 3)
            {
                Console.WriteLine("Вы отправляетесь в Данстар");
                Console.WriteLine("Ваш путь состовляет 120.5км");
            }
            else if (user == 4)
            {
                Console.WriteLine("Вы отправляетесь в Витнтерхолд");
                Console.WriteLine("Ваш путь состовляет 150.6км");
            }
            else if (user == 5)
            {
                Console.WriteLine("Вы отправляетесь в Рифтен");
                Console.WriteLine("Ваш путь состовляет 145км");
            }
        }

        public void Solitud()
        {
            Console.WriteLine("Вы можете отправится в эти города:\n 1 Маркат 69.5км \n 2 Морфал  170.7км \n");
            int user = Convert.ToInt32(Console.ReadLine());
            if (user == 1)
            {
                Console.WriteLine("Вы отправляетесь в Маркат");
                Console.WriteLine("Ваш путь состовляет 69.5км");
            }
            else if (user == 2)
            {
                Console.WriteLine("Вы отправляетесь в Морфал");
                Console.WriteLine("Ваш путь состовляет 50.5км");
            }
        }

        public void Markat()
        {
            Console.WriteLine("Вы можете отправится в эти города: 1 Солитьюд 69.5км 2 Фолкрит 71.3км");
            int user = Convert.ToInt32(Console.ReadLine());
            if (user == 1)
            {
                Console.WriteLine("Вы отправляетесь в Солитьюд");
                Console.WriteLine("Ваш путь состовляет 69.5км");
            }
            else if (user == 2)
            {
                Console.WriteLine("Вы отправляетесь в Фолкрит");
                Console.WriteLine("Ваш путь состовляет 71.3км");
            }
        }

        public void Morfal()
        {
            Console.WriteLine("Вы можете отправится в эти города: 1 Солитьюд 50.5км 2 Донстар 69.4");
            int user = Convert.ToInt32(Console.ReadLine());
            if (user == 1)
            {
                Console.WriteLine("Вы отправляетесь в Солитьюд");
                Console.WriteLine("Ваш путь состовляет 50.5км");
            }
            else if (user == 2)
            {
                Console.WriteLine("Вы отправляетесь в Вайтран");
                Console.WriteLine("Ваш путь состовляет 69.4км");
            }
        }

        public void Danstar()
        {
            Console.WriteLine("Вы можете отправится в эти города: 1 Морфал 34км 2 Вайтран 43км 3 Винтерхолд 64км ");
            int user = Convert.ToInt32(Console.ReadLine());
            if (user == 1)
            {
                Console.WriteLine("Вы отправляетесь в Вайтран");
                Console.WriteLine("Ваш путь состовляет 34км");
            }
            else if (user == 2)
            {
                Console.WriteLine("Вы отправляетесь в Вайтран");
                Console.WriteLine("Ваш путь состовляет 43км");
            }
            else if (user == 3)
            {
                Console.WriteLine("Вы отправляетесь в Вайтран");
                Console.WriteLine("Ваш путь состовляет 64км");
            }
        }
        public void WinterHold()
        {
            Console.WriteLine("Вы можете отправится в эти города: 1 Вайтран 56.5км 2 Дантстар 60км 3 Виндхельм 70км");
            int user = Convert.ToInt32(Console.ReadLine());
            if (user == 1)
            {
                Console.WriteLine("Вы отправляетесь в Вайтран");
                Console.WriteLine("Ваш путь состовляет 56.5км");
            }
            else if (user == 2)
            {
                Console.WriteLine("Вы отправляетесь в Дантстар");
                Console.WriteLine("Ваш путь состовляет 60км");
            }
            else if (user == 3)
            {
                Console.WriteLine("Вы отправляетесь в Виндхельм");
                Console.WriteLine("Ваш путь состовляет 70км");
            }
        }
        public void WindHelm()
        {
            Console.WriteLine("Вы можете отправится в эти города: 1 Вайтран 10.5км 2 Рифтен 50.3км 3 Винтерхолд 40.1км");
            int user = Convert.ToInt32(Console.ReadLine());
            if (user == 1)
            {
                Console.WriteLine("Вы отправляетесь в Вайтран");
                Console.WriteLine("Ваш путь состовляет 10.5км");
            }
            else if (user == 2)
            {
                Console.WriteLine("Вы отправляетесь в Рифтен ");
                Console.WriteLine("Ваш путь состовляет 50.3км");
            }
            else if (user == 3)
            {
                Console.WriteLine("Вы отправляетесь в Винтерхолд");
                Console.WriteLine("Ваш путь состовляет 40.1км");
            }
        }
        public void Folkrid()
        {
            Console.WriteLine("Вы можете отправится в эти города: 1 Вайтран 14.5км 2 Рифтен 20.3км 3 Маркарт 23.5км");
            int user = Convert.ToInt32(Console.ReadLine());
            if (user == 1)
            {
                Console.WriteLine("Вы отправляетесь в Ривервуд");
                Console.WriteLine("Ваш путь состовляет 14.5км");
            }
            else if (user == 2)
            {

                Console.WriteLine("Вы отправляетесь в Рифтен ");
                Console.WriteLine("Ваш путь состовляет 20.3км");
            }
            else if (user == 3)
            {

                Console.WriteLine("Вы отправляетесь в Маркарт ");
                Console.WriteLine("Ваш путь состовляет 23.5км");
            }
        }
        public void Riften()
        {
            Console.WriteLine("Вы можете отправится в эти города: 1 Вайтран 13.5км 2 Фолкрит 12.7км 3 Вандхельм 22.3км");
            int user = Convert.ToInt32(Console.ReadLine());
            if (user == 1)
            {
                Console.WriteLine("Вы отправляетесь в Вайтран");
                Console.WriteLine("Ваш путь состовляет 13.5км");
            }
            else if (user == 2)
            {
                Console.WriteLine("Вы отправляетесь в Вайтран");
                Console.WriteLine("Ваш путь состовляет 12.7км");
            }
            else if (user == 3)
            {
                Console.WriteLine("Вы отправляетесь в Вайтран");
                Console.WriteLine("Ваш путь состовляет 22.3км");
            }
        }

    }
}
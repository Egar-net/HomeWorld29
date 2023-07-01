using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class State
    {
        private int money = 3000;
        public State() 
        {
            Console.WriteLine("Раса: Каджит");
            Console.WriteLine(
                $"Информация: \n"+
                $"Септимы = {money}\n"
                );
        }
    }
}

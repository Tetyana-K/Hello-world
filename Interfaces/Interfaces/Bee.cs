using System;
using Interfaces.Interface;

namespace Interfaces.Implementation
{
    class Bee : ICanFly, ICanWork  //клас Bee реалізує інтерфейси ICanFly, ICanWork
    {
        static int numBees = 0;
        int id;
       public Bee()
        { 
            id = ++numBees; 
        }
       public void DoFly()
        {
            Console.WriteLine("Bee # {0} is  flying!", id);
        }
        public void DoWork()
        {
            Console.WriteLine("Bee # {0} is gathering honey", id);
 
        }

    }
}

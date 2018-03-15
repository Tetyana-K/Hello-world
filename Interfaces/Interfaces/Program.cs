using System;
using Interfaces.Interface;
using Interfaces.Implementation;
namespace Interfaces
{
    class Program
    {
        static void Line()
        {
            Console.WriteLine("______________________________\n");
        }
        static void Main(string[] args)
        {
            Bee bee = new Bee(), bee1 = new Bee();
            bee.DoFly();
            bee1.DoWork();
            Line();
            
            ICanFly iref  = bee; // обєкт неявно можна привести до інтерфейсу, який він реалізує
            iref.DoFly();
            ICanWork icwref = bee;
            icwref.DoWork();
            Line();

            
            Human serg = new Human("Serg","build houses", "builder", 800);
            Console.WriteLine(serg.ToString());

            serg.Run();
            serg.Salary += 100;
            Console.WriteLine(serg.ToString());

            //serg.DoWork(); // + якщо  DoWork() реалізований неявно
            
            (serg as ICanWork).DoWork();
            (serg as IEmployee).DoWork();
            ICanWork iwref = serg;
            iwref.DoWork();
            Line();

            ICanWork[] workers = { new Bee(), new Human("Oleg", "make cakes", "confectioner"), new Student("Ola") };
            foreach (ICanWork w in workers)
                w.DoWork();
            Line();
           
            Human[] hs = {  new Human("Oleg2", "make cakes2", "confectioner2"), new Student("Ola2") };
           // foreach (var w in hs)
              //  w.DoWork();


        }
    }
}

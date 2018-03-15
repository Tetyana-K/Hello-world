using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_use_interf_from_other_assembly
{
    using Interfaces.Interface;
    class Bird : ICanFly
    {
        public int voice = 100;
        public void DoFly()
        {
            Console.WriteLine("Bird flies!");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            //Bird bird = new Bird();
            //bird.DoFly();
            List<Bird> list = new List<Bird> 
            {
                new Bird{voice = 12},
                new Bird{voice = 10},
                new Bird{voice = 10},
                new Bird{voice = 100},
                new Bird{voice = 55},
                new Bird{voice = 10}


            };

            //var res = list.Find(b => b.voice > 50);
            //Console.WriteLine(res.voice);

            //var res2 = list.Select(e => e.voice).Distinct();
            //foreach(var b in res2)
            //    Console.WriteLine(b);


            //var res3 = list.Select(e => e.voice).Where(e=> e >= 18).Last();
            //Console.WriteLine(res3);

            //var res4 = from e in list
            //           where e.voice >= 12
            //           select e.voice;
            //Console.WriteLine(res4.First());

            var res5 =
                from s in
                    (from e in list select e.voice)
                where s > 10
                select s;
            Console.WriteLine(res5.First());


        }
    }
}

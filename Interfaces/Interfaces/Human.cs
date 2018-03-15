using System;
using System.Text;
using Interfaces.Interface;

namespace Interfaces.Implementation
{
    class Human : ICanWork, ICanRun, IEmployee
    {
        public string Name { get; set; }
        public string Skill { get; set; }
        public string Profession { get; set; }
        private uint _salary;
        static private uint minSalary = 3200;
        public Human(string name = "Noname", string skill = "read", string proffesion = "none", uint salary =5000)
        {
            Name = name;
            Skill = skill;
            Profession = proffesion;
            Salary = salary;
        }
        public void Run()
        {
            Console.WriteLine("Human {0} runs!", Name);

        }
       // конфлікт сигнатур методів  DoWork(), що належать різним інтерфейсам
     /*   virtual public void DoWork() // неявна реалізація методу DoWork() з інтерфейсу ICanWork
        {
            Console.WriteLine("Human {0} can  {1}.", Name, Skill);

        }
        */
        void IEmployee.DoWork()// явна реалізація методу DoWork() з інтерфейсу IEmployee
        {
            Console.WriteLine("Human {0} has profession {1}.", Name, Profession);

        }
     
      void ICanWork.DoWork()// явна реалізація методу DoWork() з інтерфейсу ICanWork
        {
            Console.WriteLine("Human {0}, skill {1}.", Name, Skill);

        }
     
    
        public uint Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value > minSalary)
                {
                    _salary = value;
                }
                else
                    _salary = minSalary;
            }
        }
        public override string ToString()
        {
            return string.Format("Name : {0} Skill :{1} Profession :{2} Salary: {3}", Name, Skill, Profession, Salary);
        }
    }
}

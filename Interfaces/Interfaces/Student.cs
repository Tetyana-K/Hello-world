using System;
using System.Collections.Generic;
using System.Linq;
using Interfaces.Interface;

namespace Interfaces.Implementation
{
    //class Student : Human //1 спосіб
    //{
    //    public Student(string name = "Noname") : base(name, "learning", "student", 910) { }

    //    override public void DoWork() // хочемо перевизначити неявно реалізований метод DoWork() у класі Student(у Human відмічаємо його як virtual!!!)
    //    {
    //        Console.WriteLine("Student: {0} Skill: {1} Stipend: {2}.", Name, Skill, Salary);

    //    }
    //}

    class Student : Human, ICanWork //1 спосіб
    {
        public Student(string name = "Noname") : base(name, "learning", "student", 910) { }

        //new
         public void DoWork() // хочемо перекрити метод DoWork() у класі Student, тому повторно реалізуємо метод
        {
            Console.WriteLine("Student: {0} Skill: {1} Stipend: {2}.", Name, Skill, Salary);

        }
    }
}

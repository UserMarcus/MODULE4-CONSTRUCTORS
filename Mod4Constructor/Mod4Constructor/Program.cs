using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person("Angel" , "Locsin");

            person1.BirthYear = 30;

            Console.WriteLine("Hello" + person1);
            Console.WriteLine("You are " + person1.BirthYear + "years old");
            Console.ReadKey();
        }
    }
}

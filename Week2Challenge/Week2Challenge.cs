using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Challenge
{
    public class Week2Challenge
    {
        static void Main(string[] args)
        {
            Greeter greeter = new Greeter();
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            greeter.SayHello();
            string fareWell = greeter.SayFarewell(name);
            Console.WriteLine(fareWell);

            DateTime timeOfDay = DateTime.Now;
            greeter.TimelyGreeting(timeOfDay);
            Console.ReadLine();
        }
    }
}

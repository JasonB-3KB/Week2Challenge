using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Challenge
{
    class Greeter
    {
        public void SayHello()
        {
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
        }

        public string SayFarewell(string name)
        {
            string farewell = ($"Goodbye {name}");
            return farewell;
        }

        public void TimelyGreeting(DateTime timeOfDay)
        {
            if(timeOfDay.Hour < 11)
            {
                Console.WriteLine("Good Morning");
            }
            else if(timeOfDay.Hour >=11 && timeOfDay.Hour < 15)
            {
                Console.WriteLine("Good Afternoon");
            }
            else if(timeOfDay.Hour >=15 && timeOfDay.Hour < 22)
            {
                Console.WriteLine("Good Evening");
            }
            else 
            {
                Console.WriteLine("Good Night");
            }
        }
    }
}

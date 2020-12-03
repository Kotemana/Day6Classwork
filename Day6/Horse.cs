using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    public class Horse : Animal
    {
        public int HallopSpeed { get; set; }

        public override void SayHello()
        {
            Console.WriteLine("Hello, I'm da horse, and I'm amazing");
        }

        public void Run()
        {
            Console.WriteLine($"Horse ran {HallopSpeed} kilometers");
        }
    }

    public class SuperHorse : Horse
    {

    }
}

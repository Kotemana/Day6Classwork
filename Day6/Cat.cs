using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    public class Cat : Animal
    {
        public int WhiskersCount { get; set; }

        public override void SayHello()
        {
            Console.WriteLine("This is cat, and it greets you with Meeeeow");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    public class Animal
    {
        public string Name { get; set; }

        public virtual void SayHello()
        {
            Console.WriteLine("Animal says hello on its language");
        }
    }
}

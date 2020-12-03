using System;
using System.Collections.Generic;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("♥♦♣♠");
            var cat = new Cat();
            var horse = new Horse() { HallopSpeed = 20};
            List<Animal> animals = new List<Animal>();
            animals.Add(cat);
            animals.Add(horse);
            var newHorse = new HorseFull()
            {
                HallopSpeed = 30,
                Name = "Bobik",
                HorseShoes = new List<HorseShoe>()
                {
                    new HorseShoe(){DetioratedPercentage = 53, Leg = "Front left", Material = "Stell 13 ХГТ"},
                    new HorseShoe(){DetioratedPercentage = 60, Leg = "Front right", Material = "Bronze"},
                    new HorseShoe(){DetioratedPercentage = 70, Leg = "Rear left", Material = "Gold"},
                    new HorseShoe(){DetioratedPercentage = 52, Leg = "Rear right", Material = "Silver"},
                }
            };
            animals.Add(newHorse);
            foreach (var animal in animals)
            {
                animal.SayHello();

                if(animal is Horse horsy)
                {
                    horsy.Run();
                    if (horsy is HorseFull horseFull)
                    {
                        horseFull.ReportDetiorated();
                    }
                }

            }
           
        }

        enum Suits
        {
            Hearts,
            Spades,
            Diamonds,
            Clubs
        }

        enum Values
        {
            Two,
            Three,
            Jack,
            Queen,
            King,
            Ace
        }
    }
}

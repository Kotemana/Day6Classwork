using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    public class HorseFull : Horse
    {
        public List<HorseShoe> HorseShoes { get; set; }
        public void ReportDetiorated()
        {
            Console.WriteLine($"Checking {Name} horseshoes");
            foreach (var shoe in HorseShoes)
            {
                if(shoe.DetioratedPercentage > 50)
                {
                    
                    Console.WriteLine($"Horseshoe on {shoe.Leg} is {shoe.DetioratedPercentage} detiorated. It is made of {shoe.Material}");
                }    
            }
        }
    }

    public class HorseShoe
    {
        public string Material { get; set; }
        public int DetioratedPercentage { get; set; }

        public string Leg { get; set; }
    }
}

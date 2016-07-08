using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Giant Planet");
            Console.WriteLine("+++++++++++++++++++");
            GiantPlanet giantPlanet = new GiantPlanet("Ganymede", 3270526210, 4213678010, "Poop");
            Console.WriteLine(giantPlanet.ToString());



        }

        public void waitForAnyKey()
        {
            
        }
    }
}

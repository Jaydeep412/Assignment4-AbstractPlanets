using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* Name: Jaydeep Lakhwani
* Date: July 24,2017
* Description: This is the driver program class.
* Version: 0.2 -Created the terrestrialPlanet object
*/

namespace Assignment4_AbstractPlanets
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("Jupitor",140000,Convert.ToDouble(1.898 * Math.Pow(10,27) ),"Gas");

            
            Console.WriteLine(giantPlanet.ToString());

            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Earth",13000, Convert.ToDouble(5.972 * Math.Pow(10, 24)),true);


            Console.WriteLine(terrestrialPlanet.ToString());

            Console.ReadKey();
        }
    }
}

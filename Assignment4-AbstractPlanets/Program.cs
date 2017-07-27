using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* Name: Jaydeep Lakhwani
* Date: July 24,2017
* Description: This is the driver program class.
* Version: 0.1 -Created the giantPlanet object
*/

namespace Assignment4_AbstractPlanets
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("Jupitor",140000,317.8,"Gas");

            Console.WriteLine(giantPlanet.ToString());

            
        }
    }
}

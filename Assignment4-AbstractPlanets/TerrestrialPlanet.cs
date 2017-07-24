using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* Name: Jaydeep Lakhwani
* Date: July 24,2017
* Description: This is the TerrestrialPlanet Class that extends the Planet abstract class.
* Version: 0.1 - Created the TerrestrialPlanet class.
*/

namespace Assignment4_AbstractPlanets
{
    class TerrestrialPlanet : Planet
    {
        public TerrestrialPlanet(string name, double diameter, double mass) 
            : base(name, diameter, mass)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* Name: Jaydeep Lakhwani
* Date: July 24,2017
* Description: This is the GiantPlanet Class that extends the Planet abstract class.
* Version: 0.1 - Created the GiantPlanet Class.
*/

namespace Assignment4_AbstractPlanets
{
    class GiantPlanet : Planet
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS)
  		private string _name;

        public GiantPlanet(string name, double diameter, double mass) 
                : base(name, diameter, mass)
        {

        }
    }
}

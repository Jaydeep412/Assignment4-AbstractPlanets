using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* Name: Jaydeep Lakhwani
* Date: July 24,2017
* Description: This is the GiantPlanet Class that extends the Planet abstract class.
* Version: 0.2 - Added Fields, Constructor and HasMoons and HasRings method.
*/

namespace Assignment4_AbstractPlanets
{
    class GiantPlanet : Planet
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS)
  		private string _type;

        
        //CONSTRUCTOR

        /// <summary>
        /// This is the main constructor for the GiantPlanet class.
        /// It takes four parameters - name(string) - diameter(double) - mass(double) - type(string).
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="type"></param>
        public GiantPlanet(string name, double diameter, double mass,string type) 
                : base(name, diameter, mass)
        {
            this._type = type;
        }

        //PUBLIC METHODS
        public bool HasMoons()
        {
            if(MoonCount >0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasRings()
        {
            if (RingCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

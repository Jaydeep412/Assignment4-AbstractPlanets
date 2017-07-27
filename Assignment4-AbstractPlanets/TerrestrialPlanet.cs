using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* Name: Jaydeep Lakhwani
* Date: July 24,2017
* Description: This is the TerrestrialPlanet Class that extends the Planet abstract class.
* and Implements IHasMoons and IHabitable interfaces.
* Version: 0.3 -Implemented IHasMoons adn IHabitable interfaces.
*/

namespace Assignment4_AbstractPlanets
{
    class TerrestrialPlanet : Planet , IHasMoons,IHabitable
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS)
        private bool _oxygen;
      
        //PUBLIC PROPERTIES
   


        //CONSTRUCTOR

        /// <summary>
        /// This is the main constructor for the GiantPlanet class.
        /// It takes four parameters - name(string) - diameter(double) - mass(double) - oxygen(bool).
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="oxygen"></param>
        public TerrestrialPlanet(string name, double diameter, double mass,bool oxygen) 
            : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }


        //PUBLIC METHODS
        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Habitable()
        {
            return _oxygen;                 
        }
    }
}

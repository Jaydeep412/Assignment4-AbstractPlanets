using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* Name: Jaydeep Lakhwani
* Date: July 24,2017
* Description: This is the Abstract Planet Class
* Version: 0.2 - Added Constructor method and overriden ToString method.
*/

namespace Assignment4_AbstractPlanets
{
    /// <summary>
    /// This is Planet abstract class
    /// </summary>
    public abstract class Planet
    {

        // PRIVATE INSTANCE VARIABLES (FIELDS)
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;


        // PUBLIC PROPERTIES

        public double Diameter
        {
            get
            {
                return this._diameter;
            }
        }

        public double Mass
        {
            get
            {
                return this._mass;
            }
        }

        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }
        }

        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                this._orbitalPeriod = value;
            }
        }

        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }

        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }

            set
            {
                this._rotationPeriod = value;
            }
        }
        
        /// <summary>
 		/// This is the main constructor for the Planet class.
 		/// It takes three parameter - name(string) - diameter(double) - mass(double)
 		/// </summary>
 		/// <param name="name"></param>
 
 		//CONSTRUCTOR ----------------------------------------------------------------
 		public Planet(string name,double diameter, double mass)
 		{
            this._name = name;
            this._diameter= diameter;
            this._mass = mass;
 		}

        //PUBLIC OVERRIDEN METHODS

        /// <summary>
        /// Overridden the built-in ToString method
        /// </summary>
        /// <returns>
        /// string 
        /// </returns>
        public override string ToString()
        {
            string outputString = "";

            outputString = "Name" + Name +"\n" + "Diameter" + Diameter + "\n" + "Mass" + Mass + "\n";

            return outputString;

        }
    }
}

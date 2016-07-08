using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_S2016_Assignment3
{
    public class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        // PRIVATE INSTANCE VARIABLES 
        private bool _oxygen;

        // PUBLIC PROPERTIES 
        public bool Oxygen 
        {
            get 
            {
                return this._oxygen;
            }
            set 
            {
                this._oxygen = value;
            }
        }

        public bool Habitable()
        {
            if(Oxygen == true) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

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

        // CONSTRUCTORS 

        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) 
        {
            this._oxygen = oxygen;
        }
    }
}

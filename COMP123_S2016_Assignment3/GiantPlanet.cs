using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_S2016_Assignment3
{
    public class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        // PRIVATE INSTANCE VARIABLES 
        private string _type;

        // PUBLIC PROPERTIES 

        public string Type 
        {
            get 
            {
                return this._type;
            }
            set
            {
                this._type = value;
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

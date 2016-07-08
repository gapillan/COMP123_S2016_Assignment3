using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_S2016_Assignment3
{
    public class TerrestrialPlanet : Planet, IHasMoons, IHasRings
    {
        private bool _oxygen;

        public bool Habitable()
        {
            throw new System.NotImplementedException();
        }

        public bool HasMoons()
        {
            throw new System.NotImplementedException();
        }
    }
}

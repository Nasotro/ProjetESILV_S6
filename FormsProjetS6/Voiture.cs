using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsProjetS6
{
    internal class Voiture : Vehicule
    {
        int nbPassagers;
        public Voiture(float pKm, float pLoc, int nbPassagers) : base(pKm, pLoc)
        {
            this.nbPassagers = nbPassagers;
        }
        public int NbPassagers { get { return nbPassagers; } set { nbPassagers = value; } }

        public override string ToString()
        {
            return $"Nombre de passagers: {NbPassagers}, {base.ToString()}";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsProjetS6
{
    internal class Camionnette : Vehicule
    {

        /// <summary>
        /// Champ spécifique à la classe Camionnette
        /// </summary>
        string usage;

        /// <summary>
        /// Constructeur de la classe Camionnette
        /// </summary>
        /// <param name="pKm"></param>
        /// <param name="pLoc"></param>
        /// <param name="usage"></param>
        public Camionnette(float pKm, float pLoc, string usage) : base(pKm, pLoc)
        {
            this.usage = usage;
        }

        /// <summary>
        /// Propriété permettant d'accéder et de modifier l'usage de la camionnette
        /// </summary>
        public string Usage
        {
            get { return usage; }
            set { usage = value; }
        }

        /// <summary>
        /// Méthode pour obtenir une représentation textuelle de la camionnette
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Usage: {Usage}, {base.ToString()}";
        }

    }

}

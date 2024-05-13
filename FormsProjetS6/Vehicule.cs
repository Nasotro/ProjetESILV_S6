using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsProjetS6
{
    internal abstract class Vehicule
    {
        float prixKm;
        float prixLoc;
        public int UsageCount { get; set; } = 0;
        public Chauffeur Chauffeur { get; set; } = null;

        public Vehicule(float prixKm, float prixLoc) 
        {
            this.prixLoc = prixLoc;
            this.prixKm = prixKm;
            Chauffeur = null;
        }
        public float PrixKm { get {  return prixKm; } set {  prixKm = value; } }
        public float PrixLoc { get {  return prixLoc; } set { prixLoc = value; } }
        public override string ToString()
        {
            return $"Prix par kilomètre: {PrixKm}, Prix de location: {PrixLoc}";
        }
    }


}

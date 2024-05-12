using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsProjetS6
{
    internal class PoidsLourd : Vehicule
    {
        float volume;
        string matiere;
        // Le camion-citerne : liquides / gazs
        // Le camion benne : sable/terre/graviers
        // Le camion frigorifique : marchandises périssables
        public PoidsLourd(float pKm, float pLoc, float volume, string matiere) : base(pKm, pLoc)
        {
            Volume = volume;
            Matiere = matiere;
        }

        public float Volume { get { return volume; } set {  volume = value; } }
        public string Matiere { get {  return matiere; } set {  matiere = value; } }
        public override string ToString()
        {
            return $"Volume: {Volume}, Matière: {Matiere}, {base.ToString()}";
        }

    }
}

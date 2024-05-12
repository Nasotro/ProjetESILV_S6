using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsProjetS6
{
    internal class Camionnette : Vehicule
    {
        string usage;

        public Camionnette(float pKm, float pLoc, string usage) : base(pKm, pLoc)
        {
            this.usage = usage;
        }

        public string Usage
        {
            get { return usage; }
            set { usage = value; }
        }
        public override string ToString()
        {
            return $"Usage: {Usage}, {base.ToString()}";
        }

    }

}

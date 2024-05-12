using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsProjetS6
{
    internal class Salarie : Personne
    {
        private DateTime dateEntree;
        private string poste;
        private int salaire;

        public List<Salarie> suivants;

        public Salarie(string numeroSS, string nom, string prenom, DateTime dateDeNaissance, Adresse adressePostale, string adresseMail, string telephone, DateTime dateEntree, string poste, int salaire)
            : base(numeroSS, nom, prenom, dateDeNaissance, adressePostale, adresseMail, telephone)
        {
            this.dateEntree = dateEntree;
            this.poste = poste;
            this.salaire = salaire;

            suivants = new List<Salarie>();
        }

        public void addSons(List<Salarie> salaries)
        {
            salaries.AddRange(salaries);
        }

        public DateTime DateEntree
        {
            get { return dateEntree; }
        }

        public string Poste
        {
            get { return poste; }
            set { poste = value; }
        }

        public int Salaire
        {
            get { return salaire; }
            set { salaire = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Salarie salarie = (Salarie)obj;
            return noms.Equals(salarie.noms);
        }

        public override string ToString()
        {
            return base.ToString() + $"\nDate d'entrée dans la société : {dateEntree:dd/MM/yyyy}\nPoste : {poste}\nSalaire : {salaire:C2}";
        }
    }
}

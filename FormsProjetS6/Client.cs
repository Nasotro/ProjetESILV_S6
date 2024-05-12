using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsProjetS6
{
    internal class Client : Personne
    {
        private int nbCommandes;
        private int achatCumule;

        public List<Commande> Commandes { get; set; }

        public Client(string numeroSS, string nom, string prenom, DateTime dateDeNaissance, Adresse adressePostale, string adresseMail, string telephone, int nb_commandes = 0, int achat_cumule = 0)
            : base(numeroSS, nom, prenom, dateDeNaissance, adressePostale, adresseMail, telephone)
        {
            nbCommandes = nb_commandes;
            achatCumule = achat_cumule;
            Commandes = new List<Commande>();
        }

        public int AchatCumule
        {
            get { return (int)Commandes.Sum(c => c.Prix); }
            set { achatCumule = value; }
        }
        public int NbCommandes
        {
            get { return Commandes.Count; }
            set { nbCommandes = value; }
        }

    }

}

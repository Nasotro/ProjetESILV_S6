using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsProjetS6
{
    internal class Chauffeur : Salarie
    {
        int tarifHoraire;
        public Vehicule Vehicule { get; set; }
        public Chauffeur(string numeroSS, string nom, string prenom, DateTime dateDeNaissance, Adresse adressePostale, string adresseMail, string telephone, DateTime dateEntree, int salaire, int TarifHoraire, Vehicule v)
            : base(numeroSS, nom, prenom, dateDeNaissance, adressePostale, adresseMail, telephone, dateEntree, "Chauffeur", salaire)
        {
            tarifHoraire = TarifHoraire;
            this.Vehicule = v;
            v.Chauffeur = this;
        }

        public Chauffeur(Personne p, int TarifHoraire, Vehicule v) : base(p.NumeroSS, p.Nom,p.Prenom,p.DateDeNaissance,p.Adresse, p.AdresseMail, p.Telephone, DateTime.Now, "Chauffeur", 0) { tarifHoraire = TarifHoraire; this.Vehicule = v; v.Chauffeur = this; }
        public Chauffeur(Salarie p, int TarifHoraire, Vehicule v) : base(p.NumeroSS, p.Nom,p.Prenom,p.DateDeNaissance,p.Adresse, p.AdresseMail, p.Telephone, p.DateEntree, "Chauffeur", p.Salaire) { tarifHoraire = TarifHoraire; this.Vehicule = v; v.Chauffeur = this; }
        
        public int TarifHoraire { get { return tarifHoraire; } }

        public bool estDispo(DateTime date)
        {
            //System.Windows.Forms.MessageBox.Show($"teste :\n{this}");
            return !DataBase.commandes.Any(x=>x.Date.Date == date.Date && x.Chauffeur.noms == noms);
        }
        public override string ToString()
        {
            return base.ToString() + $"\nvehicule : {Vehicule}";
        }
    }
}

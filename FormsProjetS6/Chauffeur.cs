using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsProjetS6
{
    internal class Chauffeur : Salarie
    {
        /// <summary>
        /// Champ spécifique à la classe Chauffeur
        /// </summary>
        int tarifHoraire;

        /// <summary>
        /// Propriétés de la classe Chauffeur
        /// </summary>
        public int nombreCommandes { get; set; } = 0;
        public Vehicule Vehicule { get; set; }

        /// <summary>
        /// Constructeur de la classe Chauffeur
        /// </summary>
        /// <param name="numeroSS"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="dateDeNaissance"></param>
        /// <param name="adressePostale"></param>
        /// <param name="adresseMail"></param>
        /// <param name="telephone"></param>
        /// <param name="dateEntree"></param>
        /// <param name="salaire"></param>
        /// <param name="TarifHoraire"></param>
        /// <param name="v"></param>
        public Chauffeur(string numeroSS, string nom, string prenom, DateTime dateDeNaissance, Adresse adressePostale, string adresseMail, string telephone, DateTime dateEntree, int salaire, int TarifHoraire, Vehicule v)
            : base(numeroSS, nom, prenom, dateDeNaissance, adressePostale, adresseMail, telephone, dateEntree, "Chauffeur", salaire)
        {
            tarifHoraire = TarifHoraire;
            this.Vehicule = v;
            v.Chauffeur = this;
        }

        /// <summary>
        /// Constructeur prenant une personne en paramètre
        /// </summary>
        /// <param name="p"></param>
        /// <param name="TarifHoraire"></param>
        /// <param name="v"></param>
        public Chauffeur(Personne p, int TarifHoraire, Vehicule v) : base(p.NumeroSS, p.Nom,p.Prenom,p.DateDeNaissance,p.Adresse, p.AdresseMail, p.Telephone, DateTime.Now, "Chauffeur", 0) { tarifHoraire = TarifHoraire; this.Vehicule = v; v.Chauffeur = this; }

        /// <summary>
        /// Constructeur prenant un salarié en paramètre
        /// </summary>
        /// <param name="p"></param>
        /// <param name="TarifHoraire"></param>
        /// <param name="v"></param>
        public Chauffeur(Salarie p, int TarifHoraire, Vehicule v) : base(p.NumeroSS, p.Nom,p.Prenom,p.DateDeNaissance,p.Adresse, p.AdresseMail, p.Telephone, p.DateEntree, "Chauffeur", p.Salaire) { tarifHoraire = TarifHoraire; this.Vehicule = v; v.Chauffeur = this; }

        /// <summary>
        /// Propriété permettant d'accéder au tarif horaire du chauffeur
        /// </summary>
        public int TarifHoraire { get { return tarifHoraire; } }

        /// <summary>
        /// Méthode pour vérifier si le chauffeur est disponible à une certaine date
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public bool estDispo(DateTime date)
        {
            //System.Windows.Forms.MessageBox.Show($"teste :\n{this}");
            return !DataBase.commandes.Any(x=>x.Date.Date == date.Date && x.Chauffeur.noms == noms);
        }

        /// <summary>
        /// Méthode pour obtenir une représentation textuelle du chauffeur
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + $"\nvehicule : {Vehicule}";
        }
    }
}

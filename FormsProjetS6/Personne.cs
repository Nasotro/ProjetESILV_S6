using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsProjetS6
{
    internal class Personne
    {
        protected string numeroSS;
        protected string nom;
        protected string prenom;
        protected DateTime dateDeNaissance;
        protected string mail;
        protected string telephone;
        protected Adresse adresse;

        public Personne(string numeroSS, string nom, string prenom, DateTime dateDeNaissance, Adresse adressePostale, string adresseMail, string telephone)
        {
            this.numeroSS = numeroSS;
            this.nom = nom;
            this.prenom = prenom;
            this.dateDeNaissance = dateDeNaissance;
            this.adresse = adressePostale;
            mail = adresseMail;
            this.telephone = telephone;
        }

        public string NumeroSS
        {
            get { return numeroSS; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public DateTime DateDeNaissance
        {
            get { return dateDeNaissance; }
        }

        //[DisplayName("Adresse")]
        public Adresse Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        public string AdresseMail
        {
            get { return mail; }
            set { mail = value; }
        }

        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }
        public override string ToString()
        {
            return $"{nom} {prenom}\nNuméro de sécurité sociale : {numeroSS}\nDate de naissance : {dateDeNaissance:dd/MM/yyyy}\nAdresse postale : {adresse}\nAdresse e-mail : {mail}\nTéléphone : {telephone}";
        }

        public string noms { get { return prenom + " " + nom; } }
    }

}

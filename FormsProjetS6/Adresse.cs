using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProjetS6
{
    internal class Adresse : IComparable
    {
        /// <summary>
        /// Champs de la classe Adresse
        /// </summary>
        string ville;
        string numero;
        string rue;
        string pays;
        string full_adresse;

        /// <summary>
        /// Constructeur prenant une adresse complète en paramètre
        /// </summary>
        /// <param name="full_adresse"></param>
        public Adresse(string full_adresse)
        {
            this.full_adresse = full_adresse;
        }

        /// <summary>
        /// Constructeur prenant la ville et le pays en paramètres
        /// </summary>
        /// <param name="ville"></param>
        /// <param name="pays"></param>
        public Adresse(string ville, string pays)
        {
            this.ville = ville;
            this.pays = pays;
            this.full_adresse = ville+", "+pays;
        }

        /// <summary>
        /// Constructeur prenant la ville, le numéro, la rue et le pays en paramètres
        /// </summary>
        /// <param name="ville"></param>
        /// <param name="numero"></param>
        /// <param name="rue"></param>
        /// <param name="pays"></param>
        public Adresse(string ville, string numero, string rue, string pays)
        {
            this.ville = ville;
            this.numero = numero;
            this.rue = rue;
            this.pays = pays;
            this.full_adresse = String.Join(" ", numero, rue, ville, pays);
            full_adresse = ville + ", " + numero + " " + rue + ", " + pays;
        }

        /// <summary>
        /// Propriétés de la classe Adresse
        /// </summary>
        public string Ville { get {  return ville; } set { ville = value; } }
        public string Numero { get {  return numero; } set { numero = value; } }
        public string Rue { get {  return rue; } set { rue = value; } }
        public string Pays { get {  return pays; } set { pays = value; } }
        public string Full_adresse { get {  return full_adresse; } set {  full_adresse = value; } }


        /// <summary>
        /// Méthode pour afficher l'adresse complète
        /// </summary>
        /// <returns></returns>
        public override string ToString() { return full_adresse; }


        /// <summary>
        /// Méthode pour comparer deux adresses
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(object other)
        {
            if (other == null)
                return 1;
            if(!(other is Adresse))
                return 0;
            other = (Adresse)other;
            int comparisonResult = string.Compare(Pays, (other as Adresse).Pays);
            if (comparisonResult != 0)
                return comparisonResult;

            comparisonResult = string.Compare(Ville, (other as Adresse).Ville);
            if (comparisonResult != 0)
                return comparisonResult;

            comparisonResult = string.Compare(Rue, (other as Adresse).Rue);
            if (comparisonResult != 0)
                return comparisonResult;

            comparisonResult = string.Compare(Numero, (other as Adresse).Numero);
            return comparisonResult;
        }
    }
}

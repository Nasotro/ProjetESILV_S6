using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FormsProjetS6;
using System.Collections.Generic;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDijkstra()
        {
            DataBase.Generate();
            // Création des villes pour le test
            Commande.Ville villeA = new Commande.Ville("Ville A");
            Commande.Ville villeB = new Commande.Ville("Ville B");
            Commande.Ville villeC = new Commande.Ville("Ville C");
            Commande.Ville villeD = new Commande.Ville("Ville D");

            // Définition des distances entre les villes
            villeA.VoisinsDist.Add(villeB, 10);
            villeA.VoisinsDist.Add(villeC, 15);
            villeB.VoisinsDist.Add(villeD, 12);
            villeC.VoisinsDist.Add(villeD, 5);

            // Création de la liste de villes
            List<Commande.Ville> villes = new List<Commande.Ville>() { villeA, villeB, villeC, villeD };

            // Appel de la méthode Dijkstra pour calculer les chemins les plus courts
            Commande commande = new Commande(null, null, null, DateTime.Now, null);
            commande.Dijkstra(villeA, villes);

            // Vérification des chemins les plus courts calculés pour chaque ville
            Assert.AreEqual(0, villeA.CheminLePlusCourt); // Ville de départ, donc la distance est de 0
            Assert.AreEqual(10, villeB.CheminLePlusCourt); // Chemin le plus court entre Ville A et Ville B
            Assert.AreEqual(15, villeC.CheminLePlusCourt); // Chemin le plus court entre Ville A et Ville C
            Assert.AreEqual(20, villeD.CheminLePlusCourt); // Chemin le plus court entre Ville A et Ville D
        }
    }
}

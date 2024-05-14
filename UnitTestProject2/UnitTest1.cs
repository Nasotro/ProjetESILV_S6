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
        public void GetStatistics_ReturnsErrorMessage_WhenListsAreNullOrEmpty()
        {
            // Arrange
            // Initialisation des listes à null ou vides
            DataBase.commandes = null;
            DataBase.clients = new List<Client>();
            DataBase.salaries = new List<Salarie>();
            DataBase.vehicules = new List<Vehicule>();
            DataBase.Chauffeurs = new List<Chauffeur>();

            // Act
            // Appel de la méthode GetStatistics()
            string result = DataBase.GetStatistics();

            // Assert
            // Vérification si le résultat correspond au message d'erreur attendu
            Assert.AreEqual("Une ou plusieurs listes sont nulles ou vides. Impossible de calculer les statistiques.", result);
        }

        [TestMethod]
        public void TestAddCommande()
        {
            // Arrange
            Commande commande = new Commande();
            Client cli = new Client();

            // Act
            DataBase.AddCommande(commande, cli);

            // Assert
            Assert.IsTrue(DataBase.commandes.Contains(commande));
            Assert.IsTrue(cli.Commandes.Contains(commande));
            Assert.AreEqual(1, commande.Chauffeur.nombreCommandes);
        }

        [TestMethod]
        public void TestRemoveCommande()
        {
            // Arrange
            Commande commande = new Commande();
            commande.Chauffeur = new Chauffeur();
            Client cli = new Client();
            cli.Commandes.Add(commande);
            DataBase.commandes.Add(commande);

            // Act
            DataBase.RemoveCommande(commande);

            // Assert
            Assert.IsFalse(DataBase.commandes.Contains(commande));
            Assert.IsFalse(cli.Commandes.Contains(commande));
            Assert.AreEqual(0, commande.Chauffeur.nombreCommandes);
        }

        [TestMethod]
        public void TestAddClient()
        {
            // Arrange
            Client client = new Client();

            // Act
            DataBase.AddClient(client);

            // Assert
            Assert.IsTrue(DataBase.clients.Contains(client));
        }

        [TestMethod]
        public void TestRemoveClient()
        {
            // Arrange
            Client client = new Client();
            DataBase.clients.Add(client);

            // Act
            DataBase.RemoveClient(client);

            // Assert
            Assert.IsFalse(DataBase.clients.Contains(client));
        }

        [TestMethod]
        public void TestAddSalarie()
        {
            // Arrange
            Salarie salarie = new Salarie();
            string nom_boss = "Nom du boss";

            // Act
            bool result = DataBase.AddSalarie(salarie, nom_boss);

            // Assert
            Assert.IsTrue(DataBase.salaries.Contains(salarie));
            Assert.IsTrue(result); // Check if the salarie was added to the organigramme correctly
        }

        [TestMethod]
        public void TestRemoveSalarie()
        {
            // Arrange
            Salarie salarie = new Salarie();
            Salarie boss = new Salarie();
            boss.suivants.Add(salarie);
            DataBase.salaries.Add(salarie);
            DataBase.salaries.Add(boss);

            // Act
            DataBase.RemoveSalarie(salarie);

            // Assert
            Assert.IsFalse(DataBase.salaries.Contains(salarie));
            Assert.IsFalse(boss.suivants.Contains(salarie)); // Check if the salarie was removed from the organigramme correctly
        }

        [TestMethod]
        public void TestAddVehicule()
        {
            // Arrange
            Vehicule vehicule = new Vehicule();

            // Act
            DataBase.AddVehicule(vehicule);

            // Assert
            Assert.IsTrue(DataBase.vehicules.Contains(vehicule));
        }

        [TestMethod]
        public void TestRemoveVehicule()
        {
            // Arrange
            Vehicule vehicule = new Vehicule();
            DataBase.vehicules.Add(vehicule);

            // Act
            DataBase.RemoveVehicule(vehicule);

            // Assert
            Assert.IsFalse(DataBase.vehicules.Contains(vehicule));
        }

    }
}

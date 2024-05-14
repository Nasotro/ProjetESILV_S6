using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace FormsProjetS6
{
    public interface IStatisticable
    {
        void GetStatistics();
    }

    internal static class DataBase
    {
        /// <summary>
        /// Listes pour stocker les données
        /// </summary>
        public static List<Commande> commandes = new List<Commande>();
        public static List<Client> clients = new List<Client>();
        public static List<Salarie> salaries = new List<Salarie>();
        public static List<Vehicule> vehicules = new List<Vehicule>();
        public static List<Chauffeur> Chauffeurs = new List<Chauffeur>(); 
        public static List<string> Villes = new List<string>
        {
            "Paris",
            "Rouen",
            "Lyon",
            "Angers",
            "La Rochelle",
            "Bordeaux",
            "Biarritz",
            "Toulouse",
            "Pau",
            "Nimes",
            "Montpellier",
            "Marseille",
            "Avignon",
            "Monaco"
        };

        /// <summary>
        /// Organigramme de l'entreprise
        /// </summary>
        public static Salarie Organigramme;

        /// <summary>
        /// Méthode pour générer des données aléatoires
        /// </summary>
        public static void Generate()
        {
            Random rnd = new Random();

            List<Client> clientsList = new List<Client>
            {
                new Client("12345678901234", "Dupont", "Jean", new DateTime(1980, 5, 15), new Adresse("Paris", "123", "Rue de la République", "France"), "jean.dupont@example.com", "06 12 34 56 78"),
                new Client("23456789012345", "Martin", "Pierre", new DateTime(1995, 11, 22), new Adresse("Paris", "45", "Avenue des Champs-Élysées", "France"), "pierre.martin@example.com", "07 23 45 67 89"),
                new Client("34567890123456", "Durand", "Marie", new DateTime(1977, 3, 8), new Adresse("Paris", "78", "Rue de la Convention", "France"), "marie.durand@example.com", "06 34 56 78 90"),
                new Client("45678901234567", "Bertrand", "François", new DateTime(1968, 2, 14), new Adresse("Paris", "9", "Place de la Bastille", "France"), "francois.bertrand@example.com", "07 45 67 89 01"),
                new Client("56789012345678", "Lefebvre", "Sophie", new DateTime(2000, 8, 28), new Adresse("Paris", "321", "Boulevard Voltaire", "France"), "sophie.lefebvre@example.com", "06 56 78 90 12"),
                new Client("67890123456789", "Rousseau", "Luc", new DateTime(1985, 12, 5), new Adresse("Paris", "65", "Rue de Rivoli", "France"), "luc.rousseau@example.com", "07 67 89 01 23"),
                new Client("78901234567890", "Girard", "Émilie", new DateTime(1990, 10, 10), new Adresse("Paris", "24", "Avenue de la Grande Armée", "France"), "emilie.girard@example.com", "06 78 90 12 34"),
                new Client("89012345678901", "Moreau", "Alexandre", new DateTime(1975, 1, 25), new Adresse("Paris", "11 Bis", "Rue de la Roquette", "France"), "alexandre.moreau@example.com", "07 89 01 23 45" ),
                new Client("90123456789012", "Petit", "Laura", new DateTime(2002, 7, 4), new Adresse("Paris", "133", "Boulevard Saint-Germain", "France"), "laura.petit@example.com", "06 90 12 34 56"),
                new Client("01234567890123", "Lambert", "Benjamin", new DateTime(1988, 9, 18), new Adresse("Paris", "57", "Rue du Faubourg Saint-Antoine", "France"), "benjamin.lambert@example.com", "07 01 23 45 67"),
                new Client("11121314151617", "Richard", "Marc", new DateTime(1984, 4, 20), new Adresse("Paris", "10", "Rue de la Paix", "France"), "marc.richard@example.com", "06 20 30 40 50"),
                new Client("21222324252627", "Bernard", "Anne", new DateTime(1993, 9, 1), new Adresse("Paris", "3", "Rue du Temple", "France"), "anne.bernard@example.com", "07 10 20 30 40"),
                new Client("31323334353637", "Thomas", "David", new DateTime(1989, 12, 12), new Adresse("Paris", "15", "Avenue Montaigne", "France"), "david.thomas@example.com", "06 30 40 50 60"),
                new Client("41424344454647", "Muller", "Sandra", new DateTime(1974, 3, 18), new Adresse("Paris", "7", "Rue de la Cité", "France"), "sandra.muller@example.com", "07 40 50 60 70"),
                new Client("51525354555657", "Fournier", "Julien", new DateTime(1991, 7, 24), new Adresse("Paris", "29", "Boulevard Saint-Michel", "France"), "julien.fournier@example.com", "06 50 60 70 80"),
                new Client("61626364656667", "Lopez", "Isabelle", new DateTime(1986, 11, 3), new Adresse("Paris", "53", "Avenue des Gobelins", "France"), "isabelle.lopez@example.com", "07 60 70 80 90"),
                new Client("71727374757677", "Dubois", "Olivier", new DateTime(1978, 2, 26), new Adresse("Paris", "47", "Rue de Rennes", "France"), "olivier.dubois@example.com", "06 70 80 90 00"),
                new Client("81828384858687", "Gomez", "Nathalie", new DateTime(1994, 6, 9), new Adresse("Paris", "31", "Boulevard de Sébastopol", "France"), "nathalie.gomez@example.com", "07 80 90 00 10"),
                new Client("91929394959697", "Morel", "Sébastien", new DateTime(1982, 10, 17), new Adresse("Paris", "19", "Rue de la Huchette", "France"), "sebastien.morel@example.com", "06 90 00 10 20"),
                new Client("01020304050607", "Renault", "Catherine", new DateTime(1979, 1, 29), new Adresse("Paris", "37", "Rue du Faubourg Saint-Honoré", "France"), "catherine.renault@example.com", "07 00 10 20 30"),
                new Client("10111213141516", "Lafont", "Guillaume", new DateTime(1992, 5, 13), new Adresse("Paris", "61", "Avenue de la République", "France"), "guillaume.lafont@example.com", "06 20 30 40 50"),
                new Client("20212223242526", "Dupuis", "Mélanie", new DateTime(1987, 8, 27), new Adresse("Paris", "8", "Rue de la Clef", "France"), "melanie.dupuis@example.com", "07 30 40 50 60"),
                new Client("30313233343536", "Gauthier", "Nicolas", new DateTime(1981, 12, 4), new Adresse("Paris", "23", "Rue de la Lune", "France"), "nicolas.gauthier@example.com", "06 40 50 60 70")
            };
            clients = clientsList;


            //List<Salarie> salarieList = new List<Salarie>
            //{
            //    new Salarie("SS123456", "Pierre", "Dupont", new DateTime(1990, 1, 1), new Adresse("Paris", "123", "Rue de Rivoli", "France"), "pierre.dupont@example.com", "01-23-45-67-89", new DateTime(2020, 1, 1), "Développeur", 40000),
            //    new Salarie("SS789012", "Marie", "Martin", new DateTime(1992, 3, 15), new Adresse("Lyon", "45", "Rue de la République", "France"), "marie.martin@example.com", "04-78-90-12-34", new DateTime(2020, 6, 1), "Designer", 35000),
            //    new Salarie("SS345678", "Jean", "Pierre", new DateTime(1985, 10, 20), new Adresse("Marseille", "678", "Rue de la Canebière", "France"), "jean.pierre@example.com", "04-91-23-45-67", new DateTime(2018, 3, 1), "Manager", 60000),
            //    new Salarie("SS901234", "Sophie", "Lefebvre", new DateTime(1995, 5, 10), new Adresse("Bordeaux", "901", "Rue Sainte-Catherine", "France"), "sophie.lefebvre@example.com", "05-56-78-90-12", new DateTime(2020, 9, 1), "Commercial", 45000),
            //    new Salarie("SS567890", "François", "Roux", new DateTime(1980, 12, 25), new Adresse("Toulouse", "567", "Rue du Taur", "France"), "francois.roux@example.com", "05-61-23-45-67", new DateTime(2019, 1, 1), "Ingénieur", 50000),
            //    new Salarie("SS234567", "Catherine", "Lemaire", new DateTime(1988, 7, 20), new Adresse("Nice", "234", "Promenade des Anglais", "France"), "catherine.lemaire@example.com", "04-93-45-67-89", new DateTime(2018, 6, 1), "Secrétaire", 30000),
            //    new Salarie("SS456789", "Henri", "Dubois", new DateTime(1991, 2, 5), new Adresse("Rennes", "456", "Rue de la République", "France"), "henri.dubois@example.com", "02-99-45-67-89", new DateTime(2020, 3, 1), "Développeur", 42000),
            //    new Salarie("SS678901", "Laurent", "Garnier", new DateTime(1982, 11, 15), new Adresse("Strasbourg", "678", "Rue des Grandes Arcades", "France"), "laurent.garnier@example.com", "03-88-45-67-89", new DateTime(2019, 9, 1), "Manager", 65000),
            //    new Salarie("SS109876", "Aurélie", "Moreau", new DateTime(1994, 1, 20), new Adresse("Nantes", "109", "Rue de la République", "France"), "aurelie.moreau@example.com", "02-40-45-67-89", new DateTime(2020, 6, 1), "Commercial", 48000),
            //    new Salarie("SS543210", "Julien", "Bertrand", new DateTime(1986, 8, 10), new Adresse("Montpellier", "543", "Rue de la Comédie", "France"), "julien.bertrand@example.com", "04-67-45-67-89", new DateTime(2018, 12, 1), "Ingénieur", 55000),
            //    new Salarie("SS765432", "Charlotte", "Dujardin", new DateTime(1993, 4, 15), new Adresse("Lille", "765", "Rue de la République", "France"), "charlotte.dujardin@example.com", "03-20-45-67-89", new DateTime(2020, 3, 1), "Secrétaire", 32000),
            //    new Salarie("SS321098", "Benoît", "Girard", new DateTime(1989, 9, 25), new Adresse("Grenoble", "321", "Rue de la République", "France"), "benoit.girard@example.com", "04-76-45-67-89", new DateTime(2019, 6, 1), "Développeur", 40000),
            //    new Salarie("SS987654", "Anaïs", "Lefort", new DateTime(1996, 10, 1), new Adresse("Rouen", "987", "Rue de la République", "France"), "anais.lefort@example.com", "02-35-45-67-89", new DateTime(2020, 9, 1), "Commercial", 42000),
            //    new Salarie("SS654321", "Guillaume", "Fournier", new DateTime(1984, 3, 20), new Adresse("Toulon", "654", "Rue de la République", "France"), "guillaume.fournier@example.com", "04-94-45-67-89", new DateTime(2018, 3, 1), "Manager", 70000),
            //    new Salarie("SS210987", "Léa", "Dupuis", new DateTime(1992, 6, 1), new Adresse("Reims", "210", "Rue de la République", "France"), "lea.dupuis@example.com", "03-26-45-67-89", new DateTime(2020, 6, 1), "Secrétaire", 30000),
            //    new Salarie("SS876543", "Alexandre", "Lefebvre", new DateTime(1987, 11, 10), new Adresse("Dijon", "876", "Rue de la République", "France"), "alexandre.lefebvre@example.com", "03-80-45-67-89", new DateTime(2019, 9, 1), "Ingénieur", 58000)
            //};
            //salaries = salarieList;
            //Organigramme = CreateOrganigramme(salaries[0]);

            List<Voiture> voitures = new List<Voiture>
            {
                new Voiture(0.25f, 20f, 2),
                new Voiture(0.30f, 22f, 3),
                new Voiture(0.35f, 25f, 5),
                new Voiture(0.40f, 30f, 5),
                new Voiture(0.45f, 40f, 4),
                new Voiture(0.50f, 50f, 5),
                new Voiture(0.48f, 60f, 6)
            };
            vehicules.AddRange(voitures);
            List<PoidsLourd> poidsLourds = new List<PoidsLourd>
            {
                new PoidsLourd(1.20f, 150f, 40.0f, "essence"),
                new PoidsLourd(1.30f, 170f, 50.0f, "gazole"),
                new PoidsLourd(1.00f, 120f, 30.0f, "sable"),
                new PoidsLourd(1.10f, 130f, 35.0f, "terre"),
                new PoidsLourd(1.40f, 200f, 60.0f, "marchandises périssables")
            };
            vehicules.AddRange(poidsLourds);
            List<Camionnette> camionnettes = new List<Camionnette>
            {
                new Camionnette(0.45f, 60f, "déménagement"),
                new Camionnette(0.50f, 70f, "livraison"),
                new Camionnette(0.55f, 80f, "transport de matériel"),
                new Camionnette(0.60f, 90f, "artisanat"),
                new Camionnette(0.65f, 100f, "loisirs")
            };
            vehicules.AddRange(camionnettes);

            CreateSalarieDemandes();

            commandes = createCommandes(30);
            Random rand = new Random();
            commandes.ForEach(c => clients.OrderBy(s => rand.Next()).First().addCommande(c));


        }

        /// <summary>
        /// Méthode pour obtenir les statistiques
        /// </summary>
        /// <returns></returns>
        public static string GetStatistics()
        {
            if (commandes == null || commandes.Count == 0 || clients == null || clients.Count == 0 || salaries == null || salaries.Count == 0 || vehicules == null || vehicules.Count == 0 || Chauffeurs == null || Chauffeurs.Count == 0)
            {
                return "Une ou plusieurs listes sont nulles ou vides. Impossible de calculer les statistiques.";
            }
            
            int totalCommands = commandes.Count;

            
            int totalClients = clients.Count;

            
            int totalEmployees = salaries.Count;

           
            int totalVehicles = vehicules.Count;

           
            int totalDrivers = Chauffeurs.Count;

            
            Client bestClient = clients.OrderByDescending(c => c.NbCommandes).FirstOrDefault();

           
            Chauffeur busiestDriver = Chauffeurs.OrderByDescending(c => c.nombreCommandes).FirstOrDefault();

            
            float averageCommandPrice = commandes.Average(c => c.Prix);

            
            float totalRevenue = commandes.Sum(c => c.Prix);

           
            float averageDistance = commandes.Average(c => c.Distance);

            
            float averageTime = commandes.Average(c => c.TempsEnMin);

           
            float totalDistance = commandes.Sum(c => c.Distance);

            
            float totalTime = commandes.Sum(c => c.TempsEnMin);

            
            int uniqueClients = clients.Where(c => c.Commandes.Count > 0).Count();

            
            return $"Nombre total de commandes : {totalCommands}\n" +
                   $"Nombre total de clients : {totalClients}\n" +
                   $"Nombre total d'employés : {totalEmployees}\n" +
                   $"Nombre total de véhicules : {totalVehicles}\n" +
                   $"Nombre total de chauffeurs : {totalDrivers}\n" +
                   $"Meilleur client : {bestClient.noms}\n" +
                   $"Chauffeur le plus occupé : {busiestDriver.noms}\n" +
                   $"Prix moyen d'une commande : {averageCommandPrice}€\n" +
                   $"Revenu total : {totalRevenue}\n" +
                   $"Distance moyenne par commande : {averageDistance}km\n" +
                   $"Temps moyen par commande : {formatTemps(averageTime)}\n" +
                   $"Distance totale parcourue par toutes les commandes : {totalDistance}\n" +
                   $"Temps total pris pour toutes les commandes : {formatTemps(totalTime)}km\n" +
                   $"Nombre de clients avec au moins 1 commande : {uniqueClients}";
        }

        /// <summary>
        /// Méthode pour formater le temps
        /// </summary>
        /// <param name="temps"></param>
        /// <returns></returns>
        public static string formatTemps(float temps)
        {
            return (int)(temps / 60) + "h" + (temps % 60);
        }

        /// <summary>
        /// Méthode pour créer des demandes pour les salariés
        /// </summary>
        public static void CreateSalarieDemandes()
        {
            Random rnd = new Random();

            Salarie mrDupont = new Salarie("001", "Dupond", "Jean", GenerateRandomDate(new DateTime(1970, 1, 1), DateTime.Now, rnd), new Adresse("Paris", "75000", "Rue de la Paix", "France"), "jean.dupond@example.com", "0101010101", GenerateRandomDate(new DateTime(2010, 1, 1), DateTime.Now, rnd), "Directeur Général", 100000);
            Salarie mmeFiesta = new Salarie("002", "Fiesta", "Anne", GenerateRandomDate(new DateTime(1975, 1, 1), DateTime.Now, rnd), new Adresse("Lyon", "69000", "Rue de la République", "France"), "anne.fiesta@example.com", "0202020202", GenerateRandomDate(new DateTime(2010, 1, 1), DateTime.Now, rnd), "Directrice Commerciale", 90000);
            Salarie mrFetard = new Salarie("003", "Fetard", "Paul", GenerateRandomDate(new DateTime(1980, 1, 1), DateTime.Now, rnd), new Adresse("Marseille", "13000", "La Canebière", "France"), "paul.fetard@example.com", "0303030303", GenerateRandomDate(new DateTime(2010, 1, 1), DateTime.Now, rnd), "Directeur des Opérations", 85000);
            Salarie mmeJoyeuse = new Salarie("004", "Joyeuse", "Marie", GenerateRandomDate(new DateTime(1985, 1, 1), DateTime.Now, rnd), new Adresse("Toulouse", "31000", "Place du Capitole", "France"), "marie.joyeuse@example.com", "0404040404", GenerateRandomDate(new DateTime(2010, 1, 1), DateTime.Now, rnd), "Directrice des RH", 80000);
            Salarie mrGripSous = new Salarie("005", "GripSous", "Luc", GenerateRandomDate(new DateTime(1990, 1, 1), DateTime.Now, rnd), new Adresse("Nice", "06000", "Promenade des Anglais", "France"), "luc.gripsous@example.com", "0505050505", GenerateRandomDate(new DateTime(2010, 1, 1), DateTime.Now, rnd), "Directeur Financier", 95000);
            Salarie mrForge = new Salarie("006", "Forge", "Olivier", GenerateRandomDate(new DateTime(1995, 1, 1), DateTime.Now, rnd), new Adresse("Nantes", "44000", "Rue de la Marne", "France"), "olivier.forge@example.com", "0606060606", GenerateRandomDate(new DateTime(2010, 1, 1), DateTime.Now, rnd), "Commercial", 70000);
            Salarie mmeFermi = new Salarie("007", "Fermi", "Laura", GenerateRandomDate(new DateTime(2000, 1, 1), DateTime.Now, rnd), new Adresse("Strasbourg", "67000", "Place Kléber", "France"), "laura.fermi@example.com", "0707070707", GenerateRandomDate(new DateTime(2010, 1, 1), DateTime.Now, rnd), "Commerciale", 70000);
            Salarie mrRoyal = new Salarie("008", "Royal", "David", GenerateRandomDate(new DateTime(2005, 1, 1), DateTime.Now, rnd), new Adresse("Montpellier", "34000", "Place de la Comédie", "France"), "david.royal@example.com", "0808080808", GenerateRandomDate(new DateTime(2010, 1, 1), DateTime.Now, rnd), "Chef Équipe", 75000);
            Salarie mmePrince = new Salarie("009", "Prince", "Sophie", GenerateRandomDate(new DateTime(2010, 1, 1), DateTime.Now, rnd), new Adresse("Bordeaux", "33000", "Place de la Bourse", "France"), "sophie.prince@example.com", "0909090909", GenerateRandomDate(new DateTime(2010, 1, 1), DateTime.Now, rnd), "Chef d'Équipe", 75000);
            Chauffeur mrRomu = new Chauffeur("010", "Romu", "Pierre", GenerateRandomDate(new DateTime(2015, 1, 1), DateTime.Now, rnd), new Adresse("Lille", "59000", "Place Charles de Gaulle", "France"), "pierre.romu@example.com", "1010101010", GenerateRandomDate(new DateTime(2010, 1, 1), DateTime.Now, rnd), 50000, rnd.Next(10, 20), vehicules[rnd.Next(vehicules.Count)]);
            Chauffeur mmeRome = new Chauffeur("011", "Rome", "Julie", GenerateRandomDate(new DateTime(2015, 1, 1), DateTime.Now, rnd), new Adresse("Rennes", "35000", "Place de la Mairie", "France"), "julie.rome@example.com", "1111111111", GenerateRandomDate(new DateTime(2010, 1, 1), DateTime.Now, rnd), 50000, rnd.Next(10, 20), vehicules[rnd.Next(vehicules.Count)]);
            Chauffeur mmeRomi = new Chauffeur("012", "Romi", "Isabelle", GenerateRandomDate(new DateTime(2015, 1, 1), DateTime.Now, rnd), new Adresse("Reims", "51100", "Place Drouet d'Erlon", "France"), "isabelle.romi@example.com", "1212121212", GenerateRandomDate(new DateTime(2010, 1, 1), DateTime.Now, rnd), 50000, rnd.Next(10, 20), vehicules[rnd.Next(vehicules.Count)]);
            Chauffeur mrRoma = new Chauffeur("013", "Roma", "Hugo", GenerateRandomDate(new DateTime(2015, 1, 1), DateTime.Now, rnd), new Adresse("Le Havre", "76600", "Place de l'Hôtel de Ville", "France"), "hugo.roma@example.com", "1313131313", GenerateRandomDate(new DateTime(2010, 1, 1), DateTime.Now, rnd), 50000, rnd.Next(10, 20), vehicules[rnd.Next(vehicules.Count)]);
            Chauffeur mmeRimou = new Chauffeur("020", "Rimou", "Marie", GenerateRandomDate(new DateTime(1998, 1, 1), DateTime.Now, rnd), new Adresse("Caen", "14000", "Place Saint-Pierre", "France"), "marie.rimou@example.com", "2020202020", GenerateRandomDate(new DateTime(2010, 1, 1), DateTime.Now, rnd), 50000, rnd.Next(10, 20), vehicules[rnd.Next(vehicules.Count)]);
            Salarie mmeCouleur = new Salarie("014", "Couleur", "Nathalie", GenerateRandomDate(new DateTime(2014, 1, 1), DateTime.Now, rnd), new Adresse("Saint-Étienne", "42000", "Place Jean Jaurès", "France"), "nathalie.couleur@example.com", "1414141414", GenerateRandomDate(new DateTime(2010, 1, 1), DateTime.Now, rnd), "Formation", 68000);
            Salarie mmeToutleMonde = new Salarie("015", "ToutleMonde", "Caroline", GenerateRandomDate(new DateTime(2013, 1, 1), DateTime.Now, rnd), new Adresse("Toulon", "83000", "Place de la Liberté", "France"), "caroline.toutlemonde@example.com", "1515151515", GenerateRandomDate(new DateTime(2010, 1, 1), DateTime.Now, rnd), "Contrats", 65000);
            Salarie mrPiscou = new Salarie("016", "Piscou", "Bernard", GenerateRandomDate(new DateTime(2012, 1, 1), DateTime.Now, rnd), new Adresse("Grenoble", "38000", "Place Victor Hugo", "France"), "bernard.piscou@example.com", "1616161616", GenerateRandomDate(new DateTime(2010, 1, 1), DateTime.Now, rnd), "Direction Comptable", 73000);
            Salarie mrGrosSous = new Salarie("017", "GrosSous", "Étienne", GenerateRandomDate(new DateTime(2011, 1, 1), DateTime.Now, rnd), new Adresse("Dijon", "21000", "Place de la Libération", "France"), "etienne.grossous@example.com", "1717171717", GenerateRandomDate(new DateTime(2010, 1, 1), DateTime.Now, rnd), "Contrôleur de Gestion", 71000);
            Salarie mmeFournier = new Salarie("018", "Fournier", "Hélène", GenerateRandomDate(new DateTime(2010, 1, 1), DateTime.Now, rnd), new Adresse("Nîmes", "30000", "Place de la Maison Carrée", "France"), "helene.fournier@example.com", "1818181818", GenerateRandomDate(new DateTime(2010, 1, 1), DateTime.Now, rnd), "Comptable", 60000);
            Salarie mmeGautier = new Salarie("019", "Gautier", "Alice", GenerateRandomDate(new DateTime(2009, 1, 1), DateTime.Now, rnd), new Adresse("Angers", "49000", "Place du Ralliement", "France"), "alice.gautier@example.com", "1919191919", GenerateRandomDate(new DateTime(2010, 1, 1), DateTime.Now, rnd), "Comptable", 60000);


            mrDupont.suivants = new List<Salarie>() { mmeFiesta, mrFetard, mmeJoyeuse, mrGripSous };
            mmeFiesta.suivants = new List<Salarie>() { mrForge, mmeFermi };
            mrFetard.suivants = new List<Salarie>() { mrRoyal, mmePrince };
            mrRoyal.suivants = new List<Salarie>() { mrRomu, mmeRomi, mrRoma };
            mmePrince.suivants = new List<Salarie>() { mmeRome, mmeRimou };
            mmeJoyeuse.suivants = new List<Salarie>() { mmeCouleur, mmeToutleMonde };
            mrGripSous.suivants = new List<Salarie>() { mrPiscou, mrGrosSous };
            mrPiscou.suivants = new List<Salarie>() { mmeFournier, mmeGautier };

            List <Salarie> all_salaries = new List<Salarie>
            {
                mrDupont,
                mmeFiesta,
                mrFetard,
                mmeJoyeuse,
                mrGripSous,
                mrForge,
                mmeFermi,
                mrRoyal,
                mmePrince,
                mrRomu,
                mmeRome,
                mmeRomi,
                mrRoma,
                mmeCouleur,
                mmeToutleMonde,
                mrPiscou,
                mrGrosSous,
                mmeFournier,
                mmeGautier
            };
            salaries = all_salaries;
            Organigramme = mrDupont;
        }

        /// <summary>
        /// Méthode pour créer un ensemble aléatoire de commandes
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static List<Commande> createCommandes(int n = 20)
        {
            
            List<Commande> commandes = new List<Commande>();

            
            Random rand = new Random();

            
            int nb_chauffeurs = salaries.Count / 3;
            
            List<Chauffeur> chauffeurs = salaries.OfType<Chauffeur>().ToList();

            Chauffeurs = chauffeurs;

           
            for (int i = 0; i < n; i++)
            {
                
                Adresse adresseA = new Adresse(Villes[rand.Next(Villes.Count)], "France");
                Adresse adresseB = new Adresse(Villes[rand.Next(Villes.Count)], "France");

                
                while (adresseA.Ville == adresseB.Ville)
                {
                    adresseB = new Adresse(Villes[rand.Next(Villes.Count)], "France");
                }

                
                Chauffeur chauffeur = chauffeurs[rand.Next(chauffeurs.Count)];
                DateTime date = GenerateRandomDate(new DateTime(2020, 1, 1), DateTime.Now, rand);
                if (!chauffeur.estDispo(date))
                {
                    //MessageBox.Show($"Test date ({i}) : \n " + date +"avec : "+chauffeur);
                    i--;
                    continue;
                }

                Commande commande = new Commande(adresseA, adresseB, chauffeur, date);

                commandes.Add(commande);
            }
            return commandes;
        }

        /// <summary>
        /// Méthode pour générer une date aléatoire entre deux dates données
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="rand"></param>
        /// <returns></returns>
        public static DateTime GenerateRandomDate(DateTime start, DateTime end, Random rand)
        {
            long range = (long)((end - start).TotalMilliseconds);
            long randomMilliseconds = (long)(rand.NextDouble() * range);

            DateTime randomDate = start.AddMilliseconds(randomMilliseconds);

            return randomDate;
        }

        /// <summary>
        /// Méthode pour créer l'organigramme de l'entreprise
        /// </summary>
        /// <param name="tete"></param>
        /// <returns></returns>
        static Salarie CreateOrganigramme(Salarie tete)
        {
            Random rnd = new Random();

            int indToProcess = 1; 
            List<Salarie> listToProcess = new List<Salarie>() { tete };

            while (listToProcess.Count > 0 && indToProcess <= salaries.Count)
            {
                Salarie current = listToProcess[0];
                int random = rnd.Next(1, 5);
                int nbSuivants = Math.Min(random, salaries.Count - indToProcess - 1);
                for (int i = 0; i < nbSuivants; i++)
                {
                    current.suivants.Add(salaries[indToProcess]);
                    listToProcess.Add(salaries[indToProcess]);
                    indToProcess++;
                }

                listToProcess.RemoveAt(0);
            }

            return tete;
        }

        /// <summary>
        /// Méthode pour afficher l'organigramme de l'entreprise
        /// </summary>
        /// <param name="tete"></param>
        /// <param name="decal"></param>
        /// <param name="last"></param>
        /// <param name="prefixe"></param>
        /// <returns></returns>
        public static string ShowOrganigramme(Salarie tete, int decal = 0, bool last = false, string prefixe = "")
        {
            if (tete == null)
                return "";

            string r = (decal > 0 ? prefixe + (last ? " ╙─ " : " ╠─ ") : "") + tete.noms + "\n";

            if (tete.suivants != null && tete.suivants.Count != 0)
            {
                string newPrefixe = prefixe + (decal > 0 ? (last ? "   " : " │ ") : "");
                for (int i = 0; i < tete.suivants.Count; i++)
                {
                    r += ShowOrganigramme(tete.suivants[i], decal + 1, i == tete.suivants.Count - 1, newPrefixe);
                }
            }

            return r;
        }


        /// <summary>
        /// Méthode pour obtenir les noms des chauffeurs
        /// </summary>
        /// <returns></returns>
        public static List<string> noms_chauffeurs()
        {
            return Chauffeurs.Select(s => s.noms).ToList();
        }

        /// <summary>
        /// Méthode pour obtenir les noms des chauffeurs disponibles à une date donnée
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static List<string> noms_chauffeursDispo(DateTime date)
        {
            return Chauffeurs.Where(x => x.estDispo(date)).Select(s => s.noms).ToList();
        }

        /// <summary>
        /// Méthode pour obtenir les noms de tous les salariés
        /// </summary>
        /// <returns></returns>
        public static List<string> noms_salaries()
        {
            return salaries.Select(s=>s.noms).ToList();
        }

        /// <summary>
        /// Méthode pour obtenir les noms des salariés qui ne sont pas inférieurs à un salarié donné dans l'organigramme
        /// </summary>
        /// <param name="salarie"></param>
        /// <param name="allSalaries"></param>
        /// <returns></returns>
        public static List<string> noms_salaries_non_inferieurs(Salarie salarie, List<Salarie> allSalaries = null)
        {
            if (allSalaries == null)
                allSalaries = salaries;
            
            if (salarie == null)
            {
                return allSalaries.Select(s => s.noms).ToList();
            }

            
            var names = new List<string>();
            foreach (var s in allSalaries)
            {
                
                if (!IsInSubtree(s, salarie))
                {
                    names.Add(s.noms);
                }

                
                names.AddRange(noms_salaries_non_inferieurs(salarie, s.suivants));
            }

            return names.Distinct().ToList();
        }

        /// <summary>
        /// Méthode pour vérifier si un salarié est dans le sous-arbre d'un autre salarié dans l'organigramme
        /// </summary>
        /// <param name="salarie"></param>
        /// <param name="tete"></param>
        /// <returns></returns>
        public static bool IsInSubtree(Salarie salarie, Salarie tete)
        {
            if (salarie == tete)
            {
                return true;
            }

            foreach (var s in tete.suivants)
            {
                if (IsInSubtree(salarie, s))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Méthode pour obtenir les noms de tous les clients
        /// </summary>
        /// <returns></returns>
        public static List<string> noms_clients()
        {
            return clients.Select(s=>s.noms).ToList();
        }

        /// <summary>
        /// Méthode pour obtenir les noms de tous les véhicules
        /// </summary>
        /// <returns></returns>
        public static List<string> noms_Vehicules()
        {
            return vehicules.Select(s=>s.ToString()).ToList();
        }

        /// <summary>
        /// Méthode pour insérer un nouveau salarié dans l'organigramme sous un chef donné
        /// </summary>
        /// <param name="new_sal"></param>
        /// <param name="noms_boss"></param>
        /// <returns></returns>
        public static bool insert_in_organigramme(Salarie new_sal, string noms_boss)
        {
            try
            {
                
                Salarie boss = FindSalarie(noms_boss);

                if (boss == null)
                {
                    
                    return false;
                }

                boss.suivants.Add(new_sal);

                return true;
            }
            catch
            {
                
                return false;
            }
        }

        /// <summary>
        /// Méthode pour trouver un salarié par son nom
        /// </summary>
        /// <param name="noms_salarie"></param>
        /// <returns></returns>
        public static Salarie FindSalarie(string noms_salarie)
        {
            return salaries.Find(s => s.noms == noms_salarie);
        }

        /// <summary>
        /// Méthode pour trouver le chef d'un salarié dans l'organigramme
        /// </summary>
        /// <param name="sal"></param>
        /// <param name="tete"></param>
        /// <returns></returns>
        public static Salarie FindBoss(Salarie sal, Salarie tete = null)
        {
            Salarie current = tete ?? Organigramme;
            Salarie supérieur = current;
            //MessageBox.Show("current : \n" + current + "");
            for (int i = 0; i < current.suivants.Count; i++)
            {
                Salarie fils = current.suivants[i];
                if (fils.noms == sal.noms)
                {
                    //MessageBox.Show("trouve : \n" + supérieur);
                    return supérieur;
                }
                Salarie boss_subtree = FindBoss(sal, fils);
                if(boss_subtree != null)
                    return boss_subtree;
            }

            return null;
        }

        /// <summary>
        /// Méthode pour trouver le client associé à une commande
        /// </summary>
        /// <param name="commande"></param>
        /// <returns></returns>
        public static Client FindClientCommande(Commande commande)
        {
            return clients.FirstOrDefault(c => c.Commandes.Contains(commande));
        }

        /// <summary>
        /// Méthode pour ajouter une commande pour un client donné
        /// </summary>
        /// <param name="commande"></param>
        /// <param name="cli"></param>
        public static void AddCommande(Commande commande, Client cli)
        {
            commandes.Add(commande);
            cli.Commandes.Add(commande);
            commande.Chauffeur.nombreCommandes++;
        }

        /// <summary>
        /// Méthode pour supprimer une commande
        /// </summary>
        /// <param name="commande"></param>
        public static void RemoveCommande(Commande commande)
        {
            commande.Chauffeur.nombreCommandes--;
            commandes.Remove(commande);
            FindClientCommande(commande).Commandes.Remove(commande);
        }

        /// <summary>
        /// Méthode pour ajouter un client
        /// </summary>
        /// <param name="client"></param>
        public static void AddClient(Client client)
        {
            clients.Add(client);
        }

        /// <summary>
        /// Méthode pour supprimer un client
        /// </summary>
        /// <param name="client"></param>
        public static void RemoveClient(Client client)
        {
            clients.Remove(client);
        }

        /// <summary>
        /// Méthode pour ajouter un nouveau salarié
        /// </summary>
        /// <param name="salarie"></param>
        /// <param name="nom_boss"></param>
        /// <returns></returns>
        public static bool AddSalarie(Salarie salarie, string nom_boss)
        {
            salaries.Add(salarie);
            return insert_in_organigramme(salarie, nom_boss);
        }

        /// <summary>
        /// Méthode pour supprimer un salarié
        /// </summary>
        /// <param name="salarie"></param>
        public static void RemoveSalarie(Salarie salarie)
        {
            salaries.Remove(salarie);
            Salarie boss = FindBoss(salarie);
            boss?.suivants.AddRange(salarie.suivants);
            boss?.suivants.Remove(salarie);
        }

        /// <summary>
        /// Méthode pour ajouter un véhicule
        /// </summary>
        /// <param name="vehicule"></param>
        public static void AddVehicule(Vehicule vehicule)
        {
            vehicules.Add(vehicule);
        }

        /// <summary>
        /// Méthode pour supprimer un véhicule
        /// </summary>
        /// <param name="vehicule"></param>
        public static void RemoveVehicule(Vehicule vehicule)
        {
            vehicules.Remove(vehicule);
        }
    }
}

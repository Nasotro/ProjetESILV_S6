﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsProjetS6
{
    internal class Commande
    {
        protected Adresse adresseA, adresseB;
        protected float prix;
        protected Chauffeur chauffeur;
        protected DateTime date;
        protected Vehicule vehicule;
        Client client;
        public Client Client { get { return client; } set { client = value; } }
        public float Distance { get; set; }
        public float TempsEnMin { get; set; }
        public string tempsFormated
        {
            get { return (int)(TempsEnMin / 60) + "h" + (TempsEnMin % 60); }
        }
        public Commande(Adresse adresseA, Adresse adresseB, Chauffeur chauffeur, DateTime date, Client c)
        {
            this.adresseA = adresseA;
            this.adresseB = adresseB;
            this.chauffeur = chauffeur;
            this.vehicule = chauffeur.Vehicule;
            this.date = date;
            this.client = c;
            //System.Windows.Forms.MessageBox.Show(chauffeur+"");
            float[] infos = CheminLePlusCourt(adresseA, adresseB);
            Distance = infos[0];
            TempsEnMin = infos[1];
            prix = vehicule.PrixLoc + vehicule.PrixKm * Distance + TempsEnMin * Chauffeur.TarifHoraire;
        }
        public Commande(Adresse adresseA, Adresse adresseB, Chauffeur chauffeur, DateTime date)
        {
            this.adresseA = adresseA;
            this.adresseB = adresseB;
            this.chauffeur = chauffeur;
            this.vehicule = chauffeur.Vehicule;
            this.date = date;
            //System.Windows.Forms.MessageBox.Show(chauffeur+"");
            float[] infos = CheminLePlusCourt(adresseA, adresseB);
            Distance = infos[0];
            TempsEnMin = infos[1];
            prix = vehicule.PrixLoc + vehicule.PrixKm * Distance + TempsEnMin * Chauffeur.TarifHoraire;
        }


        public class Ville : IComparable<Ville> 
        {
            public string Name { get; set; }
            public bool IsOut { get; set; } = false;
            public Dictionary<Ville, int> VoisinsDist { get; set; } = new Dictionary<Ville, int>();
            public Dictionary<Ville, int> VoisinsTemps { get; set; } = new Dictionary<Ville, int>();
            public int CheminLePlusCourt { get; set; } = int.MaxValue;
            public int TempsLePlusCourt { get; set; } = 0;
            public Ville VillePrecedente { get; set; } = null;
            public Ville(string name)
            {
                Name = name;
                IsOut = false;
            }
            public void Reset()
            {
                CheminLePlusCourt = int.MaxValue;
                TempsLePlusCourt = 0;
                VillePrecedente = null;
                IsOut = false;
            }
            public override string ToString()
            {
                return Name;
            }
            public int CompareTo(Ville other)
            {
                return Name.CompareTo(other.Name);
            }
        }
        public List<Ville> loadCSV(string filePath)
        {
            var villes = new List<Ville>();
            var cityMap = new Dictionary<string, Ville>();

            using (var reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(';');

                    var ville1Name = parts[0];
                    var ville2Name = parts[1];
                    var distance = int.Parse(parts[2]);
                    var temps = int.Parse(parts[4]);

                    if (!cityMap.TryGetValue(ville1Name, out var ville1))
                    {
                        ville1 = new Ville(ville1Name);
                        villes.Add(ville1);
                        cityMap[ville1Name] = ville1;
                    }

                    if (!cityMap.TryGetValue(ville2Name, out var ville2))
                    {
                        ville2 = new Ville(ville2Name);
                        villes.Add(ville2);
                        cityMap[ville2Name] = ville2;
                    }

                    ville1.VoisinsDist[ville2] = distance;
                    ville2.VoisinsDist[ville1] = distance;
                    ville1.VoisinsTemps[ville2] = temps;
                    ville2.VoisinsTemps[ville1] = temps;
                }
            }

            return villes;
        }


        public float[] CheminLePlusCourt(Adresse a, Adresse b)
        {
            var cities = loadCSV("Distances.csv"); // Replace with the actual path to your CSV file
            var cityMap = cities.ToDictionary(c => c.Name);

            if (!cityMap.TryGetValue(a.Ville, out var startCity) || !cityMap.TryGetValue(b.Ville, out var endCity))
            {
                System.Windows.Forms.MessageBox.Show(a+"\n"+b);
                throw new ArgumentException("One or both of the addresses are not found in the CSV file : ");
            }

            Dijkstra(startCity, cities);

            if (endCity.CheminLePlusCourt == int.MaxValue)
            {
                // No path found between the two addresses
                return new float[2] { -1, -1 };
            }

            return new float[2] { endCity.CheminLePlusCourt, endCity.TempsLePlusCourt };
        }

        public void Dijkstra(Ville startCity, List<Ville> cities)
        {
            cities.ForEach(x => x.Reset());
            startCity.CheminLePlusCourt = 0;
            List<Ville> VillesToProcess = new List<Ville>() { startCity };
            while(VillesToProcess.Count > 0)
            {
                Ville v = VillesToProcess.OrderBy(x => x.CheminLePlusCourt).First();
                for (int i = 0; i < v.VoisinsDist.Count; i++)
                {
                    KeyValuePair<Ville, int> h = v.VoisinsDist.ElementAt(i);
                    Ville voisin = h.Key;
                    int dist = h.Value;
                    int temps = v.VoisinsTemps.ElementAt(i).Value;

                    if (voisin.IsOut) continue;
                    VillesToProcess.Add(voisin);
                    int newDist = v.CheminLePlusCourt + dist;
                    if (newDist < voisin.CheminLePlusCourt)
                    {
                        voisin.CheminLePlusCourt = newDist;
                        voisin.TempsLePlusCourt = v.TempsLePlusCourt + temps;
                    }
                }
                v.IsOut = true;
                VillesToProcess.Remove(v);
            }
        }

        public Adresse AdresseA
        {
            get { return adresseA; }
            set { adresseA = value; }
        }

        public Adresse AdresseB
        {
            get { return adresseB; }
            set { adresseB = value; }
        }

        public float Prix
        {
            get { return prix; }
            set { prix = value; }
        }

        public Chauffeur Chauffeur
        {
            get { return chauffeur; }
            set { chauffeur = value; }
        }

        public Vehicule Vehicule
        {
            get { return vehicule; }
            set { vehicule = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public override string ToString()
        {
            return $"Commande: \n" +
                   $"Adresse A: {adresseA}\n" +
                   $"Adresse B: {adresseB}\n" +
                   $"Prix: {prix}\n" +
                   $"Chauffeur: {chauffeur}\n" +
                   $"Vehicule: {vehicule}\n" +
                   $"Client : {client}" +
                   $"Date: {date}";
        }
    }
}
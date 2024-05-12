using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormsProjetS6
{
    public partial class AddCommandeForms : Form
    {
        public AddCommandeForms()
        {
            InitializeComponent();

            updateComboBoxes();

        }

        private void buttonCreateCommande_Click(object sender, EventArgs e)
        {
            // Check if any of the input fields are empty
            if (string.IsNullOrWhiteSpace(comboBoxAdresseA.Text) ||
                string.IsNullOrWhiteSpace(comboBoxAdresseB.Text) ||
                string.IsNullOrWhiteSpace(comboBoxChauffeur.Text) ||
                string.IsNullOrWhiteSpace(comboBoxCLient.Text))
            {
                // Display an error message if any of the input fields are empty
                MessageBox.Show("Veuillez rentrer tous les champs svp", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new Adresse object using the input values
            Adresse adresseA = new Adresse(comboBoxAdresseA.Text, "France");
            Adresse adresseB = new Adresse(comboBoxAdresseB.Text, "France");
            Chauffeur chauff = DataBase.Chauffeurs.FirstOrDefault(chauffeur => chauffeur.noms == comboBoxChauffeur.Text);
            DateTime date = dateTimePickerCommande.Value;
            Client cli = DataBase.clients.FirstOrDefault(client => client.noms == comboBoxCLient.Text);

            // Create a new Client object using the input values
            Commande c = new Commande(adresseA, adresseB, chauff, date);

            // Add the new client to the clientsList
            DataBase.commandes.Add(c);
            cli.Commandes.Add(c);

            comboBoxAdresseA.DataSource = null;
            comboBoxAdresseB.DataSource = null;
            comboBoxChauffeur.DataSource = null;
            comboBoxCLient.DataSource = null;


            MessageBox.Show($"Pour une commande de {adresseA.Ville} à {adresseB.Ville},\n" +
                $" La distance minimale est de {c.Distance}\n" +
                $" Le temps nécessaire est de {c.tempsFormated}\n");

            // Close the form
            this.Close();

        }

        void updateComboBoxes()
        {
            comboBoxAdresseA.DataSource = null;
            comboBoxAdresseB.DataSource = null;
            comboBoxChauffeur.DataSource = null;
            comboBoxCLient.DataSource = null;
            comboBoxAdresseA.DataSource = DataBase.Villes;
            comboBoxAdresseB.DataSource = DataBase.Villes;
            comboBoxAdresseA.BindingContext = new BindingContext();
            comboBoxAdresseB.BindingContext = new BindingContext();
            comboBoxChauffeur.DataSource = DataBase.noms_chauffeursDispo(dateTimePickerCommande.Value);
            comboBoxCLient.DataSource = DataBase.noms_clients();
        }

        private void dateTimePickerCommande_ValueChanged(object sender, EventArgs e)
        {
            updateComboBoxes();
        }
    }
}

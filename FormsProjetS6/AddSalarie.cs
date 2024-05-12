using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProjetS6
{
    public partial class AddSalarie : Form
    {
        public AddSalarie()
        {
            InitializeComponent();
            reloadListSalarie();
        }

        public void reloadListSalarie()
        {
            comboBoxBoss.DataSource = DataBase.noms_salaries();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Check if any of the input fields are empty
            if (string.IsNullOrWhiteSpace(txtNumeroSS.Text) ||
                string.IsNullOrWhiteSpace(txtNom.Text) ||
                string.IsNullOrWhiteSpace(txtPrenom.Text) ||
                string.IsNullOrWhiteSpace(txtVille.Text) ||
                string.IsNullOrWhiteSpace(txtRue.Text) ||
                string.IsNullOrWhiteSpace(txtPays.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtTelephone.Text) ||
                string.IsNullOrWhiteSpace(txtPoste.Text) || 
                string.IsNullOrWhiteSpace(txtSalaire.Text)||
                string.IsNullOrWhiteSpace(comboBoxBoss.Text)) 
            {
                // Display an error message if any of the input fields are empty
                MessageBox.Show("Veuillez rentrer tous les champs svp", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new Adresse object using the input values
            Adresse adresse = new Adresse(txtVille.Text, txtNumero.Text, txtRue.Text, txtPays.Text);
            int salaire = (int)txtSalaire.Value;

            // Create a new Salarie object using the input values
            Salarie newSalarie = new Salarie(txtNumeroSS.Text, txtNom.Text, txtPrenom.Text, dtpDateDeNaissance.Value, adresse, txtEmail.Text, txtTelephone.Text, dtpRentree.Value, txtPoste.Text, salaire);

            // Add the new salarie to the salariesList
            DataBase.AddSalarie(newSalarie, comboBoxBoss.Text);

            // Clear the input fields
            txtNumeroSS.Clear();
            txtNom.Clear();
            txtPrenom.Clear();
            dtpDateDeNaissance.Value = DateTime.Today;
            txtVille.Clear();
            txtRue.Clear();
            txtPays.Clear();
            txtEmail.Clear();
            txtTelephone.Clear();
            dtpRentree.Value = DateTime.Today;
            txtPoste.Clear();
            txtSalaire.Value = 0;

            // Close the form
            this.Close();
        }
    }
}

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
    public partial class AddClientForm : Form
    {
        public AddClientForm()
        {
            InitializeComponent();
        }

        private void txtNumeroSS_TextChanged(object sender, EventArgs e)
        {

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
                string.IsNullOrWhiteSpace(txtTelephone.Text))
            {
                // Display an error message if any of the input fields are empty
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new Adresse object using the input values
            Adresse adresse = new Adresse(txtVille.Text, txtNumero.Text, txtRue.Text, txtPays.Text);

            // Create a new Client object using the input values
            Client newClient = new Client(txtNumeroSS.Text, txtNom.Text, txtPrenom.Text, dtpDateDeNaissance.Value, adresse, txtEmail.Text, txtTelephone.Text);

            // Add the new client to the clientsList
            DataBase.clients.Add(newClient);

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

            // Close the form
            this.Close();
        }
    }
}

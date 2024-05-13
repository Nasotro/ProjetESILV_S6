using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProjetS6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            updateTabClient();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabClient;
        }

        private void buttonSalarie_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabSalarie;
        }

        private void buttonCommande_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabCommande;
        }

        private void buttonStats_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabStatistiques;
        }

        private void buttonAccueil_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabAccueil;
        }

        private void buttonGenerateData_Click(object sender, EventArgs e)
        {
            DataBase.Generate();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateTabClient();
            updateTabSalarie();
            updateTabCommandes();
        }

        public List<string> GetProperties(object obj)
        {
            // Get the type of the object
            Type type = obj.GetType();

            // Get all the properties of the type
            PropertyInfo[] properties = type.GetProperties().Where(property => property.CanWrite && !typeof(IList).IsAssignableFrom(property.PropertyType) && !typeof(Adresse).IsAssignableFrom(property.PropertyType)).ToArray();

            // Return a list of the property names
            return properties.Select(property => property.Name).ToList();
        }
        public void SetPropertyValue(object obj, string propertyName, object newValue)
        {
            if (obj == null || string.IsNullOrEmpty(propertyName))
            {
                throw new ArgumentNullException("Object or property name cannot be null.");
            }

            Type objType = obj.GetType();
            PropertyInfo propertyInfo = objType.GetProperty(propertyName);

            if (propertyInfo == null || !propertyInfo.CanWrite)
            {
                throw new ArgumentException("The specified property does not exist or is read-only.");
            }

            if (IsNumericType(propertyInfo.PropertyType) && !IsValidIntegerValue(newValue))
            {
                MessageBox.Show("The input value is not a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            propertyInfo.SetValue(obj, Convert.ChangeType(newValue, propertyInfo.PropertyType), null);
        }
        private bool IsNumericType(Type type)
        {
            switch (Type.GetTypeCode(type))
            {
                case TypeCode.Byte:
                case TypeCode.SByte:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                    return true;
                default:
                    return false;
            }
        }
        private bool IsValidIntegerValue(object value)
        {
            if (value == null)
            {
                return false;
            }

            long integerValue;
            return long.TryParse(value.ToString(), out integerValue);
        }
        // affiche un message pour récupérer une entrée de l'utilisatuer
        public static string InputBox(string title, string promptText)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = "";

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";

            label.SetBounds(15, 20, 250, 25);
            textBox.SetBounds(15, 50, 250, 25);
            buttonOk.SetBounds(150, 85, 75, 25);
            buttonCancel.SetBounds(230, 85, 75, 25);

            form.ClientSize = new Size(350, 150);
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.StartPosition = FormStartPosition.CenterScreen;

            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel});
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;


            buttonOk.Click += (sender, e) => {
                form.DialogResult = DialogResult.OK;
                form.Close();
            };

            buttonCancel.Click += (sender, e) => {
                form.DialogResult = DialogResult.Cancel;
                form.Close();
            };
            textBox.KeyDown += new KeyEventHandler(textBox_KeyDown);

            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                return textBox.Text;
            }
            else
            {
                return "";
            }

            void textBox_KeyDown(object sender, KeyEventArgs e)
            {
                // If the user pressed the Enter key, close the form with a DialogResult.OK value
                if (e.KeyCode == Keys.Enter)
                {
                    form.DialogResult = DialogResult.OK;
                    form.Close();
                }
            }
        }
        public static string InputBoxWithList(string title, string promptText, List<string> list)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            ComboBox comboBox = new ComboBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = "";

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            label.SetBounds(15, 20, 250, 25);
            textBox.SetBounds(15, 50, 250, 25);
            comboBox.SetBounds(15, 80, 250, 25);
            buttonOk.SetBounds(150, 115, 75, 25);
            buttonCancel.SetBounds(230, 115, 75, 25);

            form.ClientSize = new Size(350, 170);
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.StartPosition = FormStartPosition.CenterScreen;

            form.Controls.AddRange(new Control[] { label, textBox, comboBox, buttonOk, buttonCancel });
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            // Add items to the ComboBox control
            comboBox.Items.AddRange(list.ToArray());

            buttonOk.Click += (sender, e) => {
                if(comboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("please select a value to changed");
                    return;
                }
                form.DialogResult = DialogResult.OK;
                form.Close();
            };

            buttonCancel.Click += (sender, e) => {
                form.DialogResult = DialogResult.Cancel;
                form.Close();
            };

            textBox.KeyDown += new KeyEventHandler(textBox_KeyDown);
            comboBox.KeyDown += new KeyEventHandler(comboBox_KeyDown);

            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string r="";
                if (comboBox.SelectedItem != null)
                {
                    r = comboBox.SelectedItem.ToString() + "|" + textBox.Text;
                }
                return r;
            }
            else
            {
                return "";
            }

            void textBox_KeyDown(object sender, KeyEventArgs e)
            {
                // If the user pressed the Enter key, close the form with a DialogResult.OK value
                if (e.KeyCode == Keys.Enter)
                {
                    form.DialogResult = DialogResult.OK;
                    form.Close();
                }
            }

            void comboBox_KeyDown(object sender, KeyEventArgs e)
            {
                // If the user pressed the Enter key, close the form with a DialogResult.OK value
                if (e.KeyCode == Keys.Enter)
                {
                    form.DialogResult = DialogResult.OK;
                    form.Close();
                }
            }
        }

        #region Client
        public void updateTabClient()
        {
            tableauClients.AutoGenerateColumns = false;
            tableauClients.DataSource = null;
            tableauClients.DataSource = DataBase.clients;
            tableauClients.AutoGenerateColumns = true;
            orderColumnsClients();
            tableauClients.Refresh();
        }        
        public void orderColumnsClients()
        {
            tableauClients.Columns["Nom"].DisplayIndex = 0;
            tableauClients.Columns["Prenom"].DisplayIndex = 1;
            tableauClients.Columns["NbCommandes"].DisplayIndex = 2;
            tableauClients.Columns["AchatCumule"].DisplayIndex = 3;
            tableauClients.Columns["Adresse"].DisplayIndex = 4;
            tableauClients.Columns["AdresseMail"].DisplayIndex = 5;
            tableauClients.Columns["Telephone"].DisplayIndex = 6;
            tableauClients.Columns["DateDeNaissance"].DisplayIndex = 7;
            tableauClients.Refresh();
        }

        private void tableauClients_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = tableauClients.Columns[e.ColumnIndex].Name;
            tableauClients.DataSource = null;
            tableauClients.DataSource = new BindingSource(DataBase.clients.OrderBy(c => c.GetType().GetProperty(columnName)?.GetValue(c)).ToList(), null);
            
            orderColumnsClients();
        }
        private void buttonAjouterClient_Click(object sender, EventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm();
            addClientForm.FormClosed += addClientForm_FormClosed;
            addClientForm.ShowDialog();
        }
        private void addClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            updateTabClient();
        }
        private void addCommandeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            updateTabCommandes();
        }

        public string get_names_client()
        {
            string r = "";

            for (int i = 0; i < DataBase.clients.Count; i++)
                r += DataBase.clients[i].Nom + " " + DataBase.clients[i].Prenom + "\n";

            return r;
        }

        private void buttonDeleteClient_Click(object sender, EventArgs e)
        {
            string prenomClient = InputBox("Supprimer Client", "Entrer le prénom du client à supprimer: ");
            if (!string.IsNullOrWhiteSpace(prenomClient))
            {
                string nomClient = InputBox("Supprimer Client", $"Entrer le nom de famille de {prenomClient} pour le supprimer :");

                // If the user clicked OK, find the client in the data source and delete it
                if (!string.IsNullOrWhiteSpace(nomClient))
                {
                    Client clientToDelete = DataBase.clients.FirstOrDefault(c => c.Nom == nomClient);
                    if (clientToDelete != null)
                    {
                        DataBase.clients.Remove(clientToDelete);
                        updateTabClient();
                    }
                    else
                    {
                        MessageBox.Show("Client not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        private void tableauClients_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Get the row index of the clicked cell
                int rowIndex = e.RowIndex;

                // Check if the click was on a valid row (not the row header or an empty row)
                if (rowIndex >= 0 && rowIndex < tableauClients.Rows.Count)
                {
                    // Get the client object for the clicked row
                    Client client = (Client)tableauClients.Rows[rowIndex].DataBoundItem;

                    // Show a context menu with options to delete or update the client
                    ContextMenuStrip contextMenu = new ContextMenuStrip();
                    contextMenu.Items.Add("Supprimer client").Click += (s, ev) => DeleteClient(client);
                    contextMenu.Items.Add("Modifier client").Click += (s, ev) => UpdateClient(client);
                    contextMenu.Show(Cursor.Position);
                }
            }
        }
        private void DeleteClient(Client client)
        {
            DataBase.clients.Remove(client);
            updateTabClient();
        }

        private void UpdateClient(Client client)
        {
            List<string> props = GetProperties(client);

            string[] infos = InputBoxWithList("Modifier CLient", "Choisissez le champs à modifier puis choisissez la valeur", props).Split('|');
            if (infos.Length <= 1) return; 
            string nameProp = infos[0];
            string newValue = infos[1];

            SetPropertyValue(client, nameProp, newValue);
            updateTabClient();
        }

        #endregion

        #region Salaries

        private void buttonShowOrganigramme_Click(object sender, EventArgs e)
        {
            updateOrganigramme();
        }

        void updateOrganigramme()
        {
            OrganigrammeLabel.Text = DataBase.ShowOrganigramme(DataBase.Organigramme);
        }
        private void addSalarieForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            updateOrganigramme();
            updateTabSalarie();
        }
        private void datagvSalarie_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = datagvSalarie.Columns[e.ColumnIndex].Name;
            datagvSalarie.DataSource = null;
            datagvSalarie.DataSource = new BindingSource(DataBase.salaries.OrderBy(c => c.GetType().GetProperty(columnName)?.GetValue(c)).ToList(), null);

            orderColumnsSalaries();
        }
        public void updateTabSalarie()
        {
            datagvSalarie.AutoGenerateColumns = false;
            datagvSalarie.DataSource = null;
            datagvSalarie.DataSource = DataBase.salaries;
            datagvSalarie.AutoGenerateColumns = true;
            orderColumnsSalaries();
            updateOrganigramme();
            tabSalarie.Refresh();
        }
        public void orderColumnsSalaries()
        {
            datagvSalarie.Columns["Nom"].DisplayIndex = 0;
            datagvSalarie.Columns["Prenom"].DisplayIndex = 1;
            datagvSalarie.Columns["poste"].DisplayIndex = 2;
            datagvSalarie.Columns["salaire"].DisplayIndex = 3;
            datagvSalarie.Columns["Adresse"].DisplayIndex = 4;
            datagvSalarie.Columns["AdresseMail"].DisplayIndex = 5;
            datagvSalarie.Columns["Telephone"].DisplayIndex = 6;
            datagvSalarie.Columns["DateDeNaissance"].DisplayIndex = 7;
            datagvSalarie.Refresh();
        }

        private void buttonAddSalarie_Click(object sender, EventArgs e)
        {
            AddSalarie addSalarieForm = new AddSalarie();
            addSalarieForm.FormClosed += addSalarieForm_FormClosed;
            addSalarieForm.ShowDialog();
        }
        private void UpdateSalarie(Salarie sal)
        {
            List<string> props = GetProperties(sal);

            string[] infos = InputBoxWithList("Modifier Salarié", "Choisissez le champs à modifier puis choisissez la valeur", props).Split('|');
            if (infos.Length <= 1) return;
            string nameProp = infos[0];
            string newValue = infos[1];

            SetPropertyValue(sal, nameProp, newValue);
            updateTabSalarie();
        }
        void RemoveSalarie(Salarie salarie)
        {
            if (salarie.noms == DataBase.Organigramme.noms)
            {
                MessageBox.Show("Test");
            }
            DataBase.RemoveSalarie(salarie);
            updateTabSalarie();
        }

        private void datagvSalarie_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Get the row index of the clicked cell
                int rowIndex = e.RowIndex;

                // Check if the click was on a valid row (not the row header or an empty row)
                if (rowIndex >= 0 && rowIndex < datagvSalarie.Rows.Count)
                {
                    Salarie salarie = (Salarie)datagvSalarie.Rows[rowIndex].DataBoundItem;

                    ContextMenuStrip contextMenu = new ContextMenuStrip();
                    contextMenu.Items.Add("Supprimer salarie").Click += (s, ev) => RemoveSalarie(salarie);
                    contextMenu.Items.Add("Modifier salarie").Click += (s, ev) => UpdateSalarie(salarie);
                    contextMenu.Show(Cursor.Position);
                }
            }
        }

        #endregion

        #region Commandes


        void updateTabCommandes()
        {
            datagvCommandes.AutoGenerateColumns = false;
            datagvCommandes.DataSource = null;
            datagvCommandes.DataSource = DataBase.commandes;
            datagvCommandes.AutoGenerateColumns = true;
            orderColumnsCommandes();
            tabCommande.Refresh();
        }
        public void orderColumnsCommandes()
        {
            datagvCommandes.Columns["AdresseA"].DisplayIndex = 0;
            datagvCommandes.Columns["AdresseB"].DisplayIndex = 1;
            datagvCommandes.Columns["Prix"].DisplayIndex = 2;
            datagvCommandes.Columns["Distance"].DisplayIndex = 3;
            datagvCommandes.Columns["tempsFormated"].DisplayIndex = 4;
            datagvCommandes.Columns["Chauffeur"].DisplayIndex = 5;
            datagvCommandes.Columns["Vehicule"].DisplayIndex = 6;
            datagvCommandes.Columns["Date"].DisplayIndex = 7;
            datagvCommandes.Refresh();
        }




        private void buttonRefreshTabCommande_Click(object sender, EventArgs e)
        {
            updateTabCommandes();
            List<Commande.Ville> villes = DataBase.commandes[0].loadCSV("Distances.csv");
            villes.Sort();
            labelOuais.Text = string.Join("\n", villes);
        }

        #endregion

        private void buttoncommandeTest_Click(object sender, EventArgs e)
        {

            Adresse b = new Adresse("Toulon", "France");
            Adresse a = new Adresse("Paris", "France");
            Vehicule v = new Voiture(10, 10, 5);
            Chauffeur chauf = new Chauffeur("019", "Gautier", "Alice", DateTime.Parse("2009-01-01"), new Adresse("Ville Fin", "Numero Fin", "Rue Fin", "Pays Fin"), "fin@example.com", "1919191919", DateTime.Parse("2020-01-01"), 60000, 15, v);
            Commande c = new Commande(a, b, chauf, DateTime.Now);

            MessageBox.Show(c.Distance + ", " + c.tempsFormated);
        }

        private void buttonAddCommande_Click(object sender, EventArgs e)
        {
            AddCommandeForms addCommandeForm = new AddCommandeForms();
            addCommandeForm.FormClosed += addCommandeForm_FormClosed;
            addCommandeForm.ShowDialog();

        }

        private void datagvCommandes_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = datagvCommandes.Columns[e.ColumnIndex].Name;
            datagvCommandes.DataSource = null;
            datagvCommandes.DataSource = new BindingSource(DataBase.commandes.OrderBy(c => c.GetType().GetProperty(columnName)?.GetValue(c)).ToList(), null);

            orderColumnsCommandes();
        }


        void RemoveCommande(Commande commande)
        {
            DataBase.RemoveCommande(commande); 
            updateTabCommandes();
        }

        private void datagvCommandes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Get the row index of the clicked cell
                int rowIndex = e.RowIndex;

                // Check if the click was on a valid row (not the row header or an empty row)
                if (rowIndex >= 0 && rowIndex < datagvCommandes.Rows.Count)
                {
                    Commande commande = (Commande)datagvCommandes.Rows[rowIndex].DataBoundItem;

                    ContextMenuStrip contextMenu = new ContextMenuStrip();
                    contextMenu.Items.Add("Supprimer commande").Click += (s, ev) => RemoveCommande(commande);
                    contextMenu.Show(Cursor.Position);
                }
            }

        }
    }
}

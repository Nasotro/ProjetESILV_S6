﻿namespace FormsProjetS6
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAccueil = new System.Windows.Forms.TabPage();
            this.labeltest = new System.Windows.Forms.Label();
            this.buttonGenerateData = new System.Windows.Forms.Button();
            this.buttonStats = new System.Windows.Forms.Button();
            this.buttonCommande = new System.Windows.Forms.Button();
            this.buttonSalarie = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.tabClient = new System.Windows.Forms.TabPage();
            this.buttonAjouterClient = new System.Windows.Forms.Button();
            this.buttonDeleteClient = new System.Windows.Forms.Button();
            this.tableauClients = new System.Windows.Forms.DataGridView();
            this.tabSalarie = new System.Windows.Forms.TabPage();
            this.datagvSalarie = new System.Windows.Forms.DataGridView();
            this.buttonAddSalarie = new System.Windows.Forms.Button();
            this.OrganigrammeLabel = new System.Windows.Forms.Label();
            this.buttonShowOrganigramme = new System.Windows.Forms.Button();
            this.tabCommande = new System.Windows.Forms.TabPage();
            this.buttonCommandeDates = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonAddCommande = new System.Windows.Forms.Button();
            this.buttoncommandeResetTab = new System.Windows.Forms.Button();
            this.datagvCommandes = new System.Windows.Forms.DataGridView();
            this.tabStatistiques = new System.Windows.Forms.TabPage();
            this.labelMeilleurChauffeur = new System.Windows.Forms.Label();
            this.buttonAccueil = new System.Windows.Forms.Button();
            this.comboBoxListClients = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabAccueil.SuspendLayout();
            this.tabClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableauClients)).BeginInit();
            this.tabSalarie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvSalarie)).BeginInit();
            this.tabCommande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvCommandes)).BeginInit();
            this.tabStatistiques.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAccueil);
            this.tabControl1.Controls.Add(this.tabClient);
            this.tabControl1.Controls.Add(this.tabSalarie);
            this.tabControl1.Controls.Add(this.tabCommande);
            this.tabControl1.Controls.Add(this.tabStatistiques);
            this.tabControl1.Location = new System.Drawing.Point(12, 89);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(909, 437);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabAccueil
            // 
            this.tabAccueil.Controls.Add(this.labeltest);
            this.tabAccueil.Controls.Add(this.buttonGenerateData);
            this.tabAccueil.Controls.Add(this.buttonStats);
            this.tabAccueil.Controls.Add(this.buttonCommande);
            this.tabAccueil.Controls.Add(this.buttonSalarie);
            this.tabAccueil.Controls.Add(this.buttonClient);
            this.tabAccueil.Location = new System.Drawing.Point(4, 22);
            this.tabAccueil.Name = "tabAccueil";
            this.tabAccueil.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccueil.Size = new System.Drawing.Size(901, 411);
            this.tabAccueil.TabIndex = 0;
            this.tabAccueil.Text = "Accueil";
            this.tabAccueil.UseVisualStyleBackColor = true;
            // 
            // labeltest
            // 
            this.labeltest.AutoSize = true;
            this.labeltest.Location = new System.Drawing.Point(556, 160);
            this.labeltest.Name = "labeltest";
            this.labeltest.Size = new System.Drawing.Size(35, 13);
            this.labeltest.TabIndex = 5;
            this.labeltest.Text = "label1";
            // 
            // buttonGenerateData
            // 
            this.buttonGenerateData.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerateData.Location = new System.Drawing.Point(292, 65);
            this.buttonGenerateData.Name = "buttonGenerateData";
            this.buttonGenerateData.Size = new System.Drawing.Size(185, 207);
            this.buttonGenerateData.TabIndex = 4;
            this.buttonGenerateData.Text = "Generate Fake Data";
            this.buttonGenerateData.UseVisualStyleBackColor = true;
            this.buttonGenerateData.Click += new System.EventHandler(this.buttonGenerateData_Click);
            // 
            // buttonStats
            // 
            this.buttonStats.Location = new System.Drawing.Point(24, 232);
            this.buttonStats.Name = "buttonStats";
            this.buttonStats.Size = new System.Drawing.Size(133, 40);
            this.buttonStats.TabIndex = 3;
            this.buttonStats.Text = "Mode Statistiques";
            this.buttonStats.UseVisualStyleBackColor = true;
            this.buttonStats.Click += new System.EventHandler(this.buttonStats_Click);
            // 
            // buttonCommande
            // 
            this.buttonCommande.Location = new System.Drawing.Point(24, 177);
            this.buttonCommande.Name = "buttonCommande";
            this.buttonCommande.Size = new System.Drawing.Size(133, 40);
            this.buttonCommande.TabIndex = 2;
            this.buttonCommande.Text = "Mode Commande";
            this.buttonCommande.UseVisualStyleBackColor = true;
            this.buttonCommande.Click += new System.EventHandler(this.buttonCommande_Click);
            // 
            // buttonSalarie
            // 
            this.buttonSalarie.Location = new System.Drawing.Point(24, 120);
            this.buttonSalarie.Name = "buttonSalarie";
            this.buttonSalarie.Size = new System.Drawing.Size(133, 40);
            this.buttonSalarie.TabIndex = 1;
            this.buttonSalarie.Text = "Mode Salarie";
            this.buttonSalarie.UseVisualStyleBackColor = true;
            this.buttonSalarie.Click += new System.EventHandler(this.buttonSalarie_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.Location = new System.Drawing.Point(24, 65);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(133, 40);
            this.buttonClient.TabIndex = 0;
            this.buttonClient.Text = "Mode Client";
            this.buttonClient.UseVisualStyleBackColor = true;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // tabClient
            // 
            this.tabClient.Controls.Add(this.buttonAjouterClient);
            this.tabClient.Controls.Add(this.buttonDeleteClient);
            this.tabClient.Controls.Add(this.tableauClients);
            this.tabClient.Location = new System.Drawing.Point(4, 22);
            this.tabClient.Name = "tabClient";
            this.tabClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabClient.Size = new System.Drawing.Size(901, 411);
            this.tabClient.TabIndex = 1;
            this.tabClient.Text = "Client";
            this.tabClient.UseVisualStyleBackColor = true;
            // 
            // buttonAjouterClient
            // 
            this.buttonAjouterClient.Location = new System.Drawing.Point(43, 38);
            this.buttonAjouterClient.Name = "buttonAjouterClient";
            this.buttonAjouterClient.Size = new System.Drawing.Size(200, 47);
            this.buttonAjouterClient.TabIndex = 2;
            this.buttonAjouterClient.Text = "AJOUTER CLIENT";
            this.buttonAjouterClient.UseVisualStyleBackColor = true;
            this.buttonAjouterClient.Click += new System.EventHandler(this.buttonAjouterClient_Click);
            // 
            // buttonDeleteClient
            // 
            this.buttonDeleteClient.Location = new System.Drawing.Point(303, 38);
            this.buttonDeleteClient.Name = "buttonDeleteClient";
            this.buttonDeleteClient.Size = new System.Drawing.Size(200, 47);
            this.buttonDeleteClient.TabIndex = 1;
            this.buttonDeleteClient.Text = "SUPPRIMER CLIENT";
            this.buttonDeleteClient.UseVisualStyleBackColor = true;
            this.buttonDeleteClient.Click += new System.EventHandler(this.buttonDeleteClient_Click);
            // 
            // tableauClients
            // 
            this.tableauClients.AllowUserToAddRows = false;
            this.tableauClients.AllowUserToDeleteRows = false;
            this.tableauClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableauClients.Location = new System.Drawing.Point(19, 129);
            this.tableauClients.Name = "tableauClients";
            this.tableauClients.ReadOnly = true;
            this.tableauClients.RowHeadersWidth = 51;
            this.tableauClients.Size = new System.Drawing.Size(749, 218);
            this.tableauClients.TabIndex = 0;
            this.tableauClients.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tableauClients_CellMouseClick);
            this.tableauClients.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tableauClients_ColumnHeaderMouseClick);
            // 
            // tabSalarie
            // 
            this.tabSalarie.Controls.Add(this.datagvSalarie);
            this.tabSalarie.Controls.Add(this.buttonAddSalarie);
            this.tabSalarie.Controls.Add(this.OrganigrammeLabel);
            this.tabSalarie.Controls.Add(this.buttonShowOrganigramme);
            this.tabSalarie.Location = new System.Drawing.Point(4, 22);
            this.tabSalarie.Name = "tabSalarie";
            this.tabSalarie.Size = new System.Drawing.Size(901, 411);
            this.tabSalarie.TabIndex = 2;
            this.tabSalarie.Text = "Salarie";
            this.tabSalarie.UseVisualStyleBackColor = true;
            // 
            // datagvSalarie
            // 
            this.datagvSalarie.AllowUserToAddRows = false;
            this.datagvSalarie.AllowUserToDeleteRows = false;
            this.datagvSalarie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvSalarie.Location = new System.Drawing.Point(168, 98);
            this.datagvSalarie.Name = "datagvSalarie";
            this.datagvSalarie.ReadOnly = true;
            this.datagvSalarie.RowHeadersWidth = 51;
            this.datagvSalarie.Size = new System.Drawing.Size(717, 218);
            this.datagvSalarie.TabIndex = 3;
            this.datagvSalarie.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagvSalarie_CellMouseClick);
            this.datagvSalarie.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagvSalarie_ColumnHeaderMouseClick);
            // 
            // buttonAddSalarie
            // 
            this.buttonAddSalarie.Location = new System.Drawing.Point(168, 23);
            this.buttonAddSalarie.Name = "buttonAddSalarie";
            this.buttonAddSalarie.Size = new System.Drawing.Size(106, 44);
            this.buttonAddSalarie.TabIndex = 2;
            this.buttonAddSalarie.Text = "AJOUTER SALARIE";
            this.buttonAddSalarie.UseVisualStyleBackColor = true;
            this.buttonAddSalarie.Click += new System.EventHandler(this.buttonAddSalarie_Click);
            // 
            // OrganigrammeLabel
            // 
            this.OrganigrammeLabel.AutoSize = true;
            this.OrganigrammeLabel.Location = new System.Drawing.Point(26, 98);
            this.OrganigrammeLabel.Name = "OrganigrammeLabel";
            this.OrganigrammeLabel.Size = new System.Drawing.Size(75, 13);
            this.OrganigrammeLabel.TabIndex = 1;
            this.OrganigrammeLabel.Text = "Organigramme";
            // 
            // buttonShowOrganigramme
            // 
            this.buttonShowOrganigramme.Location = new System.Drawing.Point(18, 21);
            this.buttonShowOrganigramme.Name = "buttonShowOrganigramme";
            this.buttonShowOrganigramme.Size = new System.Drawing.Size(106, 46);
            this.buttonShowOrganigramme.TabIndex = 0;
            this.buttonShowOrganigramme.Text = "AFICHER ORGANIGRAMME";
            this.buttonShowOrganigramme.UseVisualStyleBackColor = true;
            this.buttonShowOrganigramme.Click += new System.EventHandler(this.buttonShowOrganigramme_Click);
            // 
            // tabCommande
            // 
            this.tabCommande.Controls.Add(this.panel1);
            this.tabCommande.Controls.Add(this.label1);
            this.tabCommande.Controls.Add(this.comboBoxListClients);
            this.tabCommande.Controls.Add(this.buttonAddCommande);
            this.tabCommande.Controls.Add(this.buttoncommandeResetTab);
            this.tabCommande.Controls.Add(this.datagvCommandes);
            this.tabCommande.Location = new System.Drawing.Point(4, 22);
            this.tabCommande.Name = "tabCommande";
            this.tabCommande.Size = new System.Drawing.Size(901, 411);
            this.tabCommande.TabIndex = 3;
            this.tabCommande.Text = "commande";
            this.tabCommande.UseVisualStyleBackColor = true;
            // 
            // buttonCommandeDates
            // 
            this.buttonCommandeDates.Location = new System.Drawing.Point(11, 89);
            this.buttonCommandeDates.Name = "buttonCommandeDates";
            this.buttonCommandeDates.Size = new System.Drawing.Size(130, 42);
            this.buttonCommandeDates.TabIndex = 7;
            this.buttonCommandeDates.Text = "Filtrer les commandes avec les dates";
            this.buttonCommandeDates.UseVisualStyleBackColor = true;
            this.buttonCommandeDates.Click += new System.EventHandler(this.buttonCommandeDates_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(21, 53);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(105, 20);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(21, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // buttonAddCommande
            // 
            this.buttonAddCommande.Location = new System.Drawing.Point(551, 33);
            this.buttonAddCommande.Name = "buttonAddCommande";
            this.buttonAddCommande.Size = new System.Drawing.Size(131, 33);
            this.buttonAddCommande.TabIndex = 4;
            this.buttonAddCommande.Text = "Ajouter Commande";
            this.buttonAddCommande.UseVisualStyleBackColor = true;
            this.buttonAddCommande.Click += new System.EventHandler(this.buttonAddCommande_Click);
            // 
            // buttoncommandeResetTab
            // 
            this.buttoncommandeResetTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncommandeResetTab.Location = new System.Drawing.Point(18, 19);
            this.buttoncommandeResetTab.Name = "buttoncommandeResetTab";
            this.buttoncommandeResetTab.Size = new System.Drawing.Size(130, 55);
            this.buttoncommandeResetTab.TabIndex = 3;
            this.buttoncommandeResetTab.Text = "Retirer filtres";
            this.buttoncommandeResetTab.UseVisualStyleBackColor = true;
            this.buttoncommandeResetTab.Click += new System.EventHandler(this.buttoncommandeFiltreDate_Click);
            // 
            // datagvCommandes
            // 
            this.datagvCommandes.AllowUserToAddRows = false;
            this.datagvCommandes.AllowUserToDeleteRows = false;
            this.datagvCommandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvCommandes.Location = new System.Drawing.Point(172, 80);
            this.datagvCommandes.Name = "datagvCommandes";
            this.datagvCommandes.ReadOnly = true;
            this.datagvCommandes.RowHeadersWidth = 51;
            this.datagvCommandes.Size = new System.Drawing.Size(701, 249);
            this.datagvCommandes.TabIndex = 1;
            this.datagvCommandes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagvCommandes_CellMouseClick);
            this.datagvCommandes.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagvCommandes_ColumnHeaderMouseClick);
            // 
            // tabStatistiques
            // 
            this.tabStatistiques.Controls.Add(this.labelMeilleurChauffeur);
            this.tabStatistiques.Location = new System.Drawing.Point(4, 22);
            this.tabStatistiques.Name = "tabStatistiques";
            this.tabStatistiques.Size = new System.Drawing.Size(901, 411);
            this.tabStatistiques.TabIndex = 4;
            this.tabStatistiques.Text = "statistiques";
            this.tabStatistiques.UseVisualStyleBackColor = true;
            // 
            // labelMeilleurChauffeur
            // 
            this.labelMeilleurChauffeur.AutoSize = true;
            this.labelMeilleurChauffeur.Location = new System.Drawing.Point(64, 40);
            this.labelMeilleurChauffeur.Name = "labelMeilleurChauffeur";
            this.labelMeilleurChauffeur.Size = new System.Drawing.Size(130, 65);
            this.labelMeilleurChauffeur.TabIndex = 0;
            this.labelMeilleurChauffeur.Text = "Meilleur Chauffeur : \r\nMeilleur Client :\r\nNombre de commandes : \r\nNombre de salar" +
    "ies :\r\nMoyenne prix commandes\r\n";
            // 
            // buttonAccueil
            // 
            this.buttonAccueil.Location = new System.Drawing.Point(357, 12);
            this.buttonAccueil.Name = "buttonAccueil";
            this.buttonAccueil.Size = new System.Drawing.Size(111, 55);
            this.buttonAccueil.TabIndex = 2;
            this.buttonAccueil.Text = "ACCUEIL";
            this.buttonAccueil.UseVisualStyleBackColor = true;
            this.buttonAccueil.Click += new System.EventHandler(this.buttonAccueil_Click);
            // 
            // comboBoxListClients
            // 
            this.comboBoxListClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxListClients.FormattingEnabled = true;
            this.comboBoxListClients.Location = new System.Drawing.Point(22, 270);
            this.comboBoxListClients.Name = "comboBoxListClients";
            this.comboBoxListClients.Size = new System.Drawing.Size(130, 21);
            this.comboBoxListClients.TabIndex = 8;
            this.comboBoxListClients.SelectedIndexChanged += new System.EventHandler(this.comboBoxListClients_SelectedIndexChanged);
            this.comboBoxListClients.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxListClients_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Choisir un client";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.buttonCommandeDates);
            this.panel1.Location = new System.Drawing.Point(3, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 143);
            this.panel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 575);
            this.Controls.Add(this.buttonAccueil);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabAccueil.ResumeLayout(false);
            this.tabAccueil.PerformLayout();
            this.tabClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableauClients)).EndInit();
            this.tabSalarie.ResumeLayout(false);
            this.tabSalarie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvSalarie)).EndInit();
            this.tabCommande.ResumeLayout(false);
            this.tabCommande.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvCommandes)).EndInit();
            this.tabStatistiques.ResumeLayout(false);
            this.tabStatistiques.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAccueil;
        private System.Windows.Forms.TabPage tabClient;
        private System.Windows.Forms.TabPage tabSalarie;
        private System.Windows.Forms.TabPage tabCommande;
        private System.Windows.Forms.TabPage tabStatistiques;
        private System.Windows.Forms.Button buttonSalarie;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonStats;
        private System.Windows.Forms.Button buttonCommande;
        private System.Windows.Forms.Button buttonAccueil;
        private System.Windows.Forms.Button buttonGenerateData;
        private System.Windows.Forms.DataGridView tableauClients;
        private System.Windows.Forms.Button buttonAjouterClient;
        private System.Windows.Forms.Button buttonDeleteClient;
        private System.Windows.Forms.Label labeltest;
        private System.Windows.Forms.Button buttonShowOrganigramme;
        private System.Windows.Forms.Label OrganigrammeLabel;
        private System.Windows.Forms.Button buttonAddSalarie;
        private System.Windows.Forms.DataGridView datagvSalarie;
        private System.Windows.Forms.DataGridView datagvCommandes;
        private System.Windows.Forms.Button buttoncommandeResetTab;
        private System.Windows.Forms.Button buttonAddCommande;
        private System.Windows.Forms.Label labelMeilleurChauffeur;
        private System.Windows.Forms.Button buttonCommandeDates;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxListClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}


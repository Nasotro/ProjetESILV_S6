namespace FormsProjetS6
{
    partial class AddCommandeForms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxAdresseA = new System.Windows.Forms.ComboBox();
            this.comboBoxChauffeur = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerCommande = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCLient = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCreateCommande = new System.Windows.Forms.Button();
            this.comboBoxAdresseB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxAdresseA
            // 
            this.comboBoxAdresseA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdresseA.FormattingEnabled = true;
            this.comboBoxAdresseA.Location = new System.Drawing.Point(144, 173);
            this.comboBoxAdresseA.Name = "comboBoxAdresseA";
            this.comboBoxAdresseA.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAdresseA.TabIndex = 0;
            // 
            // comboBoxChauffeur
            // 
            this.comboBoxChauffeur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChauffeur.FormattingEnabled = true;
            this.comboBoxChauffeur.Location = new System.Drawing.Point(144, 257);
            this.comboBoxChauffeur.Name = "comboBoxChauffeur";
            this.comboBoxChauffeur.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChauffeur.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ville Arrivee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ville Départ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chauffeur";
            // 
            // dateTimePickerCommande
            // 
            this.dateTimePickerCommande.Location = new System.Drawing.Point(44, 91);
            this.dateTimePickerCommande.Name = "dateTimePickerCommande";
            this.dateTimePickerCommande.Size = new System.Drawing.Size(186, 20);
            this.dateTimePickerCommande.TabIndex = 8;
            this.dateTimePickerCommande.ValueChanged += new System.EventHandler(this.dateTimePickerCommande_ValueChanged);
            // 
            // comboBoxCLient
            // 
            this.comboBoxCLient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCLient.FormattingEnabled = true;
            this.comboBoxCLient.Location = new System.Drawing.Point(144, 133);
            this.comboBoxCLient.Name = "comboBoxCLient";
            this.comboBoxCLient.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCLient.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Client";
            // 
            // buttonCreateCommande
            // 
            this.buttonCreateCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateCommande.Location = new System.Drawing.Point(385, 118);
            this.buttonCreateCommande.Name = "buttonCreateCommande";
            this.buttonCreateCommande.Size = new System.Drawing.Size(179, 200);
            this.buttonCreateCommande.TabIndex = 11;
            this.buttonCreateCommande.Text = "Creer Commande";
            this.buttonCreateCommande.UseVisualStyleBackColor = true;
            this.buttonCreateCommande.Click += new System.EventHandler(this.buttonCreateCommande_Click);
            // 
            // comboBoxAdresseB
            // 
            this.comboBoxAdresseB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdresseB.FormattingEnabled = true;
            this.comboBoxAdresseB.Location = new System.Drawing.Point(144, 217);
            this.comboBoxAdresseB.Name = "comboBoxAdresseB";
            this.comboBoxAdresseB.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAdresseB.TabIndex = 12;
            // 
            // AddCommandeForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxAdresseB);
            this.Controls.Add(this.buttonCreateCommande);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxCLient);
            this.Controls.Add(this.dateTimePickerCommande);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxChauffeur);
            this.Controls.Add(this.comboBoxAdresseA);
            this.Name = "AddCommandeForms";
            this.Text = "AddCommandeForms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAdresseA;
        private System.Windows.Forms.ComboBox comboBoxChauffeur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerCommande;
        private System.Windows.Forms.ComboBox comboBoxCLient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCreateCommande;
        private System.Windows.Forms.ComboBox comboBoxAdresseB;
    }
}
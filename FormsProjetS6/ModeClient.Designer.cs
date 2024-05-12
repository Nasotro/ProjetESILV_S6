namespace FormsProjetS6
{
    partial class ModeClient
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
            this.button_add_client = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_add_client
            // 
            this.button_add_client.Location = new System.Drawing.Point(329, 75);
            this.button_add_client.Name = "button_add_client";
            this.button_add_client.Size = new System.Drawing.Size(110, 39);
            this.button_add_client.TabIndex = 0;
            this.button_add_client.Text = "ajouter client";
            this.button_add_client.UseVisualStyleBackColor = true;
            // 
            // ModeClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_add_client);
            this.Name = "ModeClient";
            this.Text = "ModeClient";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_add_client;
    }
}
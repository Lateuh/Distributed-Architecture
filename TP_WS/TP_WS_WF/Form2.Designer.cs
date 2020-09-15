namespace TP_WS_WF
{
    partial class Form2
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
            this.listOffres = new System.Windows.Forms.ListBox();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.buttonVoir = new System.Windows.Forms.Button();
            this.Nom = new System.Windows.Forms.Label();
            this.TBNom = new System.Windows.Forms.TextBox();
            this.Prenom = new System.Windows.Forms.Label();
            this.TBPrenom = new System.Windows.Forms.TextBox();
            this.NumCB = new System.Windows.Forms.Label();
            this.TBNumCB = new System.Windows.Forms.TextBox();
            this.ButtonReserver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listOffres
            // 
            this.listOffres.FormattingEnabled = true;
            this.listOffres.Location = new System.Drawing.Point(0, 0);
            this.listOffres.Name = "listOffres";
            this.listOffres.Size = new System.Drawing.Size(788, 199);
            this.listOffres.TabIndex = 0;
            // 
            // buttonRetour
            // 
            this.buttonRetour.Location = new System.Drawing.Point(15, 327);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(186, 81);
            this.buttonRetour.TabIndex = 1;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = true;
            this.buttonRetour.Click += new System.EventHandler(this.ButtonRetour_Click);
            // 
            // buttonVoir
            // 
            this.buttonVoir.Location = new System.Drawing.Point(243, 327);
            this.buttonVoir.Name = "buttonVoir";
            this.buttonVoir.Size = new System.Drawing.Size(201, 81);
            this.buttonVoir.TabIndex = 2;
            this.buttonVoir.Text = "Voir chambre";
            this.buttonVoir.UseVisualStyleBackColor = true;
            this.buttonVoir.Click += new System.EventHandler(this.ButtonVoir_Click);
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(12, 230);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(29, 13);
            this.Nom.TabIndex = 8;
            this.Nom.Text = "Nom";
            // 
            // TBNom
            // 
            this.TBNom.Location = new System.Drawing.Point(61, 230);
            this.TBNom.Name = "TBNom";
            this.TBNom.Size = new System.Drawing.Size(100, 20);
            this.TBNom.TabIndex = 11;
            // 
            // Prenom
            // 
            this.Prenom.AutoSize = true;
            this.Prenom.Location = new System.Drawing.Point(12, 264);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(43, 13);
            this.Prenom.TabIndex = 12;
            this.Prenom.Text = "Prenom";
            // 
            // TBPrenom
            // 
            this.TBPrenom.Location = new System.Drawing.Point(61, 264);
            this.TBPrenom.Name = "TBPrenom";
            this.TBPrenom.Size = new System.Drawing.Size(100, 20);
            this.TBPrenom.TabIndex = 13;
            // 
            // NumCB
            // 
            this.NumCB.AutoSize = true;
            this.NumCB.Location = new System.Drawing.Point(12, 301);
            this.NumCB.Name = "NumCB";
            this.NumCB.Size = new System.Drawing.Size(43, 13);
            this.NumCB.TabIndex = 14;
            this.NumCB.Text = "NumCB";
            // 
            // TBNumCB
            // 
            this.TBNumCB.Location = new System.Drawing.Point(61, 301);
            this.TBNumCB.Name = "TBNumCB";
            this.TBNumCB.Size = new System.Drawing.Size(100, 20);
            this.TBNumCB.TabIndex = 15;
            // 
            // ButtonReserver
            // 
            this.ButtonReserver.Location = new System.Drawing.Point(489, 327);
            this.ButtonReserver.Name = "ButtonReserver";
            this.ButtonReserver.Size = new System.Drawing.Size(224, 81);
            this.ButtonReserver.TabIndex = 16;
            this.ButtonReserver.Text = "Réserver";
            this.ButtonReserver.UseVisualStyleBackColor = true;
            this.ButtonReserver.Click += new System.EventHandler(this.ButtonReserver_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonReserver);
            this.Controls.Add(this.TBNumCB);
            this.Controls.Add(this.NumCB);
            this.Controls.Add(this.TBPrenom);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.TBNom);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.buttonVoir);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.listOffres);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listOffres;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.Button buttonVoir;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.TextBox TBNom;
        private System.Windows.Forms.Label Prenom;
        private System.Windows.Forms.TextBox TBPrenom;
        private System.Windows.Forms.Label NumCB;
        private System.Windows.Forms.TextBox TBNumCB;
        private System.Windows.Forms.Button ButtonReserver;
    }
}
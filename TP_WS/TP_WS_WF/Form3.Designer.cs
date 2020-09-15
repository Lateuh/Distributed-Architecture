namespace TP_WS_WF
{
    partial class Form3
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
            this.buttonAffiche = new System.Windows.Forms.Button();
            this.ButtonValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAffiche
            // 
            this.buttonAffiche.Location = new System.Drawing.Point(12, 12);
            this.buttonAffiche.Name = "buttonAffiche";
            this.buttonAffiche.Size = new System.Drawing.Size(117, 34);
            this.buttonAffiche.TabIndex = 0;
            this.buttonAffiche.Text = "Afficher photo";
            this.buttonAffiche.UseVisualStyleBackColor = true;
            this.buttonAffiche.Click += new System.EventHandler(this.buttonAffiche_Click);
            // 
            // ButtonValider
            // 
            this.ButtonValider.Location = new System.Drawing.Point(190, 12);
            this.ButtonValider.Name = "ButtonValider";
            this.ButtonValider.Size = new System.Drawing.Size(141, 34);
            this.ButtonValider.TabIndex = 1;
            this.ButtonValider.Text = "Valider réservation";
            this.ButtonValider.UseVisualStyleBackColor = true;
            this.ButtonValider.Click += new System.EventHandler(this.ButtonValider_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 611);
            this.Controls.Add(this.ButtonValider);
            this.Controls.Add(this.buttonAffiche);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAffiche;
        private System.Windows.Forms.Button ButtonValider;
    }
}
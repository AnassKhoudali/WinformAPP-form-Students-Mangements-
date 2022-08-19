
namespace GestionNotesEtudiants
{
    partial class Acceuil
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVoirResultatsEtudiant = new System.Windows.Forms.Button();
            this.btnDonnerNote = new System.Windows.Forms.Button();
            this.btnInscrireEtudiantCours = new System.Windows.Forms.Button();
            this.btnAjouterCours = new System.Windows.Forms.Button();
            this.btnAjouterEtudiant = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVoirResultatsEtudiant);
            this.panel1.Controls.Add(this.btnDonnerNote);
            this.panel1.Controls.Add(this.btnInscrireEtudiantCours);
            this.panel1.Controls.Add(this.btnAjouterCours);
            this.panel1.Controls.Add(this.btnAjouterEtudiant);
            this.panel1.Location = new System.Drawing.Point(-2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 622);
            this.panel1.TabIndex = 0;
            // 
            // btnVoirResultatsEtudiant
            // 
            this.btnVoirResultatsEtudiant.Location = new System.Drawing.Point(0, 410);
            this.btnVoirResultatsEtudiant.Name = "btnVoirResultatsEtudiant";
            this.btnVoirResultatsEtudiant.Size = new System.Drawing.Size(283, 49);
            this.btnVoirResultatsEtudiant.TabIndex = 7;
            this.btnVoirResultatsEtudiant.Text = "voir les résultats d\'un étudiant";
            this.btnVoirResultatsEtudiant.UseVisualStyleBackColor = true;
            this.btnVoirResultatsEtudiant.Click += new System.EventHandler(this.btnVoirResultatsEtudiant_Click_1);
            // 
            // btnDonnerNote
            // 
            this.btnDonnerNote.Location = new System.Drawing.Point(0, 341);
            this.btnDonnerNote.Name = "btnDonnerNote";
            this.btnDonnerNote.Size = new System.Drawing.Size(283, 49);
            this.btnDonnerNote.TabIndex = 6;
            this.btnDonnerNote.Text = "Noter un étudiant";
            this.btnDonnerNote.UseVisualStyleBackColor = true;
            this.btnDonnerNote.Click += new System.EventHandler(this.btnDonnerNote_Click_1);
            // 
            // btnInscrireEtudiantCours
            // 
            this.btnInscrireEtudiantCours.Location = new System.Drawing.Point(0, 273);
            this.btnInscrireEtudiantCours.Name = "btnInscrireEtudiantCours";
            this.btnInscrireEtudiantCours.Size = new System.Drawing.Size(283, 49);
            this.btnInscrireEtudiantCours.TabIndex = 5;
            this.btnInscrireEtudiantCours.Text = "Inscrire un étudiant a un cours";
            this.btnInscrireEtudiantCours.UseVisualStyleBackColor = true;
            this.btnInscrireEtudiantCours.Click += new System.EventHandler(this.btnInscrireEtudiantCours_Click_1);
            // 
            // btnAjouterCours
            // 
            this.btnAjouterCours.Location = new System.Drawing.Point(0, 205);
            this.btnAjouterCours.Name = "btnAjouterCours";
            this.btnAjouterCours.Size = new System.Drawing.Size(283, 49);
            this.btnAjouterCours.TabIndex = 4;
            this.btnAjouterCours.Text = "Ajouter un nouveau cours";
            this.btnAjouterCours.UseVisualStyleBackColor = true;
            this.btnAjouterCours.Click += new System.EventHandler(this.btnAjouterCours_Click_1);
            // 
            // btnAjouterEtudiant
            // 
            this.btnAjouterEtudiant.Location = new System.Drawing.Point(0, 139);
            this.btnAjouterEtudiant.Name = "btnAjouterEtudiant";
            this.btnAjouterEtudiant.Size = new System.Drawing.Size(283, 49);
            this.btnAjouterEtudiant.TabIndex = 3;
            this.btnAjouterEtudiant.Text = "Ajouter un étudiant";
            this.btnAjouterEtudiant.UseVisualStyleBackColor = true;
            this.btnAjouterEtudiant.Click += new System.EventHandler(this.btnAjouterEtudiant_Click);
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 625);
            this.Controls.Add(this.panel1);
            this.Name = "Acceuil";
            this.Text = "Acceuil";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInscrireEtudiantCours;
        private System.Windows.Forms.Button btnAjouterCours;
        private System.Windows.Forms.Button btnAjouterEtudiant;
        private System.Windows.Forms.Button btnVoirResultatsEtudiant;
        private System.Windows.Forms.Button btnDonnerNote;
    }
}
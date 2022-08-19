
namespace GestionNotesEtudiants
{
    partial class ajouterNouvelEtudiant
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
            this.prenomTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nomTxt = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnAjouterEtudiant = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prenomTxt
            // 
            this.prenomTxt.Location = new System.Drawing.Point(255, 122);
            this.prenomTxt.Name = "prenomTxt";
            this.prenomTxt.Size = new System.Drawing.Size(446, 31);
            this.prenomTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prénom";
            // 
            // nomTxt
            // 
            this.nomTxt.AutoSize = true;
            this.nomTxt.Location = new System.Drawing.Point(131, 197);
            this.nomTxt.Name = "nomTxt";
            this.nomTxt.Size = new System.Drawing.Size(52, 25);
            this.nomTxt.TabIndex = 3;
            this.nomTxt.Text = "Nom";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(255, 191);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(446, 31);
            this.textBox3.TabIndex = 5;
            // 
            // btnAjouterEtudiant
            // 
            this.btnAjouterEtudiant.Location = new System.Drawing.Point(363, 335);
            this.btnAjouterEtudiant.Name = "btnAjouterEtudiant";
            this.btnAjouterEtudiant.Size = new System.Drawing.Size(112, 34);
            this.btnAjouterEtudiant.TabIndex = 4;
            this.btnAjouterEtudiant.Text = "Ajouter";
            this.btnAjouterEtudiant.UseVisualStyleBackColor = true;
            this.btnAjouterEtudiant.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(63, 28);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(112, 34);
            this.btnRetour.TabIndex = 9;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // ajouterNouvelEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 544);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnAjouterEtudiant);
            this.Controls.Add(this.nomTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prenomTxt);
            this.Name = "ajouterNouvelEtudiant";
            this.Text = "Ajouter un nouvel étudiant à une liste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox prenomTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnAjouterEtudiant;
        private System.Windows.Forms.Label nomTxt;
        private System.Windows.Forms.Button btnRetour;
    }
}
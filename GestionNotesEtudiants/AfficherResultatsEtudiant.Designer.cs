
namespace GestionNotesEtudiants
{
    partial class AfficherResultatsEtudiant
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
            this.numeroEtudiantTxt = new System.Windows.Forms.TextBox();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numeroEtudiantTxt
            // 
            this.numeroEtudiantTxt.Location = new System.Drawing.Point(197, 159);
            this.numeroEtudiantTxt.Name = "numeroEtudiantTxt";
            this.numeroEtudiantTxt.PlaceholderText = "Vous pouvez chercher également avec le nom ou le pénom.";
            this.numeroEtudiantTxt.Size = new System.Drawing.Size(500, 31);
            this.numeroEtudiantTxt.TabIndex = 0;
            this.numeroEtudiantTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(350, 331);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(143, 34);
            this.btnAfficher.TabIndex = 1;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numéro d\'étudiant";
            this.label1.Click += new System.EventHandler(this.numeroEtudiantTxt_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(31, 40);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(143, 34);
            this.btnRetour.TabIndex = 3;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // AfficherResultatsEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 544);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.numeroEtudiantTxt);
            this.Name = "AfficherResultatsEtudiant";
            this.Text = "Afficher les résultats d\'un étudiant.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numeroEtudiantTxt;
        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRetour;
    }
}
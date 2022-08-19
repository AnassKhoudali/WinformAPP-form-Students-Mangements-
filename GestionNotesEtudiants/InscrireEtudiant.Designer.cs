
namespace GestionNotesEtudiants
{
    partial class InscrireEtudiant
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
            this.btnInscrire = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.numeroCoursTxt = new System.Windows.Forms.TextBox();
            this.numeroEtudiantTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labe2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInscrire
            // 
            this.btnInscrire.Location = new System.Drawing.Point(325, 352);
            this.btnInscrire.Name = "btnInscrire";
            this.btnInscrire.Size = new System.Drawing.Size(112, 34);
            this.btnInscrire.TabIndex = 0;
            this.btnInscrire.Text = "Inscrire";
            this.btnInscrire.UseVisualStyleBackColor = true;
            this.btnInscrire.Click += new System.EventHandler(this.btnInscrire_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(30, 27);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(112, 34);
            this.btnRetour.TabIndex = 1;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // numeroCoursTxt
            // 
            this.numeroCoursTxt.Location = new System.Drawing.Point(300, 197);
            this.numeroCoursTxt.Name = "numeroCoursTxt";
            this.numeroCoursTxt.PlaceholderText = "Donner le numéro ou le code de cours ";
            this.numeroCoursTxt.Size = new System.Drawing.Size(501, 31);
            this.numeroCoursTxt.TabIndex = 2;
            // 
            // numeroEtudiantTxt
            // 
            this.numeroEtudiantTxt.Location = new System.Drawing.Point(300, 99);
            this.numeroEtudiantTxt.Name = "numeroEtudiantTxt";
            this.numeroEtudiantTxt.PlaceholderText = "Donner le numéro de l\'étudiant";
            this.numeroEtudiantTxt.Size = new System.Drawing.Size(501, 31);
            this.numeroEtudiantTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numéro ou code de cours";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labe2
            // 
            this.labe2.AutoSize = true;
            this.labe2.Location = new System.Drawing.Point(30, 99);
            this.labe2.Name = "labe2";
            this.labe2.Size = new System.Drawing.Size(162, 25);
            this.labe2.TabIndex = 5;
            this.labe2.Text = "Numéro d\'étudiant";
            // 
            // InscrireEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 544);
            this.Controls.Add(this.labe2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeroEtudiantTxt);
            this.Controls.Add(this.numeroCoursTxt);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnInscrire);
            this.Name = "InscrireEtudiant";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInscrire;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.TextBox numeroCoursTxt;
        private System.Windows.Forms.TextBox numeroEtudiantTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labe2;
    }
}
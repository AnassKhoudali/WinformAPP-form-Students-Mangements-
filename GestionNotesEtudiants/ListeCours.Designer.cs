
namespace GestionNotesEtudiants
{
    partial class ListeCours
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
            this.btnCreer = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnParcourir = new System.Windows.Forms.Button();
            this.lienTxt = new System.Windows.Forms.TextBox();
            this.nomTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(368, 325);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(112, 34);
            this.btnCreer.TabIndex = 0;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(30, 24);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(112, 34);
            this.btnRetour.TabIndex = 1;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnParcourir
            // 
            this.btnParcourir.Location = new System.Drawing.Point(721, 105);
            this.btnParcourir.Name = "btnParcourir";
            this.btnParcourir.Size = new System.Drawing.Size(112, 34);
            this.btnParcourir.TabIndex = 2;
            this.btnParcourir.Text = "Parcourir";
            this.btnParcourir.UseVisualStyleBackColor = true;
            this.btnParcourir.Click += new System.EventHandler(this.btnParcourir_Click);
            // 
            // lienTxt
            // 
            this.lienTxt.Location = new System.Drawing.Point(172, 108);
            this.lienTxt.Name = "lienTxt";
            this.lienTxt.PlaceholderText = "Emplacement du dossier sur cet ordinateur";
            this.lienTxt.Size = new System.Drawing.Size(516, 31);
            this.lienTxt.TabIndex = 3;
            // 
            // nomTxt
            // 
            this.nomTxt.Location = new System.Drawing.Point(172, 163);
            this.nomTxt.Name = "nomTxt";
            this.nomTxt.PlaceholderText = "Donner un nom a votre nouvelle liste d\'étudiants";
            this.nomTxt.Size = new System.Drawing.Size(516, 31);
            this.nomTxt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chemin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nom";
            // 
            // ListeCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 544);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomTxt);
            this.Controls.Add(this.lienTxt);
            this.Controls.Add(this.btnParcourir);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnCreer);
            this.Name = "ListeCours";
            this.Text = "Créer une nouvel liste de cours";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnParcourir;
        private System.Windows.Forms.TextBox lienTxt;
        private System.Windows.Forms.TextBox nomTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
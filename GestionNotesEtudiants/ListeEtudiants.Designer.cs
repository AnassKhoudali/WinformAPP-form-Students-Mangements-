
namespace GestionNotesEtudiants
{
    partial class ListeEtudiants
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
            this.btnParcourir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreer = new System.Windows.Forms.Button();
            this.lienTxt = new System.Windows.Forms.TextBox();
            this.nomTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnParcourir
            // 
            this.btnParcourir.Location = new System.Drawing.Point(704, 134);
            this.btnParcourir.Margin = new System.Windows.Forms.Padding(2);
            this.btnParcourir.Name = "btnParcourir";
            this.btnParcourir.Size = new System.Drawing.Size(109, 33);
            this.btnParcourir.TabIndex = 0;
            this.btnParcourir.Text = "Parcourir ";
            this.btnParcourir.UseVisualStyleBackColor = true;
            this.btnParcourir.Click += new System.EventHandler(this.btnParcourir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chemin";
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(354, 322);
            this.btnCreer.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(109, 33);
            this.btnCreer.TabIndex = 2;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // lienTxt
            // 
            this.lienTxt.Location = new System.Drawing.Point(168, 134);
            this.lienTxt.Margin = new System.Windows.Forms.Padding(2);
            this.lienTxt.Name = "lienTxt";
            this.lienTxt.PlaceholderText = "Emplacement du dossier sur cet ordinateur";
            this.lienTxt.Size = new System.Drawing.Size(492, 31);
            this.lienTxt.TabIndex = 3;
            // 
            // nomTxt
            // 
            this.nomTxt.Location = new System.Drawing.Point(168, 196);
            this.nomTxt.Margin = new System.Windows.Forms.Padding(2);
            this.nomTxt.Name = "nomTxt";
            this.nomTxt.PlaceholderText = "Donner un nom a votre nouvelle liste d\'étudiants";
            this.nomTxt.Size = new System.Drawing.Size(492, 31);
            this.nomTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom";
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(24, 23);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(112, 34);
            this.btnRetour.TabIndex = 6;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // ListeEtudiants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(878, 544);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomTxt);
            this.Controls.Add(this.lienTxt);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnParcourir);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListeEtudiants";
            this.Text = "nouvelle liste d\'étudiants";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnParcourir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.TextBox lienTxt;
        private System.Windows.Forms.TextBox nomTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRetour;
    }
}
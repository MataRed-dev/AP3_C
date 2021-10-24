
namespace AP3_FormaFlix
{
    partial class FormGestionCommentaire
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
            this.label8 = new System.Windows.Forms.Label();
            this.tbCommentaire = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAuteur = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnNePasValider = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.lblRienATrraiter = new System.Windows.Forms.Label();
            this.btnListeComm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bebas Neue", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(222, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(314, 41);
            this.label8.TabIndex = 19;
            this.label8.Text = "Gestion des commentaires";
            // 
            // tbCommentaire
            // 
            this.tbCommentaire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCommentaire.Enabled = false;
            this.tbCommentaire.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCommentaire.Location = new System.Drawing.Point(81, 161);
            this.tbCommentaire.Multiline = true;
            this.tbCommentaire.Name = "tbCommentaire";
            this.tbCommentaire.Size = new System.Drawing.Size(613, 277);
            this.tbCommentaire.TabIndex = 20;
            this.tbCommentaire.TabStop = false;
            this.tbCommentaire.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(237, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "AUTEUR :";
            // 
            // lblAuteur
            // 
            this.lblAuteur.AutoSize = true;
            this.lblAuteur.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuteur.ForeColor = System.Drawing.Color.White;
            this.lblAuteur.Location = new System.Drawing.Point(317, 109);
            this.lblAuteur.Name = "lblAuteur";
            this.lblAuteur.Size = new System.Drawing.Size(0, 23);
            this.lblAuteur.TabIndex = 22;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.Black;
            this.btnValider.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Location = new System.Drawing.Point(135, 472);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(134, 47);
            this.btnValider.TabIndex = 23;
            this.btnValider.Text = "VALIDER";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnNePasValider
            // 
            this.btnNePasValider.BackColor = System.Drawing.Color.Black;
            this.btnNePasValider.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNePasValider.ForeColor = System.Drawing.Color.White;
            this.btnNePasValider.Location = new System.Drawing.Point(300, 472);
            this.btnNePasValider.Name = "btnNePasValider";
            this.btnNePasValider.Size = new System.Drawing.Size(134, 47);
            this.btnNePasValider.TabIndex = 24;
            this.btnNePasValider.Text = "NE PAS VALIDER";
            this.btnNePasValider.UseVisualStyleBackColor = false;
            this.btnNePasValider.Click += new System.EventHandler(this.btnNePasValider_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.Black;
            this.btnFermer.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.ForeColor = System.Drawing.Color.White;
            this.btnFermer.Location = new System.Drawing.Point(464, 472);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(134, 47);
            this.btnFermer.TabIndex = 25;
            this.btnFermer.Text = "FERMER";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // lblRienATrraiter
            // 
            this.lblRienATrraiter.AutoSize = true;
            this.lblRienATrraiter.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRienATrraiter.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRienATrraiter.Location = new System.Drawing.Point(236, 282);
            this.lblRienATrraiter.Name = "lblRienATrraiter";
            this.lblRienATrraiter.Size = new System.Drawing.Size(296, 25);
            this.lblRienATrraiter.TabIndex = 26;
            this.lblRienATrraiter.Text = "Vous n\'avez aucun commentaire à traiter";
            this.lblRienATrraiter.Visible = false;
            // 
            // btnListeComm
            // 
            this.btnListeComm.BackColor = System.Drawing.Color.Black;
            this.btnListeComm.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListeComm.ForeColor = System.Drawing.Color.White;
            this.btnListeComm.Location = new System.Drawing.Point(12, 12);
            this.btnListeComm.Name = "btnListeComm";
            this.btnListeComm.Size = new System.Drawing.Size(115, 67);
            this.btnListeComm.TabIndex = 27;
            this.btnListeComm.Text = "liste des commentaires";
            this.btnListeComm.UseVisualStyleBackColor = false;
            this.btnListeComm.Click += new System.EventHandler(this.btnListeComm_Click);
            // 
            // FormGestionCommentaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.ControlBox = false;
            this.Controls.Add(this.btnListeComm);
            this.Controls.Add(this.lblRienATrraiter);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnNePasValider);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblAuteur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCommentaire);
            this.Controls.Add(this.label8);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionCommentaire";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORMA\'FLIX : Gestion des commentaires";
            this.Load += new System.EventHandler(this.FormGestionCommentaire_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCommentaire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAuteur;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnNePasValider;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label lblRienATrraiter;
        private System.Windows.Forms.Button btnListeComm;
    }
}
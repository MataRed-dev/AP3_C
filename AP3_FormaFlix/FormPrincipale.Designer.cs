namespace AP3_FormaFlix
{
    partial class FormPrincipale
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipale));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesFormationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listerToutesLesFormationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneFormationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modiferUneFormationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUneFormationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesCommentairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnexionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connexionToolStripMenuItem,
            this.gestionDesFormationsToolStripMenuItem,
            this.gestionDesCommentairesToolStripMenuItem,
            this.deconnexionToolStripMenuItem1,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(937, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connexionToolStripMenuItem
            // 
            this.connexionToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.connexionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deconnexionToolStripMenuItem,
            this.reconnecterToolStripMenuItem,
            this.ajouterUtilisateurToolStripMenuItem});
            this.connexionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            this.connexionToolStripMenuItem.Size = new System.Drawing.Size(173, 18);
            this.connexionToolStripMenuItem.Text = "Gestion des utilisateurs";
            // 
            // deconnexionToolStripMenuItem
            // 
            this.deconnexionToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.deconnexionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deconnexionToolStripMenuItem.Name = "deconnexionToolStripMenuItem";
            this.deconnexionToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.deconnexionToolStripMenuItem.Text = "Deconnexion";
            this.deconnexionToolStripMenuItem.Click += new System.EventHandler(this.DeconnexionToolStripMenuItem_Click);
            // 
            // reconnecterToolStripMenuItem
            // 
            this.reconnecterToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.reconnecterToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reconnecterToolStripMenuItem.Name = "reconnecterToolStripMenuItem";
            this.reconnecterToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.reconnecterToolStripMenuItem.Text = "Reconnecter";
            this.reconnecterToolStripMenuItem.Click += new System.EventHandler(this.ReconnecterToolStripMenuItem_Click);
            // 
            // ajouterUtilisateurToolStripMenuItem
            // 
            this.ajouterUtilisateurToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.ajouterUtilisateurToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ajouterUtilisateurToolStripMenuItem.Name = "ajouterUtilisateurToolStripMenuItem";
            this.ajouterUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.ajouterUtilisateurToolStripMenuItem.Text = "Ajouter Utilisateur";
            this.ajouterUtilisateurToolStripMenuItem.Visible = false;
            this.ajouterUtilisateurToolStripMenuItem.Click += new System.EventHandler(this.ajouterUtilisateurToolStripMenuItem_Click);
            // 
            // gestionDesFormationsToolStripMenuItem
            // 
            this.gestionDesFormationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listerToutesLesFormationsToolStripMenuItem,
            this.ajouterUneFormationToolStripMenuItem,
            this.modiferUneFormationToolStripMenuItem,
            this.supprimerUneFormationToolStripMenuItem});
            this.gestionDesFormationsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.gestionDesFormationsToolStripMenuItem.Name = "gestionDesFormationsToolStripMenuItem";
            this.gestionDesFormationsToolStripMenuItem.Size = new System.Drawing.Size(173, 18);
            this.gestionDesFormationsToolStripMenuItem.Text = "Gestion des Formations";
            // 
            // listerToutesLesFormationsToolStripMenuItem
            // 
            this.listerToutesLesFormationsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.listerToutesLesFormationsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.listerToutesLesFormationsToolStripMenuItem.Name = "listerToutesLesFormationsToolStripMenuItem";
            this.listerToutesLesFormationsToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.listerToutesLesFormationsToolStripMenuItem.Text = "Lister les formations";
            this.listerToutesLesFormationsToolStripMenuItem.Click += new System.EventHandler(this.ListerToutesLesFormationsToolStripMenuItem_Click);
            // 
            // ajouterUneFormationToolStripMenuItem
            // 
            this.ajouterUneFormationToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.ajouterUneFormationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ajouterUneFormationToolStripMenuItem.Name = "ajouterUneFormationToolStripMenuItem";
            this.ajouterUneFormationToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.ajouterUneFormationToolStripMenuItem.Text = "Ajouter une formation";
            this.ajouterUneFormationToolStripMenuItem.Click += new System.EventHandler(this.AjouterUneFormationToolStripMenuItem_Click);
            // 
            // modiferUneFormationToolStripMenuItem
            // 
            this.modiferUneFormationToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.modiferUneFormationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.modiferUneFormationToolStripMenuItem.Name = "modiferUneFormationToolStripMenuItem";
            this.modiferUneFormationToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.modiferUneFormationToolStripMenuItem.Text = "Modifer une formation";
            this.modiferUneFormationToolStripMenuItem.Click += new System.EventHandler(this.modiferUneFormationToolStripMenuItem_Click);
            // 
            // supprimerUneFormationToolStripMenuItem
            // 
            this.supprimerUneFormationToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.supprimerUneFormationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.supprimerUneFormationToolStripMenuItem.Name = "supprimerUneFormationToolStripMenuItem";
            this.supprimerUneFormationToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.supprimerUneFormationToolStripMenuItem.Text = "Supprimer une formation";
            this.supprimerUneFormationToolStripMenuItem.Click += new System.EventHandler(this.supprimerUneFormationToolStripMenuItem_Click);
            // 
            // gestionDesCommentairesToolStripMenuItem
            // 
            this.gestionDesCommentairesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.gestionDesCommentairesToolStripMenuItem.Name = "gestionDesCommentairesToolStripMenuItem";
            this.gestionDesCommentairesToolStripMenuItem.Size = new System.Drawing.Size(192, 18);
            this.gestionDesCommentairesToolStripMenuItem.Text = "Gestion des commentaires";
            this.gestionDesCommentairesToolStripMenuItem.Click += new System.EventHandler(this.gestionDesCommentairesToolStripMenuItem_Click);
            // 
            // deconnexionToolStripMenuItem1
            // 
            this.deconnexionToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
            this.deconnexionToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Control;
            this.deconnexionToolStripMenuItem1.Name = "deconnexionToolStripMenuItem1";
            this.deconnexionToolStripMenuItem1.Size = new System.Drawing.Size(103, 18);
            this.deconnexionToolStripMenuItem1.Text = "Deconnexion";
            this.deconnexionToolStripMenuItem1.Click += new System.EventHandler(this.deconnexionToolStripMenuItem1_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.quitterToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(64, 18);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.QuitterToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(628, 513);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connecté en tant que : ";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.SystemColors.Control;
            this.user.Location = new System.Drawing.Point(793, 513);
            this.user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(0, 13);
            this.user.TabIndex = 2;
            // 
            // FormPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(937, 535);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormPrincipale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipale_FormClosed);
            this.Load += new System.EventHandler(this.FormPrincipale_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesFormationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listerToutesLesFormationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneFormationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reconnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesCommentairesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modiferUneFormationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUneFormationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUtilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deconnexionToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label user;
    }
}


using System;
using System.Windows.Forms;

namespace AP3_FormaFlix
{
    /// <summary>
    /// AP3 FORMA'FLIX : Vue principale de l'application, ouverte suite à la connexion
    /// Auteur : C.AUTRET
    /// date : Septembre 2021
    /// </summary>
    public partial class FormPrincipale : Corner
    {
        public FormPrincipale(string admin)
        {
            InitializeComponent();
            this.roundedCorner();
        }

        private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DeconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controleur.VmodeleC.sedeconnecter();
            MessageBox.Show("Vous êtes déconnecté de la base de données");
            gestionDesFormationsToolStripMenuItem.Enabled = false;
            gestionDesCommentairesToolStripMenuItem.Enabled = false;
            ajouterUtilisateurToolStripMenuItem.Enabled = false;
        }

        private void ReconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConnexion FC = new FormConnexion();
            FC.Show();
            this.Close();
        }

        private void FormPrincipale_Load(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Controleur.VmodeleC.DT[0].Rows[0][5]) == 1 )
                ajouterUtilisateurToolStripMenuItem.Visible =true;
            else
                ajouterUtilisateurToolStripMenuItem.Visible =false;
        }

        private void ListerToutesLesFormationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListeFormations FF = new FormListeFormations();
            FF.Closed += (s, args) => this.Close();
            FF.Show();
        }

        private void FormPrincipale_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AjouterUneFormationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            FormAjoutFormation FA = new FormAjoutFormation();
            FA.Closed += (s, args) => this.Close();
            FA.Show();
        }

        private void gestionDesCommentairesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGestionCommentaire FGC = new FormGestionCommentaire();
            FGC.Closed += (s, args) => this.Close();
            FGC.Show();
        }

        private void modiferUneFormationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListeFormations FF = new FormListeFormations("modifier");
            FF.Closed += (s, args) => this.Close();
            FF.Show();
        }

        private void supprimerUneFormationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            FormListeFormations FF = new FormListeFormations("supprimer");
            FF.Closed += (s, args) => this.Close();
            FF.Show();
        }

        private void ajouterUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAjoutUser FASU = new FormAjoutUser();
            FASU.Closed += (s, args) => this.Close();
            FASU.Show();
        }

        private void deconnexionToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            this.Hide();
            FormConnexion FC = new FormConnexion();
            FC.Closed += (s, args) => this.Close();
            FC.Show();
        }
    }
}

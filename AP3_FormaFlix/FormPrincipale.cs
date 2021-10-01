using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP3_FormaFlix
{
    /// <summary>
    /// AP3 FORMA'FLIX : Vue principale de l'application, ouverte suite à la connexion
    /// Auteur : C.AUTRET
    /// date : Septembre 2021
    /// </summary>
    public partial class FormPrincipale : Form
    {
        private string admin;
        public FormPrincipale(string admin)
        {
            InitializeComponent();
            this.admin = admin;
            this.Text = "FORMA'FLIX : " + admin;
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
        }

        private void ReconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConnexion FC = new FormConnexion();
            FC.Show();
            this.Close();
        }

        private void FormPrincipale_Load(object sender, EventArgs e)
        {
            gestionDesFormationsToolStripMenuItem.Enabled = true;

        }

        private void ListerToutesLesFormationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListeFormations FF = new FormListeFormations();
            FF.Show();
        }

        private void FormPrincipale_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AjouterUneFormationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjoutFormation FA = new FormAjoutFormation();
            FA.Show();
        }

        private void gestionDesCommentairesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionCommentaire FGC = new FormGestionCommentaire();
            FGC.Show();
        }
    }
}

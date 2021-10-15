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
    public partial class FormListeCommentaire : Form
    {
        public FormListeCommentaire()
        {
            InitializeComponent();
        }

        private void FormListeCommentaire_Load(object sender, EventArgs e)
        {
            Controleur.initFormation();
            Controleur.VmodeleF.charger_CommentaireValide();
            Controleur.VmodeleF.charger_CommentaireNonValide();
            Controleur.VmodeleF.charger_CommentaireATraiter();

            dgvListeCommValide.DataSource = Controleur.VmodeleC.DT[6];
            dgvListeCommNonValide.DataSource = Controleur.VmodeleC.DT[7];
            dgvCommATraiter.DataSource = Controleur.VmodeleC.DT[8];
        }

        private void btnListeComm_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGestionCommentaire FGC = new FormGestionCommentaire();
            FGC.Closed += (s, args) => this.Close();
            FGC.Show();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {

            this.Hide();
            FormPrincipale FP = new FormPrincipale("");
            FP.Closed += (s, args) => this.Close();
            FP.Show();
        }
    }
}

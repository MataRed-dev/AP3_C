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
    public partial class FormGestionCommentaire : Corner
    {
        public FormGestionCommentaire()
        {
            InitializeComponent();
            this.roundedCorner();
        }

        private void FormGestionCommentaire_Load(object sender, EventArgs e)
        {
            Controleur.initFormation();
            Controleur.VmodeleF.charger_Commentaires();

            label1.Visible = false;
            lblAuteur.Visible = false;
            lblRienATrraiter.Visible = false;
            tbCommentaire.Visible = false;
            lblAuteur.Text = "";
            tbCommentaire.Clear();
            if (Controleur.VmodeleC.DT[5].Rows.Count == 0)
            {
                lblRienATrraiter.Visible = true;
            }
            else
            {
                label1.Visible = true; 
                lblAuteur.Visible = true;
                tbCommentaire.Visible = true;
                lblAuteur.Text = Controleur.VmodeleC.DT[5].Rows[0][2].ToString() + " " + Controleur.VmodeleC.DT[5].Rows[0][3].ToString();
                tbCommentaire.Text = Controleur.VmodeleC.DT[5].Rows[0][1].ToString();
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {

            this.Hide();
            FormPrincipale FP = new FormPrincipale("");
            FP.Closed += (s, args) => this.Close();
            FP.Show();
        }

        private void btnNePasValider_Click(object sender, EventArgs e)
        {
            //Modifier l'étét du commentaire pour le mettre à non validé ( = 3 )
            Controleur.VmodeleF.ModifEtatCommentaire(Convert.ToInt32(Controleur.VmodeleC.DT[5].Rows[0][0]), 3);
            FormGestionCommentaire_Load(sender, e);
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            //Modifier l'étét du commentaire pour le mettre à  validé ( = 2 )
            Controleur.VmodeleF.ModifEtatCommentaire(Convert.ToInt32(Controleur.VmodeleC.DT[5].Rows[0][0]), 2);
            FormGestionCommentaire_Load(sender, e);

        }

        private void btnListeComm_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListeCommentaire FLC = new FormListeCommentaire();
            FLC.Closed += (s, args) => this.Close();
            FLC.Show();
        }
    }
}

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
    public partial class FormModifFormation : Form
    {
        public FormModifFormation()
        {
            InitializeComponent();
        }
        private void chargerComboBoxCompetences()
        {
            cbCompetences.Items.Clear();
            if (Controleur.VmodeleC.DT[3].Rows.Count == 0)
            {
                cbCompetences.Items.Add("Pas de compétences enregistrées");
                lbCompetences.Visible = false;
            }
            else
            {
                for (int i = 0; i < Controleur.VmodeleC.DT[3].Rows.Count; i++)
                {
                    cbCompetences.Items.Add(Controleur.VmodeleC.DT[3].Rows[i]["LIBELLECOMPETENCE"].ToString());
                }
                lbCompetences.Visible = true;
                lbCompetences.Items.Clear();
            }
        }
        private void FormModifFormation_Load(object sender, EventArgs e)
        {
            tbLibelle.Focus();
            Controleur.initFormation();
            Controleur.VmodeleF.charger_Competences();
            chargerComboBoxCompetences();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {

        }

        
    }
}

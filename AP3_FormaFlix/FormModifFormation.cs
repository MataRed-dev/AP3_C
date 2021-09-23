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
        private int index;

        public FormModifFormation(int index)
        {
            InitializeComponent();
            this.index = index;
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
                    if (!lbCompetences.Items.Contains(Controleur.VmodeleC.DT[3].Rows[i]["LIBELLECOMPETENCE"].ToString()))
                    {
                        cbCompetences.Items.Add(Controleur.VmodeleC.DT[3].Rows[i]["LIBELLECOMPETENCE"].ToString());
                    }
                }
                lbCompetences.Visible = true;
            }
        }

        private void FormModifFormation_Load(object sender, EventArgs e)
        {
            tbLibelle.Focus();
            Controleur.initFormation();
            Controleur.VmodeleF.charger_Formations();
            Controleur.VmodeleF.charger_Competences();

            Controleur.VmodeleF.charger_CompetencesSelonFormation(Convert.ToInt32(Controleur.VmodeleC.DT[1].Rows[index][0]));

            for (int i = 0; i < Controleur.VmodeleC.DT[2].Rows.Count; i++)
            {
                lbCompetences.Items.Add(Controleur.VmodeleC.DT[2].Rows[i][2].ToString());
            }

            chargerComboBoxCompetences();

            //Information de la formation que l'on veut modifier mise dans les bon emplacement

            //TextBox Libele = valeur de la 2ème colonne de la ligne de valeur 'index'
            tbLibelle.Text = Controleur.VmodeleC.DT[1].Rows[index][1].ToString();
            //Même chose pour en dessous
            tbDescription.Text = Controleur.VmodeleC.DT[1].Rows[index][2].ToString();
            tbVideo.Text = Controleur.VmodeleC.DT[1].Rows[index][3].ToString();
            tbImage.Text = Controleur.VmodeleC.DT[1].Rows[index][6].ToString();
            dtpdatepublication.Value = Convert.ToDateTime(Controleur.VmodeleC.DT[1].Rows[index][5]);
            //Pour le check box il faut faire une itérative
            if (Convert.ToInt32(Controleur.VmodeleC.DT[1].Rows[index][4]) == 1) { cbVisible.Checked = true; }

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment fermer sans modifier cette formation ?", "Fermez ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lbCompetences_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cbCompetences.Items.Add(lbCompetences.SelectedItem);
            lbCompetences.Items.RemoveAt(lbCompetences.SelectedIndex);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment modifier cette formation ?", "Fermez ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (tbLibelle.Text != "" && tbVideo.Text != "")
                {
                    int idF = Convert.ToInt32(Controleur.VmodeleC.DT[1].Rows[index][0]);
                    if (Controleur.VmodeleF.SuppDevelopper(idF))
                    {
                        if (Controleur.VmodeleF.ModifFormation(idF, tbLibelle.Text, tbDescription.Text, tbVideo.Text, tbImage.Text, cbVisible.Checked, dtpdatepublication.Value))
                        {
                            for (int i = 0; i < lbCompetences.Items.Count; i++)
                            {
                                Controleur.VmodeleF.charger_CompetenceSelonLibelle(lbCompetences.Items[i].ToString());
                                if (Controleur.VmodeleF.AjoutDevelopper(idF, Convert.ToInt32(Controleur.VmodeleC.DT[2].Rows[0][i])))
                                {
                                    MessageBox.Show("La formation a bien été modifiée et les compétences si vous les avez modifiés l'ont été aussi", "Modification");
                                }
                            }
                        }
                        //à supprimer
                        else MessageBox.Show("formation non modifiée");
                    }
                    else
                    {
                        //à supprimer
                        MessageBox.Show("compétences non modifiée");
                    }
                }
            }
        }

        private void cbCompetences_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbCompetences.SelectedIndex;

            // à la sélection d'une compétence dna sla comboBox : on l'ajoute dans la listBox et la supprime de la combo
            if (index != -1)
            {
                lbCompetences.Items.Add(cbCompetences.SelectedItem);
                cbCompetences.Items.RemoveAt(index);
            }
        }
    }
}

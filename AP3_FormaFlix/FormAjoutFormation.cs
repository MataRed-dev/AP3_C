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
    /// AP3 FORMA'FLIX : Vue permettant l'ajout d'une formation avec les compétences associées
    /// Auteur : C.AUTRET
    /// date : Septembre 2021
    /// </summary>
    public partial class FormAjoutFormation : Corner
    {
        public FormAjoutFormation()
        {
            InitializeComponent();
            this.roundedCorner();
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipale FF = new FormPrincipale("");
            FF.Closed += (s, args) => this.Close();
            FF.Show();
        }

        /// <summary>
        /// méthode qui permet d'annuler et donc réinitialiser tous les champs de saisie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            tbLibelle.Clear();
            tbDescription.Clear();
            tbVideo.Clear();
            tbImage.Clear();
            cbVisible.Checked = false;
            tbLibelle.Focus();
            chargerComboBoxCompetences();

        }

        /// <summary>
        /// Mtéhode qui permet d'ajouter dans la comboBox tous les libellés des compétences issus de la BD (via DT[3])
        /// </summary>
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

        /// <summary>
        /// au chargement de la vue : instanciation de l'objet vModeleF et récupération des compétences 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAjoutFormation_Load(object sender, EventArgs e)
        {
            tbLibelle.Focus();
            Controleur.initFormation();
            Controleur.VmodeleF.charger_Competences();
            chargerComboBoxCompetences();
        }


        /// <summary>
        /// Méthode qui permet d'ajouter la formation dans la BD et les compétences associées
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            Controleur.initFormation();
            // vérifier que le libellé et le lien video sont renseignés au minimum
            if (tbLibelle.Text != "" && tbVideo.Text != "")
            {
                if (Uri.IsWellFormedUriString(tbImage.Text, UriKind.Absolute))
                {
                    // enregistrement de la question en lien avec le thème et niveau
                    if (Controleur.VmodeleF.AjoutFormation(tbLibelle.Text, tbDescription.Text, tbVideo.Text, tbImage.Text, cbVisible.Checked, dtpdatepublication.Value, Convert.ToInt32(Controleur.VmodeleC.DT[0].Rows[0][0])))
                    {
                        // recupérer l'IDFORMATION 
                        // récupération de la dernière formation ajoutée pour avoir son id
                        Controleur.VmodeleF.charger_Formations();
                        int idF = Convert.ToInt32(Controleur.VmodeleC.DT[1].Rows[Controleur.VmodeleC.DT[1].Rows.Count - 1]["IDFORMATION"]);
                        MessageBox.Show("Formation ajoutée n° " + idF);

                        // parcourir lbCompetence
                        // récuperer l'IDCOMPETENCE pour chaque compétence à ajouter
                        int idC = 0;
                        for (int i = 0; i < lbCompetences.Items.Count; i++)
                        {
                            Controleur.VmodeleF.charger_CompetenceSelonLibelle(lbCompetences.Items[i].ToString());
                            if (Controleur.VmodeleC.DT[4].Rows.Count != 0)
                            {
                                idC = Convert.ToInt32(Controleur.VmodeleC.DT[4].Rows[0]["IDCOMPETENCE"]);
                                // ajouter dans la table DEVELOPPER les compétences pour la formation
                                Controleur.VmodeleF.AjoutDevelopper(idF, idC);
                            }

                        }

                        BtnAnnuler_Click(sender, e);
                    }
                }
                else
                    tbImage.Text = "";
            }
            else
            {
                MessageBox.Show( "ERREUR : Vous devez saisir au moins un libellé et un identifiant Video", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbCompetences_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbCompetences.SelectedIndex;
       
            // à la sélection d'une compétence dna sla comboBox : on l'ajoute dans la listBox et la supprime de la combo
            if (index != -1)
            {
                lbCompetences.Items.Add(cbCompetences.SelectedItem); 
                cbCompetences.Items.RemoveAt(index); 
            }
        }

        private void lbCompetences_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cbCompetences.Items.Add(lbCompetences.SelectedItem); 
            lbCompetences.Items.RemoveAt(lbCompetences.SelectedIndex); 
        }
    }
}

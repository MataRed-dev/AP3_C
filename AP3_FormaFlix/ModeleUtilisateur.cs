    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace AP3_FormaFlix
{

    /// <summary>
    /// AP3 FORMA'FLIX : classe MODELECONNECTION pour la connexion à la BD 'ap"_bd_formaflix'
    /// Utilisateur d'une collection de DataTable
    /// dT[0] : dateTable des utilisateurs
    /// dT[1] : dataTable des formations
    /// dT[2] : dataTable des competences selon une formation
    /// dT[3] : dataTable des competences
    /// dT[4] : dataTable des competences selon un libellé
    /// Auteur : M.GOUDAL
    /// date : Septembre 2021
    /// </summary>
    public class ModeleUtilisateur
    {
        #region propriétés
        private MySqlConnection myConnection;
        private bool connopen = false;
        private bool chargement = false;


        #endregion

        #region accesseurs
        public bool Connopen { get => connopen; set => connopen = value; }
        public bool Chargement { get => chargement; set => chargement = value; }
        public MySqlConnection MyConnection { get => myConnection; set => myConnection = value; }

        #endregion
        public ModeleUtilisateur()
        {}

        public bool ajouterUtilisateur(string nom, string prenom, string mdp, string email, bool ouiNon)
        {
            try
            {
                // préparation de la requête 
                string requete = "insert into utilisateur values (null, @nom, @prenom, @mdp, @email, @super)";
                MySqlCommand command = Controleur.VmodeleC.MyConnection.CreateCommand();
                command.CommandText = requete;
                    

                // mise à jour des paramètres de la requête préparée avec les infos passés en paramètre de la méthode
                command.Parameters.AddWithValue("nom", nom);
                command.Parameters.AddWithValue("prenom", prenom);
                command.Parameters.AddWithValue("mdp", mdp);
                command.Parameters.AddWithValue("email", email);
                if (ouiNon)
                    command.Parameters.AddWithValue("super", 1);
                else
                    command.Parameters.AddWithValue("super", null);
                // Exécution de la requête
                int i = command.ExecuteNonQuery();

                // i est positif si l'insertion a pu avoir lieu
                return (i > 0);
            }
            catch
            {
                return false;
            }
        }

    }
}

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
    public class ModeleFormation
    {

        public ModeleFormation()
        { }

        /// <summary>
        /// Méthode qui récupère toutes les informations sur les formations
        /// </summary>
        public void charger_Formations()
        {
            Controleur.VmodeleC.charger("select IDFORMATION, LIBELLE, DESCRIPTION, IDENTIFIANTVIDEO, VISIBILITEPUBLIC, DATEVISIBILITE, IMAGE from formation;", Controleur.VmodeleC.DT[1]);
        }

        /// <summary>
        /// Métbode qui récupère les compétences liées à une formatuion dont l'identifiant est passé en paramètre
        /// </summary>
        /// <param name="idF">ID de la formation</param>
        public void charger_CompetencesSelonFormation(int idF)
        {
            Controleur.VmodeleC.charger("select IDFORMATION, C.IDCOMPETENCE, LIBELLECOMPETENCE from competence C INNER JOIN developper D ON C.IDCOMPETENCE = D.IDCOMPETENCE WHERE IDFORMATION = " + idF + ";", Controleur.VmodeleC.DT[2]);
        }


        /// <summary>
        /// Métbode qui récupère toutes les compétences
        /// </summary>
        public void charger_Competences()
        {
            Controleur.VmodeleC.charger("select IDCOMPETENCE, LIBELLECOMPETENCE from competence;", Controleur.VmodeleC.DT[3]);
        }

        /// <summary>
        /// étbode qui récupère la compétence (identifiant et libellé) selon le libellé de compétence passé en paramètre s'il existe
        /// </summary>
        /// <param name="libC">libellé de la compétence</param>
        public void charger_CompetenceSelonLibelle(string libC)
        {
            Controleur.VmodeleC.charger("select IDCOMPETENCE, LIBELLECOMPETENCE from competence  WHERE LIBELLECOMPETENCE = '" + libC + "';", Controleur.VmodeleC.DT[4]);
        }
        /// <summary>
        /// Permet d'ajouter une formation à la table FORMATION avec les éléments du formulaire passés en paramètre
        /// </summary>
        /// <param name="libelle"></param>
        /// <param name="description"></param>
        /// <param name="video"></param>
        /// <param name="visible"></param>
        /// <returns></returns>
        public bool AjoutFormation(string libelle, string description, string video, string image, bool visible, DateTime date)
        {
            try
            {
                // préparation de la requête 
                string requete = "insert into formation values (null, @lib, @descr, @v, @visible, @date, @image)";
                MySqlCommand command = Controleur.VmodeleC.MyConnection.CreateCommand();
                command.CommandText = requete;

                // mise à jour des paramètres de la requête préparée avec les infos passés en paramètre de la méthode
                command.Parameters.AddWithValue("lib", libelle);
                command.Parameters.AddWithValue("descr", description);
                command.Parameters.AddWithValue("v", video);
                command.Parameters.AddWithValue("visible", visible);
                command.Parameters.AddWithValue("date", date);
                command.Parameters.AddWithValue("image", image);
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

        /// <summary>
        /// Permet de modifier une formation 
        /// </summary>
        /// <param name="idF"></param>
        /// <param name="libelle"></param>
        /// <param name="description"></param>
        /// <param name="video"></param>
        /// <param name="image"></param>
        /// <param name="visible"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public bool ModifFormation(int idF, string libelle, string description, string video, string image, bool visible, DateTime date)
        {
            try
            {
                // préparation de la requête 
                string requete = "UPDATE table SET LIBELLE = @lib, DESCRIPTION = @descr, IDENTIFIANTVIDEO = @v, VISIBILITEPUBLIC = @visible, DATEVISIBILITE = @date, IMAGE = @image WHERE IDFORMATION = @idF";
                MySqlCommand command = Controleur.VmodeleC.MyConnection.CreateCommand();
                command.CommandText = requete;

                // mise à jour des paramètres de la requête préparée avec les infos passés en paramètre de la méthode
                command.Parameters.AddWithValue("lib", libelle);
                command.Parameters.AddWithValue("descr", description);
                command.Parameters.AddWithValue("v", video);
                command.Parameters.AddWithValue("visible", visible);
                command.Parameters.AddWithValue("date", date);
                command.Parameters.AddWithValue("image", image);
                command.Parameters.AddWithValue("idF", idF);
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

        /// <summary>
        /// Permet de supprimer une formation
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool SupprimerFormation(int id)
        {
            try
            {
                // préparation de la requête 
                string requete = "delete from formation WHERE idFormation = @ID";
                MySqlCommand command = Controleur.VmodeleC.MyConnection.CreateCommand();
                command.CommandText = requete;

                // mise à jour des paramètres de la requête préparée avec les infos passés en paramètre de la méthode
                command.Parameters.AddWithValue("ID", id);

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

        /// <summary>
        /// Permet d'ajouter un lien entre une formation et une compétence (avec les identifiants) dans la table DEVELOPPER
        /// </summary>
        /// <param name="idF"></param>
        /// <param name="idC"></param>
        /// <returns></returns>
        public bool AjoutDevelopper(int idF, int idC)
        {
            try
            {
                // préparation de la requête 
                string requete = "insert into developper values (@IDF, @IDC)";
                MySqlCommand command = Controleur.VmodeleC.MyConnection.CreateCommand();
                command.CommandText = requete;

                // mise à jour des paramètres de la requête préparée avec les infos passés en paramètre de la méthode
                command.Parameters.AddWithValue("IDF", idF);
                command.Parameters.AddWithValue("IDC", idC);
            
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

        public bool SuppDevelopper (int idF)
        {
            try
            {
                MessageBox.Show("identifiant formation : "+idF);
                string requete = "delete from developper where IDFORMATION = @IDF)";
                MySqlCommand command = Controleur.VmodeleC.MyConnection.CreateCommand();
                command.CommandText = requete;

                // mise à jour des paramètres de la requête préparée avec les infos passés en paramètre de la méthode
                command.Parameters.AddWithValue("IDF", idF);

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

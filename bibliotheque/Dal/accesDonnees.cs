using System;
using System.Collections.Generic;
using bibliotheque.Controleur;
using bibliotheque.Modele;
using bibliotheque.Connexion;



namespace bibliotheque.Dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant les données distantes
    /// </summary>
    public class AccesDonnees
    {
        private static string connectionString = "server=localhost;user id=root;database=bibliotheque;SslMode=none";

        /// <summary>
        /// Récupère et retourne le personnel provenant de la BDD
        /// </summary>
        /// <returns>liste du personnel</returns>
        public static List <Personnel> GetLePersonnel()
        {
            List<Personnel> lePersonnel = new List<Personnel>();
            string req = "select IDPERSONNEL, IDSERVICE, NOM,  PRENOM, TEL, MAIL";
            req += "from personnel";
            req += "order by NOM, PRENOM;";
            ConnexionBDD curs = ConnexionBDD.GetInstance(connectionString);
            curs.ReqSelect(req, null);
            int k = 0;
            while (curs.Read())
            {
                Personnel personnel = new Personnel((int)curs.Field("IDPERSONNEL"), (int)curs.Field("IDSERVICE"), (string)curs.Field("NOM"), (string)curs.Field("PRENOM"), (string)curs.Field("TEL"), (string)curs.Field("MAIL"));
                lePersonnel.Add(personnel);
                k += 1;
            }
            curs.Close();
            return lePersonnel;

        }


        public AccesDonnees()
        {
        }
    }

       

}
﻿using System;
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

        ///
        public static Boolean ControleAuthentification(string login, string pwd)
        {
            string req = "select * from responsable ";
            req += "where login=@login and pwd=@pwd;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@login", login);
            parameters.Add("@pwd", pwd);
            ConnexionBDD curs = ConnexionBDD.GetInstance(connectionString);
            curs.ReqSelect(req, parameters);
            if (curs.Read())
            {
                curs.Close();
                return true;
            }
            else
            {
                curs.Close();
                return false;
            }
        }


        /// <summary>
        /// Récupère et retourne le personnel provenant de la BDD
        /// </summary>
        /// <returns>liste du personnel</returns>
        public static List<Personnel> GetLePersonnel()
        {
            List<Personnel> lePersonnel = new List<Personnel>();
            string req = "select idpersonnel, p.nom as nom, prenom, tel, mail, s.nom as service ";
            req += " from personnel p join service s on (p.idservice=s.idservice) ";
            req += "order by nom, prenom;";
            ConnexionBDD curs = ConnexionBDD.GetInstance(connectionString);
            curs.ReqSelect(req, null);

            while (curs.Read())
            {
                Personnel personnel = new Personnel((int)curs.Field("IDPERSONNEL"), (string)curs.Field("NOM"), (string)curs.Field("PRENOM"), (string)curs.Field("TEL"), (string)curs.Field("MAIL"), (string)curs.Field("SERVICE"));
                lePersonnel.Add(personnel);

            }
            curs.Close();
            return lePersonnel;
        }

        /// <summary>
        /// récupère les services provenant de la BDD
        /// </summary>
        /// <returns></returns>
        public static List<Service> GetLesServices()
        {
            List<Service> lesServices = new List<Service>();
            string req = "select idservice, nom from service order by nom;";
            ConnexionBDD curs = ConnexionBDD.GetInstance(connectionString);
            curs.ReqSelect(req, null);
            while (curs.Read())
            {
                Service service = new Service((int)curs.Field("IDSERVICE"), (string)curs.Field("NOM"));
                lesServices.Add(service);
            }
            curs.Close();
            return lesServices;
        }


        public AccesDonnees()
        {
        }

    }
       

}
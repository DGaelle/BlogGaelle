using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogGaelle.Repository
{
    public class Connexion
    {
		public void Connecter()
        {
            MySqlConnection connexion = new MySqlConnection("database=dbs1097852; server=db5001286061.hosting-data.io; user id=dbu1292246; pwd=BddMixaIntensif2020.");
            string message;
            try
            {
                
                connexion.Open();
                message= "Connecté";
    
    }
            catch (global::System.Exception)
            {
                message = "non connecté";
                throw;
            }
        }
    }
       
}
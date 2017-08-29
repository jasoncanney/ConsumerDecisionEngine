using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenAdxCDE.Source.Model.Domain;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;

namespace GenAdxCDE.Source.Model.Services.myadservice
{


    /// <summary>
    /// AdSvcSQLImpl is the service implementation class to store and retrieve advertisement
    /// objects to/from a SQL server
    /// @author Jason Canney
    /// </summary>


    public class myAdSvcSQLImpl : ImyAdSvc
    {
        // create a logger object 
        log4net.ILog log;
        int id = 0;

        public DataTable getmyAds(int id)
        {

            // make a list to put the advertisement objects into
            DataTable dt = new DataTable();

            // Create the connection string to send to the mySQL server
            // create the select statement to send to the sql server for searching for the consumer object
            string findConsumer = "SELECT * FROM myads where consumerID=" + id;
            // Create the actual connection to SQL Server
            MySqlConnection myConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString);
            MySqlCommand cmd = new MySqlCommand(findConsumer, myConn);

            Console.WriteLine("create MyConnection for this myads object");
            try
            {
                //open the connection
                myConn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                // Empty advertisement Table first
                dt.Clear();

                // Fill advertisement Table with data retrieved by data reader
                // using SELECT statement
                dt.Load(reader);
                // close the connection
                myConn.Close();
            }
            catch (SQLServiceLoadException e)
            {
                log.Error("failed to get myads data set");
                throw e;
            }
            return dt;


        }

       
    }
}

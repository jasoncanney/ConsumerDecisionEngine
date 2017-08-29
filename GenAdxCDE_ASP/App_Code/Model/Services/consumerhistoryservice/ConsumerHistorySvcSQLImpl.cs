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

namespace GenAdxCDE.Source.Model.Services.consumerhistoryservice
{


    /// <summary>
    /// ConsumerSvcSQLImpl is the service implementation class to store and retrieve Consumer
    /// objects to/from a SQL server
    /// @author Jason Canney
    /// </summary>

    public class ConsumerHistorySvcSQLImpl : IConsumerHistorySvc
    {
        // create a logger object 
        log4net.ILog log;



        public DataTable getConsumerHistory()
        {

            // make a list to put the consumer objects into
            DataTable dt = new DataTable();

            // Create the connection string to send to the mySQL server
            string MyConnection = "datasource=localhost;port=3306;username=root;password=password;database=genadx;";
            // create the select statement to send to the sql server for searching for the consumer object
            string findConsumer = "SELECT * FROM consumerhistory";

            Console.WriteLine("create MyConnection for this consumerhistory object");
            try
            {
                // Create the actual connection to SQL Server
                MySqlConnection myConn = new MySqlConnection(MyConnection);
                MySqlCommand cmd = new MySqlCommand(findConsumer, myConn);
                //open the connection
                myConn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                // Empty consumer Table first
                dt.Clear();

                // Fill consumer Table with data retrieved by data reader
                // using SELECT statement
                dt.Load(reader);
                // close the connection
                myConn.Close();
            }
            catch (SQLServiceLoadException e)
            {
                log.Error("failed to get consumerhistory data set");
                throw e;
            }
            return dt;

        }

        public void storeConsumerHistory(consumerHistory consumerHistory)
        {
            // configure the log4net object with the app.config detail
            // log4net.Config.XmlConfigurator.Configure();
            log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // local consumer object to receive the incoming object through the method interface
            consumerHistory consumerHistorydb = consumerHistory;

            // deconstruct all the data fields in the consumer object to prepare to store in 
            // a SQL server
            int consumerID = consumerHistorydb.ConsumerID;
            int preferenceID = consumerHistorydb.PreferenceID;
            string preferenceDate = consumerHistorydb.PreferenceDate;
            int preferenceChoice = consumerHistorydb.PreferenceChoice;
            int advertisementID = consumerHistorydb.AdvertisementID;
            int couponID = consumerHistorydb.CouponID;

            // Create the SQL message to send to the server
            string insertTableSQL = "INSERT INTO genadx.consumerHistory(consumerID, preferenceID, preferenceDate, preferenceChoice, advertisementID, couponID) VALUES ('" + consumerID + "','" + preferenceID + "','" + preferenceDate + "','" + preferenceChoice + "','" + advertisementID + "','" + couponID + "')";

            // Create the string necessary to connect to the server with UID AND PWD
            // This should be moved into the properties file eventually
            string MyConnection = "datasource=localhost;port=3306;username=root;password=password;";
            Console.WriteLine("create MyConnection for this consumerHistory object");
            try
            {

                 // Create the actual connection to SQL Server
                MySqlConnection myConn = new MySqlConnection(MyConnection);

                myConn.Open();

                MySqlCommand cmd = new MySqlCommand(insertTableSQL, myConn);
                log.Info("inserted" + consumerID + "into database");

                cmd.ExecuteNonQuery();

                myConn.Close();
            }
            catch (SQLServiceLoadException e)
            {
                log.Error("failed to insert" + consumerID + "into database");
                throw e;
            }
           

        }



        public void updateConsumerHistory(consumerHistory consumerHistory)
        {
            // configure the log4net object with the app.config detail
            // log4net.Config.XmlConfigurator.Configure();
            // log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // local consumer object to receive the incoming object through the method interface
            consumerHistory consumerHistorydb2 = consumerHistory;

            // deconstruct all the data fields in the consumer object to prepare to store in 
            // a SQL server
            int consumerID = consumerHistorydb2.ConsumerID;
            int PreferenceID = consumerHistorydb2.PreferenceID;
            string PreferenceDate = consumerHistorydb2.PreferenceDate;
            int PreferenceChoice = consumerHistorydb2.PreferenceChoice;
            int AdvertisementID = consumerHistorydb2.AdvertisementID;
            int CouponID = consumerHistorydb2.CouponID;
            

            // Create the SQL message to send to the server
            string updateTableSQL = "UPDATE consumerHistory SET consumerID='" + consumerID + "',preferenceID='" + PreferenceID + "',preferenceDate='" + PreferenceDate + "',preferenceChoice='" + PreferenceChoice + "',advertisementID='" + AdvertisementID + "',couponID='" + CouponID + "' WHERE consumerID ='" + consumerID + "'";

            // Create the string necessary to connect to the server with UID AND PWD
            // This should be moved into the properties file eventually
            string MyConnection = "datasource=localhost;port=3306;username=root;password=password;database=genadx;";
            Console.WriteLine("update MyConnection for this consumerHistory object");
            try
            {

                // Create the actual connection to SQL Server
                MySqlConnection myConn = new MySqlConnection(MyConnection);

                myConn.Open();

                MySqlCommand cmd = new MySqlCommand(updateTableSQL, myConn);
                // log.Info("updated" +consumerID);

                cmd.ExecuteNonQuery();

                myConn.Close();
            }
            catch (SQLServiceLoadException e)
            {
                log.Error("failed to update" + consumerID + "into database");
                throw e;
            }


        }

        public void deleteConsumerHistory(consumerHistory consumerHistory)
        {
            // configure the log4net object with the app.config detail
            // log4net.Config.XmlConfigurator.Configure();
            // log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // local consumer object to receive the incoming object through the method interface
            consumerHistory  consumerHistorydb3 = consumerHistory;

            // deconstruct all the data fields in the consumer object to prepare to store in 
            // a SQL server

            int preferenceID = consumerHistorydb3.PreferenceID;

            // Create the SQL message to send to the server
            string deleteTableSQL = "DELETE from consumerHistory where preferenceID=" + preferenceID + ";";
            // Create the string necessary to connect to the server with UID AND PWD
            // This should be moved into the properties file eventually
            string MyConnection = "datasource=localhost;port=3306;username=root;password=password;database=genadx;";
            Console.WriteLine("delete MyConnection for this consumerHistory object");
            try
            {

                // Create the actual connection to SQL Server
                MySqlConnection myConn = new MySqlConnection(MyConnection);

                myConn.Open();

                MySqlCommand cmd = new MySqlCommand(deleteTableSQL, myConn);
                // log.Info("delete" + consumerID);

                cmd.ExecuteNonQuery();
                // cmd.ExecuteNonQuery();

                myConn.Close();
            }
            catch (SQLServiceLoadException e)
            {
                log.Error("failed to delete" + preferenceID + "from database");
                throw e;
            }


        }




    }
}

using System;
using GenAdxCDE.Source.Model.Domain;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;

using NReco.CF.Taste.Model;

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
            // create the select statement to send to the sql server for searching for the consumer object
            string findConsumer = "SELECT * FROM consumerhistory";
            MySqlConnection myConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString);
            MySqlCommand cmd = new MySqlCommand(findConsumer, myConn);

            Console.WriteLine("create MyConnection for this consumerhistory object");
            try
            {                
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

        public consumerHistory getAConsumerHistory(int id)
        {

            // make a new consumer to put the consumer objects into
            consumerHistory con = new consumerHistory();

            // Create the connection string to send to the mySQL server
            // string MyConnection = "datasource=localhost;port=3306;username=root;password=password;database=genadx;";
            // create the select statement to send to the sql server for searching for the consumer object
            string findConsumer = "SELECT * FROM consumerHistory WHERE ConsumerID=" + id;
            MySqlConnection myConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString);
            MySqlCommand cmd = new MySqlCommand(findConsumer, myConn);

            Console.WriteLine("create MyConnection for this consumer object");
            try
            {
                // Create the actual connection to SQL Server

                //open the connection
                myConn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    con.ConsumerID = (Int32)reader.GetInt32("ConsumerID");
                    con.PreferenceID = (Int32)reader.GetInt32("PreferenceID");
                    con.PreferenceDate = (string)reader.GetString("PreferenceDate");
                    con.PreferenceChoice = (Int32)reader.GetInt32("PreferenceChoice");
                    con.AdvertisementID = (Int32)reader.GetInt32("AdvertisementID");
                    con.CouponID = (Int32)reader.GetInt32("CouponID");
                }

                // close the connection
                myConn.Close();
            }
            catch (SQLServiceLoadException e)
            {
                log.Error("failed to get consumerHistory data set");
                throw e;
            }
            return con;

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
            MySqlConnection myConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString);
            MySqlCommand cmd = new MySqlCommand(insertTableSQL, myConn);

            Console.WriteLine("create MyConnection for this consumerHistory object");
            try
            {

                myConn.Open();

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
            MySqlConnection myConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString);
            MySqlCommand cmd = new MySqlCommand(updateTableSQL, myConn);

            Console.WriteLine("update MyConnection for this consumerHistory object");
            try
            {

                // Create the actual connection to SQL Server
                myConn.Open();

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
            MySqlConnection myConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString);
            MySqlCommand cmd = new MySqlCommand(deleteTableSQL, myConn);

            Console.WriteLine("delete MyConnection for this consumerHistory object");
            try
            {
                // Create the actual connection to SQL Server
                myConn.Open();

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
        public IDataModel getConsumerHistoryDataSet()
        {
            // Create the connection string to send to the mySQL server
            // create the select statement to send to the sql server for searching for the consumer object
            string getDataset = "SELECT consumerID, advertisementID, preferenceChoice FROM consumerhistory";
            MySqlConnection myConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString);
            MySqlCommand cmd = new MySqlCommand(getDataset, myConn);

            Console.WriteLine("create MyConnection for this consumer object");
            try
            {
                // Create the actual connection to SQL Server
                myConn.Open();

                IDataModel dataModel = null;

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long consumerID = Convert.ToInt64(reader["consumerID"]);
                        long advertisementID = Convert.ToInt64(reader["advertisementID"]);
                        float preferenceChoice = Convert.ToInt64(reader["preferenceChoice"]);

                        dataModel.SetPreference(consumerID, advertisementID, preferenceChoice);
                    }
                    // close the connection
                    myConn.Close();
                }

                return dataModel;
            }
            catch (SQLServiceLoadException e)
            {
                log.Error("failed to get preference data set");
                throw e;
            }
        }
    }
}

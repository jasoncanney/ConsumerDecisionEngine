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
using System.Data.SqlClient;
using System.Configuration;

namespace GenAdxCDE.Source.Model.Services.consumerservice
{


    /// <summary>
    /// ConsumerSvcSQLImpl is the service implementation class to store and retrieve Consumer
    /// objects to/from a SQL server
    /// @author Jason Canney
    /// </summary>

    public class ConsumerSvcSQLImpl : IConsumerSvc
    {
        // create a logger object 
        log4net.ILog log;

        public DataTable findConsumer()
        {

            // make a list to put the consumer objects into
            DataTable dt = new DataTable();

            // Create the connection string to send to the mySQL server
            // string MyConnection = "datasource=localhost;port=3306;username=root;password=password;database=genadx;";
            // create the select statement to send to the sql server for searching for the consumer object
            string findConsumer = "SELECT * FROM consumer";
            MySqlConnection myConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString);
            MySqlCommand cmd = new MySqlCommand(findConsumer, myConn);

            Console.WriteLine("create MyConnection for this consumer object");
            try
            {
                // Create the actual connection to SQL Server
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
                log.Error("failed to get consumer data set");
                throw e;
            }
            return dt;

        }

        public int whatIsConsumerID(string socemail)
        {
            // make a new consumer to put the consumer objects into
            consumer con = new consumer();

            // Create the connection string to send to the mySQL server
            // string MyConnection = "datasource=localhost;port=3306;username=root;password=password;database=genadx;";
            // create the select statement to send to the sql server for searching for the consumer object
            string whatIsConsumerId = "SELECT * FROM consumer WHERE ConsumerSocEmail='" + socemail + "'";
            MySqlConnection myConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString);
            MySqlCommand cmd = new MySqlCommand(whatIsConsumerId, myConn);

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
                    con.ConsumerFirstName = (string)reader.GetString("ConsumerFirstName");
                    con.ConsumerMiddleInitial = (string)reader.GetString("ConsumerMiddleInitial");
                    con.ConsumerLastName = (string)reader.GetString("ConsumerLastName");
                    con.ConsumerEmail = (string)reader.GetString("ConsumerEmail");
                    con.ConsumerPhone = (string)reader.GetString("ConsumerPhone");
                    con.ConsumerAddress = (string)reader.GetString("ConsumerAddress");
                    con.ConsumerCity = (string)reader.GetString("ConsumerCity");
                    con.ConsumerState = (string)reader.GetString("ConsumerState");
                    con.ConsumerZip = (string)reader.GetString("ConsumerZip");
                    con.ConsumerSocEmail = (string)reader.GetString("ConsumerSocEmail");

                }

                // close the connection
                myConn.Close();
            }
            catch (SQLServiceLoadException e)
            {
                log.Error("failed to get consumer ID data set");
                throw e;
            }
            return con.ConsumerID;

        }


        public consumer getConsumer(int id)
        {

            // make a new consumer to put the consumer objects into
            consumer con = new consumer();

            // Create the connection string to send to the mySQL server
            // string MyConnection = "datasource=localhost;port=3306;username=root;password=password;database=genadx;";
            // create the select statement to send to the sql server for searching for the consumer object
            string findConsumer = "SELECT * FROM consumer WHERE ConsumerID=" + id;
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
                con.ConsumerFirstName = (string)reader.GetString("ConsumerFirstName");
                con.ConsumerMiddleInitial = (string)reader.GetString("ConsumerMiddleInitial");
                con.ConsumerLastName = (string)reader.GetString("ConsumerLastName");
                con.ConsumerEmail = (string)reader.GetString("ConsumerEmail");
                con.ConsumerPhone = (string)reader.GetString("ConsumerPhone");
                con.ConsumerAddress = (string)reader.GetString("ConsumerAddress");
                con.ConsumerCity = (string)reader.GetString("ConsumerCity");
                con.ConsumerState = (string)reader.GetString("ConsumerState");
                con.ConsumerZip = (string)reader.GetString("ConsumerZip");
                con.ConsumerSocEmail = (string)reader.GetString("ConsumerSocEmail");

                }

                // close the connection
                myConn.Close();
            }
            catch (SQLServiceLoadException e)
            {
                log.Error("failed to get consumer data set");
                throw e;
            }
            return con;

        }

        public void storeConsumer(consumer consumer)
        {
            // configure the log4net object with the app.config detail
            // log4net.Config.XmlConfigurator.Configure();
            log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // local consumer object to receive the incoming object through the method interface
            consumer consumerdb = consumer;

            // deconstruct all the data fields in the consumer object to prepare to store in 
            // a SQL server
            int consumerID = consumerdb.ConsumerID;
            string consumerFName = consumerdb.ConsumerFirstName;
            string consumerMName = consumerdb.ConsumerMiddleInitial;
            string consumerLName = consumerdb.ConsumerLastName;
            string consumerEmail = consumerdb.ConsumerEmail;
            string consumerPhone = consumerdb.ConsumerPhone;
            string consumerAddr = consumerdb.ConsumerAddress;
            string consumerCity = consumerdb.ConsumerCity;
            string consumerState = consumerdb.ConsumerState;
            string consumerZip = consumerdb.ConsumerZip;
            string consumerSEmail = consumerdb.ConsumerSocEmail;

            // Create the SQL message to send to the server
            string insertTableSQL = "INSERT INTO genadx.consumer(ConsumerID, ConsumerFirstName, ConsumerMiddleInitial, ConsumerLastName, ConsumerEmail, ConsumerPhone, ConsumerAddress, ConsumerCity, ConsumerState, ConsumerZip, ConsumerSocEmail) VALUES ('" + consumerID + "','" + consumerFName + "','" + consumerMName + "','" + consumerLName + "','" + consumerEmail + "','" + consumerPhone + "','" + consumerAddr + "','" + consumerCity + "','" + consumerState + "','" + consumerZip + "','" + consumerSEmail + "')";

            // Create the string necessary to connect to the server with UID AND PWD
            // This should be moved into the properties file eventually
            MySqlConnection myConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString);
            MySqlCommand cmd = new MySqlCommand(insertTableSQL, myConn);

            Console.WriteLine("create MyConnection for this consumer object");
            try
            {
                // Create the actual connection to SQL Server   
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

        public void updateConsumer(consumer consumer)
        {
            // configure the log4net object with the app.config detail
            // log4net.Config.XmlConfigurator.Configure();
            // log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // local consumer object to receive the incoming object through the method interface
            consumer consumerdb2 = consumer;

            // deconstruct all the data fields in the consumer object to prepare to store in 
            // a SQL server
            int consumerID = consumerdb2.ConsumerID;
            string consumerFName = consumerdb2.ConsumerFirstName;
            string consumerMName = consumerdb2.ConsumerMiddleInitial;
            string consumerLName = consumerdb2.ConsumerLastName;
            string consumerEmail = consumerdb2.ConsumerEmail;
            string consumerPhone = consumerdb2.ConsumerPhone;
            string consumerAddr = consumerdb2.ConsumerAddress;
            string consumerCity = consumerdb2.ConsumerCity;
            string consumerState = consumerdb2.ConsumerState;
            string consumerZip = consumerdb2.ConsumerZip;
            string consumerSEmail = consumerdb2.ConsumerSocEmail;

            // Create the SQL message to send to the server
            string updateTableSQL = "UPDATE consumer SET ConsumerID='" + consumerID + "',ConsumerFirstName='" + consumerFName + "',ConsumerMiddleInitial='" + consumerMName + "',ConsumerLastName='" + consumerLName + "',ConsumerEmail='" + consumerEmail + "',ConsumerPhone='" + consumerPhone + "',ConsumerAddress='" + consumerAddr + "',ConsumerCity='" + consumerCity + "',ConsumerState='" + consumerState + "',ConsumerZip='" + consumerZip + "',ConsumerSocEmail='" + consumerSEmail + "' WHERE ConsumerID ='" + consumerID + "'";

            // Create the string necessary to connect to the server with UID AND PWD
            MySqlConnection myConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString);
            MySqlCommand cmd = new MySqlCommand(updateTableSQL, myConn);

            Console.WriteLine("update MyConnection for this consumer object");
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

        public void deleteConsumer(consumer consumer)
        {
            // configure the log4net object with the app.config detail
            // log4net.Config.XmlConfigurator.Configure();
            log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // local consumer object to receive the incoming object through the method interface
            consumer consumerdb3 = consumer;

            // deconstruct all the data fields in the consumer object to prepare to store in 
            // a SQL server
            int consumerID = consumerdb3.ConsumerID;

            // Create the SQL message to send to the server
            string deleteTableSQL = "DELETE from consumer where consumerID=" + consumerID + ";";
            // Create the string necessary to connect to the server with UID AND PWD
            MySqlConnection myConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString);
            MySqlCommand cmd = new MySqlCommand(deleteTableSQL, myConn);

            Console.WriteLine("delete MyConnection for this consumer object");
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
                log.Error("failed to delete" + consumerID + "into database");
                throw e;
            }
        }
    }
}

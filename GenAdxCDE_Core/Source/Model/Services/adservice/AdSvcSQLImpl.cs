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

namespace GenAdxCDE.Source.Model.Services.adservice
{


    /// <summary>
    /// AdSvcSQLImpl is the service implementation class to store and retrieve advertisement
    /// objects to/from a SQL server
    /// @author Jason Canney
    /// </summary>

    public class AdSvcSQLImpl : IAdSvc
    {
        // create a logger object 
        log4net.ILog log;



        public DataTable getAdvertisement()
        {

            // make a list to put the advertisement objects into
            DataTable dt = new DataTable();

            // Create the connection string to send to the mySQL server
            // create the select statement to send to the sql server for searching for the consumer object
            string findConsumer = "SELECT * FROM advertisement";
            // Create the actual connection to SQL Server
            MySqlConnection myConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString);
            MySqlCommand cmd = new MySqlCommand(findConsumer, myConn);

            Console.WriteLine("create MyConnection for this advertisement object");
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
                log.Error("failed to get advertisement data set");
                throw e;
            }
            return dt;


        }

        public void storeAdvertisement(advertisement advertisement)
        {
            // configure the log4net object with the app.config detail
            // log4net.Config.XmlConfigurator.Configure();
            log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // local consumer object to receive the incoming object through the method interface
            advertisement advertisementdb = advertisement;

            // deconstruct all the data fields in the advertisement object to prepare to store in 
            // a SQL server
            int adID = advertisementdb.adId;
            string adtitle = advertisementdb.adTitle;
            int addemo01 = advertisementdb.adDemo01;
            int addemo02 = advertisementdb.adDemo02;
            int addemo03 = advertisementdb.adDemo03;
            int addemo04 = advertisementdb.adDemo04;
            string addescription = advertisementdb.adDescription;
            string adowner = advertisementdb.adOwner;
            string adbrand = advertisementdb.adBrand;
            string adPCC = advertisementdb.adPcc;
            string adURL = advertisementdb.adUrl;
            string adCampID = advertisementdb.adCampId;

            // Create the SQL message to send to the server
            string insertTableSQL = "INSERT INTO genadx.advertisement(adID, adTitle, adDemo01, adDemo02, adDemo03, adDemo04, adDescription, adOwner, adBrand, adPCC, adURL, adCampID) VALUES ('" + adID + "','" + adtitle + "','" + addemo01 + "','" + addemo02 + "','" + addemo03 + "','" + addemo04 + "','" + addescription + "','" + adowner + "','" + adbrand + "','" + adPCC + "','" + adURL + "','" + adCampID + "')";

            // Create the string necessary to connect to the server with UID AND PWD
            MySqlConnection myConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString);
            MySqlCommand cmd = new MySqlCommand(insertTableSQL, myConn);

            Console.WriteLine("create MyConnection for this advertisement object");
            try
            {
                // Create the actual connection to SQL Server   
                myConn.Open();

                log.Info("inserted" + adID + "into database");

                cmd.ExecuteNonQuery();

                myConn.Close();
            }
            catch (SQLServiceLoadException e)
            {
                log.Error("failed to insert" + adID + "into database");
                throw e;
            }

        }

        public void updateAdvertisement(advertisement advertisement)
        {
            // configure the log4net object with the app.config detail
            // log4net.Config.XmlConfigurator.Configure();
            // log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // local consumer object to receive the incoming object through the method interface
            advertisement advertisementdb2 = advertisement;

            // deconstruct all the data fields in the advertisement object to prepare to store in 
            // a SQL server
            int adId = advertisementdb2.adId;
            string adTitle = advertisementdb2.adTitle;
            int adDemo01 = advertisementdb2.adDemo01;
            int adDemo02 = advertisementdb2.adDemo02;
            int adDemo03 = advertisementdb2.adDemo03;
            int adDemo04 = advertisementdb2.adDemo04;
            string adDescription = advertisementdb2.adDescription;
            string adOwner = advertisementdb2.adOwner;
            string adBrand = advertisementdb2.adBrand;
            string adPCC = advertisementdb2.adPcc;
            string adURL = advertisementdb2.adUrl;
            string adCampID = advertisementdb2.adCampId;


            // Create the SQL message to send to the server
            string updateTableSQL = "UPDATE advertisement SET adID='" + adId + "',adtitle='" + adTitle + "',addemo01='" + adDemo01 + "',addemo02='" + adDemo02 + "',addemo03='" + adDemo03 + "',addemo04='" + adDemo04 + "',addescription='" + adDescription + "',adowner='" + adOwner + "',adbrand='" + adBrand + "',adPCC='" + adPCC + "',adURL='" + adURL + "',adCampID='" + adCampID + "' WHERE adID ='" + adId + "'";

            // Create the string necessary to connect to the server with UID AND PWD
            // Create the actual connection to SQL Server
            MySqlConnection myConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString);
            MySqlCommand cmd = new MySqlCommand(updateTableSQL, myConn);

            Console.WriteLine("update MyConnection for this advertisement object");
            try
            {

                myConn.Open();

                // log.Info("updated" +adId);

                cmd.ExecuteNonQuery();

                myConn.Close();
            }
            catch (SQLServiceLoadException e)
            {
                log.Error("failed to update" + adId + "into database");
                throw e;
            }

        }

        public void deleteAdvertisement(advertisement advertisement)
        {
            // configure the log4net object with the app.config detail
            // log4net.Config.XmlConfigurator.Configure();
            // log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // local consumer object to receive the incoming object through the method interface
            advertisement advertisementdb3 = advertisement;

            // deconstruct all the data fields in the advertisement object to prepare to store in 
            // a SQL server
            int adId = advertisementdb3.adId;

            // Create the SQL message to send to the server
            string deleteTableSQL = "DELETE from advertisement where adID=" + adId + ";";
            // Create the string necessary to connect to the server with UID AND PWD
            // Create the actual connection to SQL Server
            MySqlConnection myConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString);
            MySqlCommand cmd = new MySqlCommand(deleteTableSQL, myConn);

            Console.WriteLine("delete MyConnection for this consumer object");
            try
            {

                myConn.Open();

                // log.Info("delete" + consumerID);

                cmd.ExecuteNonQuery();
                // cmd.ExecuteNonQuery();

                myConn.Close();
            }
            catch (SQLServiceLoadException e)
            {
                log.Error("failed to delete" + adId + "from database");
                throw e;
            }

        }

    }
}

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
            string MyConnection = "datasource=localhost;port=3306;username=root;password=password;database=genadx;";
            // create the select statement to send to the sql server for searching for the consumer object
            string findConsumer = "SELECT * FROM advertisement";

            Console.WriteLine("create MyConnection for this advertisement object");
            try
            {
                // Create the actual connection to SQL Server
                MySqlConnection myConn = new MySqlConnection(MyConnection);
                MySqlCommand cmd = new MySqlCommand(findConsumer, myConn);
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
            int adgssegment = advertisementdb.adGsSegment;
            int adcatypecode = advertisementdb.adCaTypeCode;
            int adcavaluecode = advertisementdb.adCaValueCode;

            // Create the SQL message to send to the server
            string insertTableSQL = "INSERT INTO genadx.advertisement(adID, adTitle, adDemo01, adDemo02, adDemo03, adDemo04, adDescription, adOwner, adBrand, adGsSegment, adCaTypeCode, adCaValueCode) VALUES ('" + adID + "','" + adtitle + "','" + addemo01 + "','" + addemo02 + "','" + addemo03 + "','" + addemo04 + "','" + addescription + "','" + adowner + "','" + adbrand + "','" + adgssegment + "','" + adcatypecode + "','" + adcavaluecode + "')";

            // Create the string necessary to connect to the server with UID AND PWD
            // This should be moved into the properties file eventually
            string MyConnection = "datasource=localhost;port=3306;username=root;password=password;";
            Console.WriteLine("create MyConnection for this advertisement object");
            try
            {

                 // Create the actual connection to SQL Server
                MySqlConnection myConn = new MySqlConnection(MyConnection);

                myConn.Open();

                MySqlCommand cmd = new MySqlCommand(insertTableSQL, myConn);
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
            int adGsSegment = advertisementdb2.adGsSegment;
            int adCaTypeCode = advertisementdb2.adCaTypeCode;
            int adCaValueCode = advertisementdb2.adCaValueCode;


            // Create the SQL message to send to the server
            string updateTableSQL = "UPDATE advertisement SET adID='" + adId + "',adtitle='" + adTitle + "',addemo01='" + adDemo01 + "',addemo02='" + adDemo02 + "',addemo03='" + adDemo03 + "',addemo04='" + adDemo04 + "',addescription='" + adDescription + "',adowner='" + adOwner + "',adbrand='" + adBrand + "',adgssegment='" + adGsSegment + "',adcatypecode='" + adCaTypeCode + "',adcavaluecode='" + adCaValueCode + "' WHERE adID ='" + adId + "'";

            // Create the string necessary to connect to the server with UID AND PWD
            // This should be moved into the properties file eventually
            string MyConnection = "datasource=localhost;port=3306;username=root;password=password;database=genadx;";
            Console.WriteLine("update MyConnection for this advertisement object");
            try
            {

                // Create the actual connection to SQL Server
                MySqlConnection myConn = new MySqlConnection(MyConnection);

                myConn.Open();

                MySqlCommand cmd = new MySqlCommand(updateTableSQL, myConn);
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
            // This should be moved into the properties file eventually
            string MyConnection = "datasource=localhost;port=3306;username=root;password=password;database=genadx;";
            Console.WriteLine("delete MyConnection for this consumer object");
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
                log.Error("failed to delete" + adId + "from database");
                throw e;
            }


        }







    }
}

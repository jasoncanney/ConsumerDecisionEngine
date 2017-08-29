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

namespace GenAdxCDE.Source.Model.Services.preferenceservice
{

    /// <summary>
    /// PreferenceSvcBinaryImpl is the service implementation class to store and retrieve Preference
    /// objects to/from the file system
    /// @author Jason Canney
    /// </summary>

    public class PreferenceSvcSQLImpl : IPreferenceSvc
    {

        // create a logger object 
        log4net.ILog log;
        // public preference P1 { get; private set; }

        public DataTable getPreference()
        {

            // make a list to put the consumer objects into
            DataTable dt = new DataTable();

            // Create the connection string to send to the mySQL server
            string MyConnection = "datasource=localhost;port=3306;username=root;password=password;database=genadx;";
            // create the select statement to send to the sql server for searching for the consumer object
            string findPreference = "SELECT * FROM preference";

            Console.WriteLine("create MyConnection for this preference object");
            try
            {
                // Create the actual connection to SQL Server
                MySqlConnection myConn = new MySqlConnection(MyConnection);
                MySqlCommand cmd = new MySqlCommand(findPreference, myConn);
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
                log.Error("failed to get preference data set");
                throw e;
            }
            return dt;

        }

        public void storePreference(preference preference)
        {
            // configure the log4net object with the app.config detail
            // log4net.Config.XmlConfigurator.Configure();
            log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // local consumer object to receive the incoming object through the method interface
            preference preferencedb = preference;

            // deconstruct all the data fields in the consumer object to prepare to store in 
            // a SQL server
            int preferenceId = preferencedb.PreferenceId;
            int preferenceGsSegment = preferencedb.PreferenceGsSegment;
            int preferenceCaTypeCode = preferencedb.PreferenceCaTypeCode;
            int preferenceCaValueCode = preferencedb.PreferenceCaValueCode;
            string preferenceBrandOwner = preferencedb.PreferenceBrandOwner;
            string preferenceProductDesc = preferencedb.PreferenceProductDesc;
            string preferenceDate = preferencedb.PreferenceDate;
            int consumerId = preferencedb.ConsumerId;
           

            // Create the SQL message to send to the server
            string insertTableSQL = "INSERT INTO genadx.preference(preferenceId, preferenceGsSegment, preferenceCaTypeCode, preferenceCaValueCode, preferenceBrandOwner, preferenceProductDesc, preferenceDate, consumerId) VALUES ('" + preferenceId + "','" + preferenceGsSegment + "','" + preferenceCaTypeCode + "','" + preferenceCaValueCode + "','" + preferenceBrandOwner + "','" + preferenceProductDesc + "','" + preferenceDate + "','" + consumerId + "')";

            // Create the string necessary to connect to the server with UID AND PWD
            // This should be moved into the properties file eventually
            string MyConnection = "datasource=localhost;port=3306;username=root;password=password;";
            Console.WriteLine("create MyConnection for this preference object");

            try
            {
                        // Create the actual connection to SQL Server
                        MySqlConnection myConn = new MySqlConnection(MyConnection);

                        myConn.Open();

                        MySqlCommand cmd = new MySqlCommand(insertTableSQL, myConn);
                        log.Info("inserted" + preferenceId + "into database");


                cmd.ExecuteNonQuery();

                        myConn.Close();

            }
            catch (SQLServiceLoadException e)
            {
                log.Error("failed to insert" + preferenceId + "into database");
                throw e;
            }

        }

        public void updatePreference(preference preference)
        {
            // configure the log4net object with the app.config detail
            // log4net.Config.XmlConfigurator.Configure();
            // log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // local preference object to receive the incoming object through the method interface
            preference preferencedb2 = preference;

            // deconstruct all the data fields in the coupon object to prepare to store in 
            // a SQL server

            int preferenceId = preferencedb2.PreferenceId;
            int preferenceGsSegment = preferencedb2.PreferenceGsSegment;
            int preferenceCaTypeCode = preferencedb2.PreferenceCaTypeCode;
            int preferenceCaValueCode = preferencedb2.PreferenceCaValueCode;
            string preferenceBrandOwner = preferencedb2.PreferenceBrandOwner;
            string preferenceProductDesc = preferencedb2.PreferenceProductDesc;
            string preferenceDate = preferencedb2.PreferenceDate;
            int consumerId = preferencedb2.ConsumerId;

            // Create the SQL message to send to the server
            string updateTableSQL = "UPDATE preference SET preferenceID='" + preferenceId + "',preferenceGsSegment='" + preferenceGsSegment + "',preferenceCaTypeCode='" + preferenceCaTypeCode + "',preferenceCaValueCode='" + preferenceCaValueCode + "',preferenceBrandOwner='" + preferenceBrandOwner + "',preferenceProductDesc='" + preferenceProductDesc + "',preferenceDate='" + preferenceDate + "',consumerId='" + consumerId + "' WHERE preferenceID='" + preferenceId + "'";

            // Create the string necessary to connect to the server with UID AND PWD
            // This should be moved into the properties file eventually
            string MyConnection = "datasource=localhost;port=3306;username=root;password=password;database=genadx;";
            Console.WriteLine("update MyConnection for this coupon object");
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
                log.Error("failed to update" + preferenceId + "into database");
                throw e;
            }


        }

        public void deletePreference(preference preference)
        {
            // configure the log4net object with the app.config detail
            // log4net.Config.XmlConfigurator.Configure();
            log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // local consumer object to receive the incoming object through the method interface
            preference preferencedb3 = preference;

            // deconstruct all the data fields in the consumer object to prepare to store in 
            // a SQL server
            int preferenceId = preferencedb3.PreferenceId;

            // Create the SQL message to send to the server
            string deleteTableSQL = "DELETE from preference where preferenceID=" + preferenceId + ";";
            // Create the string necessary to connect to the server with UID AND PWD
            // This should be moved into the properties file eventually
            string MyConnection = "datasource=localhost;port=3306;username=root;password=password;database=genadx;";
            Console.WriteLine("delete MyConnection for this preference object");
            try
            {

                // Create the actual connection to SQL Server
                MySqlConnection myConn = new MySqlConnection(MyConnection);
                myConn.Open();
                MySqlCommand cmd = new MySqlCommand(deleteTableSQL, myConn);
                cmd.ExecuteNonQuery();
                myConn.Close();
            }
            catch (SQLServiceLoadException e)
            {
                log.Error("failed to delete" + preferenceId + "from database");
                throw e;
            }


        }

    }
}

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

namespace GenAdxCDE.Source.Model.Services.couponservice
{


    /// <summary>
    /// CouponSvcSQLImpl is the service implementation class to store and retrieve Coupon
    /// objects to/from a SQL server
    /// @author Jason Canney
    /// </summary>

    public class CouponSvcSQLImpl : ICouponSvc
    {
        // create a logger object 
        log4net.ILog log;

        public DataTable getCoupon()
        {

            // make a list to put the consumer objects into
            DataTable dt = new DataTable();

            // Create the connection string to send to the mySQL server
            string MyConnection = "datasource=localhost;port=3306;username=root;password=password;database=genadx;";
            // create the select statement to send to the sql server for searching for the consumer object
            string findCoupon = "SELECT * FROM coupon";

            Console.WriteLine("create MyConnection for this coupon object");
            try
            {
                // Create the actual connection to SQL Server
                MySqlConnection myConn = new MySqlConnection(MyConnection);
                MySqlCommand cmd = new MySqlCommand(findCoupon, myConn);
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
                log.Error("failed to get coupon data set");
                throw e;
            }
            return dt;

        }

        public void storeCoupon(coupon coupon)
        {
            // configure the log4net object with the app.config detail
            // log4net.Config.XmlConfigurator.Configure();
            log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // local consumer object to receive the incoming object through the method interface
            coupon coupondb = coupon;

            // deconstruct all the data fields in the consumer object to prepare to store in 
            // a SQL server

            int couponID = coupondb.CouponID;
            string couponTitle = coupondb.CouponTitle;
            string couponDescription = coupondb.CouponDescription;
            float couponValue = coupondb.CouponValue;
            string couponStartActive = coupondb.CouponStartActive;
            string couponEndActive = coupondb.CouponEndActive;
            string couponLocationsZip = coupondb.CouponLocationsZip;

            // Create the SQL message to send to the server
            string insertTableSQL = "INSERT INTO genadx.coupon(CouponID, CouponTitle, CouponDescription, CouponValue, CouponStartActive, CouponEndActive, CouponLocationsZip) VALUES ('" + couponID + "','" + couponTitle + "','" + couponDescription + "','" + couponValue + "','" + couponStartActive + "','" + couponEndActive + "','" + couponLocationsZip + "')";
   
            // Create the string necessary to connect to the server with UID AND PWD
            // This should be moved into the properties file eventually
            string MyConnection = "datasource=localhost;port=3306;username=root;password=password;";
            Console.WriteLine("create MyConnection for this coupon object");
            try
            {

                 // Create the actual connection to SQL Server
                MySqlConnection myConn = new MySqlConnection(MyConnection);

                myConn.Open();

                MySqlCommand cmd = new MySqlCommand(insertTableSQL, myConn);
                log.Info("inserted" + couponID + "into database");

                cmd.ExecuteNonQuery();

                myConn.Close();
            }
            catch (SQLServiceLoadException e)
            {
                log.Error("failed to insert" + couponID + "into database");
                throw e;
            }
           

        }


        public void updateCoupon(coupon coupon)
        {
            // configure the log4net object with the app.config detail
            // log4net.Config.XmlConfigurator.Configure();
            // log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // local coupon object to receive the incoming object through the method interface
            coupon coupondb2 = coupon;

            // deconstruct all the data fields in the coupon object to prepare to store in 
            // a SQL server
            int couponID = coupondb2.CouponID;
            string couponTitle = coupondb2.CouponTitle;
            string couponDescription = coupondb2.CouponDescription;
            float couponValue = coupondb2.CouponValue;
            string couponStartActive = coupondb2.CouponStartActive;
            string couponEndActive = coupondb2.CouponEndActive;
            string couponLocationsZip = coupondb2.CouponLocationsZip;

            // Create the SQL message to send to the server
            string updateTableSQL = "UPDATE coupon SET couponID='" + couponID + "',couponTitle='" + couponTitle + "',couponDescription='" + couponDescription + "',couponValue='" + couponValue + "',couponStartActive='" + couponStartActive + "',couponEndActive='" + couponEndActive + "',couponLocationsZip='" + couponLocationsZip + "' WHERE couponID='" + couponID + "'";

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
                log.Error("failed to update" + couponID + "into database");
                throw e;
            }


        }

        public void deleteCoupon(coupon coupon)
        {
            // configure the log4net object with the app.config detail
            // log4net.Config.XmlConfigurator.Configure();
            log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // local consumer object to receive the incoming object through the method interface
            coupon coupondb3 = coupon;

            // deconstruct all the data fields in the consumer object to prepare to store in 
            // a SQL server
            int couponID = coupondb3.CouponID;

            // Create the SQL message to send to the server
            string deleteTableSQL = "DELETE from coupon where couponID=" + couponID + ";";
            // Create the string necessary to connect to the server with UID AND PWD
            // This should be moved into the properties file eventually
            string MyConnection = "datasource=localhost;port=3306;username=root;password=password;database=genadx;";
            Console.WriteLine("delete MyConnection for this coupon object");
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
                log.Error("failed to delete" + couponID + "into database");
                throw e;
            }


        }

    }
}

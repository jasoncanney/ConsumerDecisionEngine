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
using NUnit.Framework;

namespace GenAdxCDE.Source.Model.Services.loginservice
{


    /// <summary>
    /// LoginSvcSQLImpl is the service implementation class to store and retrieve login
    /// objects to/from a SQL server
    /// @author Jason Canney
    /// </summary>

    public class LoginSvcSQLImpl : ILoginSvc
    {
        // create a logger object 
        log4net.ILog log;

        public DataTable findLogin()
        {

            // make a list to put the login objects into
            DataTable dt = new DataTable();

            // Create the connection string to send to the mySQL server
            string findLogin = "SELECT * FROM login";
            MySqlConnection myConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString);
            MySqlCommand cmd = new MySqlCommand(findLogin, myConn);

            Console.WriteLine("create MyConnection for this login object");
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
                log.Error("failed to get login data set");
                throw e;
            }
            return dt;

        }

        public bool verifyLogin(login login)
        {
            // make a new login domain object to store the incoming login object
            login logi = new login();

            // create the select statement to send to the sql server for searching for the login object
            string findLogin = "SELECT * FROM login WHERE UserName='" + login.userName + "'";
            
            // get connection string from web.config for mySQL server in azure
            MySqlConnection myConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString);

            // Create the connection string to send to the mySQL server
            MySqlCommand cmd = new MySqlCommand(findLogin, myConn);

            Console.WriteLine("create MyConnection for this login object");
            
                // Create the actual connection to SQL Server
                myConn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                // logi.userName = reader["UserName"].ToString();
                // logi.passWord = reader["PassWord"].ToString();
                
                logi.userName = (string)reader.GetString("UserName");
                logi.passWord = (string)reader.GetString("PassWord");
            }

                // close the connection
                myConn.Close();

            if(login.passWord != logi.passWord)
            {
                return false;
                // log.Error("failed to get verify password as equal");
            }
            else
            {
                return true;
            }

        }

        public string whatIsLoginID(string username)
        {
            // make a new login to put the login objects into
            login logi = new login();

            // Create the connection string to send to the mySQL server
            // create the select statement to send to the sql server for searching for the login object
            string whatIsLoginId = "SELECT * FROM login WHERE UserName='" + username + "'";
            MySqlConnection myConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString);
            MySqlCommand cmd = new MySqlCommand(whatIsLoginId, myConn);

            Console.WriteLine("create MyConnection for this login object");
            try
            {
                // Create the actual connection to SQL Server
                //open the connection
                myConn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    logi.userName = reader.GetString("UserName");
                    logi.passWord = reader.GetString("PassWord");
                }

                // close the connection
                myConn.Close();
            }
            catch (SQLServiceLoadException e)
            {
                log.Error("failed to get login ID data set");
                throw e;
            }
            return logi.userName;

        }


        public login getLogin(int id)
        {

            // make a new login to put the login objects into
            login logi = new login();

            // Create the connection string to send to the mySQL server
            // create the select statement to send to the sql server for searching for the login object
            string findLogin = "SELECT * FROM login WHERE UserName=" + id;
            MySqlConnection myConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString);
            MySqlCommand cmd = new MySqlCommand(findLogin, myConn);

            Console.WriteLine("create MyConnection for this login object");
            try
            {
                // Create the actual connection to SQL Server
                
                //open the connection
                myConn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                logi.userName = reader.GetString("UserName");
                logi.passWord = reader.GetString("PassWord");

                }

                // close the connection
                myConn.Close();
            }
            catch (SQLServiceLoadException e)
            {
                log.Error("failed to get login data set");
                throw e;
            }
            return logi;

        }

        public void storeLogin(login login)
        {
            // configure the log4net object with the app.config detail
            // log4net.Config.XmlConfigurator.Configure();
            log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // local login object to receive the incoming object through the method interface
            login logi = new login();

            // deconstruct all the data fields in the consumer object to prepare to store in 
            // a SQL server
            string userName = login.userName;
            string passWord = login.passWord;

            // Create the SQL message to send to the server
            string insertTableSQL = "INSERT INTO genadx.login(UserName, PassWord) VALUES ('" + userName + "','" + passWord + "')";

            // Create the string necessary to connect to the server with UID AND PWD
            // This should be moved into the properties file eventually
            MySqlConnection myConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString);
            MySqlCommand cmd = new MySqlCommand(insertTableSQL, myConn);

            Console.WriteLine("create MyConnection for this login object");
            try
            {
                // Create the actual connection to SQL Server   
                myConn.Open();

                log.Info("inserted" + userName + "into database");

                cmd.ExecuteNonQuery();

                myConn.Close();
            }
            catch (SQLServiceLoadException e)
            {
                log.Error("failed to insert" + userName + "into database");
                throw e;
            }
           

        }

        public void updateLogin(login login)
        {
            // configure the log4net object with the app.config detail
            // log4net.Config.XmlConfigurator.Configure();
            // log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // local login object to receive the incoming object through the method interface
            login logi = login;

            // deconstruct all the data fields in the consumer object to prepare to store in 
            // a SQL server
            string userName = logi.userName;
            string passWord = logi.passWord;

            // Create the SQL message to send to the server
            string updateTableSQL = "UPDATE login SET UserName='" + userName + "',PassWord='" + passWord + "'";

            // Create the string necessary to connect to the server with UID AND PWD
            MySqlConnection myConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString);
            MySqlCommand cmd = new MySqlCommand(updateTableSQL, myConn);

            Console.WriteLine("update MyConnection for this login object");
            try
            {

                // Create the actual connection to SQL Server
                myConn.Open();

                // log.Info("updated" +userName);

                cmd.ExecuteNonQuery();

                myConn.Close();
            }
            catch (SQLServiceLoadException e)
            {
                log.Error("failed to update" + userName + "into database");
                throw e;
            }


        }

        public void deleteLogin(login login)
        {
            // configure the log4net object with the app.config detail
            // log4net.Config.XmlConfigurator.Configure();
            log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // local login object to receive the incoming object through the method interface
            login logi = login;

            // deconstruct all the data fields in the login object to prepare to store in 
            // a SQL server
            string userName = logi.userName;

            // Create the SQL message to send to the server
            string deleteTableSQL = "DELETE from login where UserName=" + userName + ";";
            // Create the string necessary to connect to the server with UID AND PWD
            MySqlConnection myConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString);
            MySqlCommand cmd = new MySqlCommand(deleteTableSQL, myConn);

            Console.WriteLine("delete MyConnection for this login object");
            try
            {

                // Create the actual connection to SQL Server
                myConn.Open();

                // log.Info("delete" + userName);

                cmd.ExecuteNonQuery();
                // cmd.ExecuteNonQuery();

                myConn.Close();
            }
            catch (SQLServiceLoadException e)
            {
                log.Error("failed to delete" + userName + "into database");
                throw e;
            }
        }
    }
}

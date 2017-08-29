using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace GenAdxCDE_Core.Source.Model.Services.compression
{
    /// <summary>
    /// Summary description of hashing class
    /// </summary>
    public class hashing
    {

        public bool HashPwd(string userinput, string dbvalue)
        {
            // create byte arrays for source and stored data
            byte[] tmpSource;
            byte[] tmpHash;
            // create strings for user input pwd and pwd stored in database
            string sSourceData = userinput;
            string storedData = dbvalue;

            //Create a byte array from source data
            tmpSource = ASCIIEncoding.ASCII.GetBytes(sSourceData);
                
                //Compute hash based on source data
                tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
                // Console.WriteLine(ByteArrayToString(tmpHash));

                sSourceData = "NotMySourceData";
                tmpSource = ASCIIEncoding.ASCII.GetBytes(sSourceData);

                byte[] tmpNewHash;

                tmpNewHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);

                bool bEqual = false;
                if (tmpNewHash.Length == tmpHash.Length)
                {
                    int i = 0;
                    while ((i < tmpNewHash.Length) && (tmpNewHash[i] == tmpHash[i]))
                    {
                        i += 1;
                    }
                    if (i == tmpNewHash.Length)
                    {
                        bEqual = true;
                    }
                }

            if (bEqual)
                return true;
            // Console.WriteLine("The two hash values are the same");
            else
                return false;
              //     Console.WriteLine("The two hash values are not the same");
                //   Console.ReadLine();
              }

        }
              /*  
            static string ByteArrayToString(byte[] arrInput)
            {
                int i;
                StringBuilder sOutput = new StringBuilder(arrInput.Length);
                for (i = 0; i < arrInput.Length - 1; i++)
                {
                    sOutput.Append(arrInput[i].ToString("X2"));
                }
                return sOutput.ToString();
            }
*/

}

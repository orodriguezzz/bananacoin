using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananacoindotNet.BL.business
{
    public static class business
    {
        public static string getSHA256(string password)
        {
            string result = string.Empty;
            try
            {

                byte[] passwordBytes = Encoding.Unicode.GetBytes(password);
                var hasher = System.Security.Cryptography.SHA256.Create();
                byte[] hashedBytes = hasher.ComputeHash(passwordBytes);
                return result;
            }
            catch (Exception ex)
            {
                //Save the logs!
                return result;
            }
        }
    }
}

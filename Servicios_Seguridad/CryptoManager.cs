using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Servicios_Seguridad
{
    public static class CryptoManager
    {
        public static string EncryptString(string text)
        {
            if(string.IsNullOrEmpty(text)) return string.Empty;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashData = sha256.ComputeHash(Encoding.UTF8.GetBytes(text)); //convierto la contraseña en bytes


                //los bytes se convierten en string hexadecimal 
                StringBuilder sb = new StringBuilder(); 
                for (int i = 0; i < hashData.Length; i++)
                {
                    sb.Append(hashData[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}

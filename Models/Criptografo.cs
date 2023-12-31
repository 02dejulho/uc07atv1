using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Models
{
    public static class Criptografo
    {
        public static string TextoCriptografado (string TextoSemFormat)
        {
            MD5 MD5Hasher = MD5.Create();
            byte [] By = Encoding.Default.GetBytes(TextoSemFormat);
            byte [] bytesCriptografado = MD5Hasher.ComputeHash(By);

            StringBuilder SB = new StringBuilder();
            foreach (byte b in bytesCriptografado)
            {
                string DebugB = b.ToString("x2");
                SB.Append(DebugB);        

            }
            return SB.ToString();

        }
    }
}
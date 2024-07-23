using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace SuaCarteiraEmDia.Utils
{
    internal class GeraHash
    {

        // Função para gerar o hash SHA-256 de uma string
        public static string SHA_256(string input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Computa o hash SHA-256 da entrada
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Converte bytes para string hexadecimal
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

    }
}

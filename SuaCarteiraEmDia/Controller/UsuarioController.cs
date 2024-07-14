using SuaCarteiraEmDia.Data;
using SuaCarteiraEmDia.Model;
using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SuaCarteiraEmDia.Controller
{
    public class UsuarioController
    { 
        public static void Salvar(Usuario usuario)
        {
            // validar entradas 

            using (DataContext db = new DataContext())
            {
                db.Usuarios.Add(usuario);
                db.SaveChanges();
            }
        }

        public static Usuario Login(string username, string senha)
        {
            senha = GerarHash(senha);
            using (DataContext db = new DataContext())
            {
                var usuario = db.Usuarios
                              .FirstOrDefault(u => u.UserName == username && u.Senha == senha && u.Ativo == true);

                if (usuario == null)
                {
                    throw new Exception("Usuário ou senha incorreto!");
                }

                return usuario;
            }
        }

        // Função para gerar o hash SHA-256 de uma string
        public static string GerarHash(string input)
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

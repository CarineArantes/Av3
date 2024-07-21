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
        public static void Salvar(string nome, string usermame, string senha, string perguntaCadastro, string respostaCadastro)
        {

            senha = GerarHash(senha);
            Usuario NovoUsuario = new()
            {
                Nome = nome,
                UserName = usermame,
                Senha = senha,
                DataCriacao = DateTime.Now,
                DataAlteracao = DateTime.Now,
                Ativo = true
            };

            try
            {
                using (DataContext db = new DataContext())
                {
                    db.Usuarios.Add(NovoUsuario);
                    db.SaveChanges();
                }
            }
            catch
            {
                throw new Exception("Erro ao cadastrar usuário!");
            }

            try
            {
                respostaCadastro = GerarHash(respostaCadastro);
                PerguntaSeguranca NovaPergunta = new()
                {
                    Pergunta = perguntaCadastro,
                    Resposta = respostaCadastro,
                    DataCriacao = DateTime.Now,
                    UsuarioID = NovoUsuario.Id
                };

                using (DataContext db = new DataContext())
                {
                    db.Perguntas.Add(NovaPergunta);
                    db.SaveChanges();
                }
            }
            catch
            {
                throw new Exception("Erro ao salvar pergunta!");
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

        public static Usuario? BuscarUsuario(string username, bool ativo = false)
        {
            using (DataContext db = new DataContext())
            {
                var usuario = db.Usuarios.Where(u => u.UserName == username);

                if (ativo)
                {
                    usuario = usuario.Where(u => u.Ativo == true);
                }

                return usuario.FirstOrDefault();
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

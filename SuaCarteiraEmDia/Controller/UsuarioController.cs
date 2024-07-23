using SuaCarteiraEmDia.Data;
using SuaCarteiraEmDia.Model;
using SuaCarteiraEmDia.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SuaCarteiraEmDia.Controller
{
    public class UsuarioController
    {
        public static Usuario Login(string username, string senha)
        {
            senha = GeraHash.SHA_256(senha);
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

        public static void Salvar(string nome, string usermame, string senha, string perguntaCadastro, string respostaCadastro)
        {
            senha = GeraHash.SHA_256(senha);

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
                respostaCadastro = GeraHash.SHA_256(respostaCadastro);
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

        public static bool Editar(int IDUsuario, string nome, string usermame, string ?senha)
        {
            try
            {
                using (DataContext db = new DataContext())
                {
                    var usuario = db.Usuarios.FirstOrDefault(u => u.Id == IDUsuario);
                    if(usuario == null) return false;
                    usuario.Nome = nome;
                    usuario.UserName = usermame;
                    if (senha != null) usuario.Senha = GeraHash.SHA_256(senha);
                    usuario.DataAlteracao = DateTime.Now;
                    db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
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

        public static Usuario BuscarUsuario(int IDUsuario, bool ativo = false)
        {
            using (DataContext db = new DataContext())
            {
                var usuario = db.Usuarios.Where(u => u.Id == IDUsuario);
                if (ativo)
                {
                    usuario = usuario.Where(u => u.Ativo == true);
                }
                return usuario.FirstOrDefault();
            }
        }

        public static bool Desativar(int IDUsuario)
        {
            try
            {
                using (DataContext db = new DataContext())
                {
                    var usuario = db.Usuarios.FirstOrDefault(u => u.Id == IDUsuario);
                    if (usuario == null) return false;
                    usuario.DataAlteracao = DateTime.Now;
                    usuario.Ativo = false;
                    db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool AlterarSenha(int IDUsuario, string novasenha)
        {
            try
            {
                novasenha = GeraHash.SHA_256(novasenha);
                using (DataContext db = new DataContext()) {

                    var usuario = db.Usuarios.FirstOrDefault(u => u.Id == IDUsuario);
                    if (usuario != null)
                    {
                        usuario.Senha = novasenha;
                        db.SaveChanges();
                    }
                    else {
                        return false;
                    }            
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

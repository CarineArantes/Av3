using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using SuaCarteiraEmDia.Data;
using SuaCarteiraEmDia.Model;

namespace SuaCarteiraEmDia.Controller
{
    public class CategoriaController
    {
        public static void CriarCategoria(string nome, string cor, int idUsuario)
        {
            Categoria categoria = new Categoria
            {
                Nome = nome,
                Cor = cor,
                UsuarioID = idUsuario

            };


            if (categoria.Nome.Trim().Equals(""))
            {
                throw new Exception("Digite um nome para a categoria");
                return;
            }


            if (categoria.Cor.Trim().Equals(""))
            {
                throw new Exception("Selecione uma cor para a categoria");
                return;
            }


            if (categoria.Nome.Trim().Length>100)
            {
                throw new Exception("O nome da categoria teve ter no maximo 100 caracteres");
                return;
            }


            if (categoria.Cor.Trim().Length > 7)
            {
                throw new Exception("A cor da categoria deve ter no máximo 7 caracteres em hexadecimal");
                return;
            }
            using (DataContext db = new DataContext())
            {
                if (db.Categorias.Any(x => x.Nome.ToLower() == categoria.Nome.ToLower() && x.UsuarioID == idUsuario))
                {
                    throw new Exception("Já existe uma categoria com esse nome");
                    return;
                }

                categoria.Nome = nome;
                categoria.Cor = cor;
                categoria.UsuarioID = idUsuario;
                categoria.DataCriacao = DateTime.Now;
                categoria.DataAlteracao = DateTime.Now;
                categoria.Ativo = true;
                db.Categorias.Add(categoria);

                db.SaveChanges();




            }
        }

        internal static void Atualizar(Categoria categoria)
        {
            if (categoria.Nome.Trim() == "")
            {

                throw new Exception("Digite um nome para a categoria");
                return;
            }

            if (categoria.Cor.Trim().Equals(""))
            {
                throw new Exception("Digite uma cor para a categoria");
                return;
            }



            using (DataContext db = new DataContext())
            {
             

               

                    if (db.Categorias.Any(x => x.Nome.ToLower() == categoria.Nome.ToLower() && x.UsuarioID == categoria.UsuarioID && x.Id !=categoria.Id))
                    {
                    
                        throw new Exception("Já existe uma categoria com esse nome");
                        return;
                    }

                
                db.Categorias.Update(categoria);
                db.SaveChanges();
            }
        }

        public static List<Categoria> listarCategorias(string p_ativo, int idUsuario)
        {

            using (DataContext db = new DataContext())
            {
                if (p_ativo.Equals("Inativos"))
                {
                    return db.Categorias.Where(p => p.Ativo == false && p.UsuarioID == idUsuario).OrderBy(x => x.DataCriacao).ToList();
                }
                else if (p_ativo.Equals("Ativos"))
                {
                    return db.Categorias.Where(p => p.Ativo == true && p.UsuarioID == idUsuario).OrderBy(x => x.DataCriacao).ToList();
                }
                else if (p_ativo.Equals("Todos"))
                {
                    return db.Categorias.Where(p => p.UsuarioID == idUsuario).OrderBy(x => x.DataCriacao).ToList();


                }
                else
                {
                    List<Categoria> c = new List<Categoria>();
                    return c;
                }

            }
        }

        internal static Categoria PesquisarCategoria(Categoria c)
        {
            using (DataContext db = new DataContext())
            {
                Categoria categoria = db.Categorias.FirstOrDefault(u => u.Id == c.Id);

                return categoria;

            }
        }

        internal static void Excluir(Categoria categoria)
        {
            using (DataContext db = new DataContext())
            {
                if (db.Categorias.Any(x => x.Id == categoria.Id && x.UsuarioID == categoria.UsuarioID))
                {
                    db.Categorias.Remove(categoria);
                    db.SaveChanges();
                }
            }
        }

    }
}


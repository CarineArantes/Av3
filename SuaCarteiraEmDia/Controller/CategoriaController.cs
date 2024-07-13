using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuaCarteiraEmDia.Data;
using SuaCarteiraEmDia.Model;

namespace SuaCarteiraEmDia.Controller
{
    public class CategoriaController
    {
        public static void CriarCategoria(Categoria categoria)
        {
            // validar entradas 
            if (categoria.Nome.Trim() == "")
            {
                Console.WriteLine("Digite um nome para a categoria");
                return;
            }


            if (categoria.Cor.Trim() == "")
            {
                Console.WriteLine("Digite uma cor para a categoria");
                return;
            }

            using (DataContext db = new DataContext())
            {
                if (db.Categorias.Any(x => x.Nome == categoria.Nome))
                {
                    Console.WriteLine("Título já existe");
                    return;
                }

                categoria.UsuarioID = 1;
                categoria.DataCriacao = DateTime.Now;
                categoria.DataAlteracao = DateTime.Now;
                categoria.Ativo = true;
                db.Categorias.Add(categoria);

                db.SaveChanges();




            }
        }

        
        public static List<Categoria> listarCategorias()
        {

            using (DataContext db = new DataContext())
            {
                    return db.Categorias.ToList();
               


            }
        }

    }
}


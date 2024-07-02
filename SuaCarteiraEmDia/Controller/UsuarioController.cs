using SuaCarteiraEmDia.Data;
using SuaCarteiraEmDia.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuaCarteiraEmDia.Controller
{
    public class UsuarioController { 
        public static void Salvar(Usuario usuario)
        {
            // validar entradas 

            using (DataContext db = new DataContext())
            {
                db.Usuarios.Add(usuario);
                db.SaveChanges();
            }
        }

    }
}

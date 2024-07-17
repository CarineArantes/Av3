using SuaCarteiraEmDia.Data;
using SuaCarteiraEmDia.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace SuaCarteiraEmDia.Controller
{
    public class PerguntaController
    {
        public static void Salvar(PerguntaSeguranca pergunta)
        {
            using (DataContext db = new DataContext())
            {
                db.Perguntas.Add(pergunta);
                db.SaveChanges();
            }
        }
    }
}

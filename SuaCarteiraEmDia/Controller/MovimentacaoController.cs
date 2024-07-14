using SuaCarteiraEmDia.Data;
using SuaCarteiraEmDia.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuaCarteiraEmDia.Controller
{
    internal class MovimentacaoController
    {

        public MovimentacaoController() { }



        public static List<Movimentacao> Busca(int IDUsuario, DateTime dataReferencia)
        {
            string x = dataReferencia.ToString("yyyy-MM-dd");
            DateTime dataReferencia1 = DateTime.Parse(x);
            MessageBox.Show($"{dataReferencia} => {x} => {dataReferencia1}");



            using (DataContext db = new DataContext())
            {
               return db.Movimentacoes
                              .Where(u => u.UsuarioID == IDUsuario && u.DataMovimentacao == new DateTime() && u.Ativo == true).ToList();
            }
        }
    }
}

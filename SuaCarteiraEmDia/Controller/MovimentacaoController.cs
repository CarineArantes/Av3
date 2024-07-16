using Microsoft.EntityFrameworkCore;
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
            using (DataContext db = new DataContext())
            {
               return db.Movimentacoes
                              .Where(m => m.UsuarioID == IDUsuario && m.DataMovimentacao.Date == dataReferencia.Date && m.Ativo == true)
                              .Include(c => c.Categoria)
                              .ToList();
            }
        }

        public static decimal SaldoCarteira(int IDUsuario) {

            using (DataContext db = new DataContext())
            {
                return db.Movimentacoes
                        .Where(m => m.UsuarioID == IDUsuario)
                        .Select(t => t.Tipo == 'E' ? t.Valor : -t.Valor)
                        .Sum();
            }
        }

    }
}

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SuaCarteiraEmDia.Controller
{
    internal class MovimentacaoController
    {

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

        public static bool Salvar(char tipo, int IDcategoria, decimal valor, string descricao, int IDUsuario, DateTime dataMovimentacao)
        {
            try
            {
                Movimentacao NovaMovimentacao = new()
                 {
                     Tipo = tipo,
                     Valor = valor,
                     Descricao = descricao,
                     CategoriaID = IDcategoria,
                     UsuarioID = IDUsuario,
                     DataCriacao = DateTime.Now,
                     DataAlteracao = DateTime.Now,
                     DataMovimentacao = dataMovimentacao,
                     Ativo = true
                 };
                 using (DataContext db = new DataContext())
                 {
                     db.Movimentacoes.Add(NovaMovimentacao);
                     db.SaveChanges();
                 }
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}

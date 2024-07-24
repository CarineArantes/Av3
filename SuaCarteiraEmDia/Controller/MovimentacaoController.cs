using Microsoft.EntityFrameworkCore;
using SuaCarteiraEmDia.Data;
using SuaCarteiraEmDia.Model;
using SuaCarteiraEmDia.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SuaCarteiraEmDia.View.FrmMovimentacao;
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
                        .Where(m => m.UsuarioID == IDUsuario && m.Ativo == true)
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

        public static bool Editar(int IDMovimentacao, char tipo, int IDcategoria, decimal valor, string descricao, int IDUsuario, DateTime dataMovimentacao)
        {
            try
            {
                using (DataContext db = new DataContext())
                {
                    var movimetacao = db.Movimentacoes.FirstOrDefault(m => m.Id == IDMovimentacao);
                    if (movimetacao == null) return false;
                    movimetacao.Tipo = tipo;
                    movimetacao.Valor = valor;
                    movimetacao.Descricao = descricao;
                    movimetacao.CategoriaID = IDcategoria;
                    movimetacao.UsuarioID = IDUsuario;
                    movimetacao.DataAlteracao = DateTime.Now;
                    movimetacao.DataMovimentacao = dataMovimentacao;
                    db.SaveChanges();
                }
            }
            catch
            {
                return false;
            }
            return true;

        }

        public static bool Desativar(int IDMovimentacao)
        {
            try
            {
                using (DataContext db = new DataContext())
                {
                    var movimentacao = db.Movimentacoes.FirstOrDefault(m => m.Id == IDMovimentacao);
                    if (movimentacao == null) return false;
                    movimentacao.DataAlteracao = DateTime.Now;
                    movimentacao.Ativo = false;
                    db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}

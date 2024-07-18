using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SuaCarteiraEmDia.Data;
using SuaCarteiraEmDia.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuaCarteiraEmDia.Controller
{
    public class RelatorioController
    {

        private static string connectionString = "";

        public static List<RelatorioMovimentacao> GetRelatorios(int idUsuario, DateTime dataInicio, DateTime dataFinal)
        {
            using (DataContext db = new DataContext())
            {
                connectionString = db.Database.GetConnectionString();


            }


            string dtaInicio = dataInicio.ToString("yyyy/MM/dd");
            string dtaFinal = dataFinal.ToString("yyyy/MM/dd");

            string sqlQuery = "SELECT " +
                "m.Valor, m.Tipo," + "m.Descricao, " +
                "m.DataMovimentacao, " +
                "c.Nome, " + "c.id FROM Movimentacoes AS m " +
                "INNER JOIN Categorias AS c " +
                "ON c.Id = m.CategoriaID " +
                "AND c.UsuarioID = c.UsuarioID " +
                "INNER JOIN Usuarios AS u " +
                "ON u.Id = m.UsuarioID " +
                "WHERE u.Id = " + idUsuario +
                " and CONVERT (date,  m.DataMovimentacao  ) " +
                "between CONVERT (date,'" + dtaInicio + "') " +
                " and  CONVERT(date, '" + dtaFinal + "') and  m.Ativo = 1 ";


            List<RelatorioMovimentacao> listRel = new List<RelatorioMovimentacao>();
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        decimal valor = (decimal)reader["Valor"];
                        string tipo = (string)reader["Tipo"];
                        string descricao = (string)reader["Descricao"];
                        DateTime dataMovimentacao = (DateTime)reader["DataMovimentacao"];
                        string nomeCategoria = (string)reader["Nome"];
                        int idCategoria = (int)reader["id"];

                        listRel.Add(new RelatorioMovimentacao { Valor = valor, Tipo = tipo, Descricao = descricao, DataMovimentacao = dataMovimentacao, Categoria = nomeCategoria, IDCategoria = idCategoria });
                    }
                }

                else
                {
                    return listRel;
                }

               
                    
                     
                
                reader.Close();

                return listRel;


            }
        }

        public static decimal SaldoTotal(int idUsuario)
        {
            using (DataContext db = new DataContext())
            {
                connectionString = db.Database.GetConnectionString();


            }

            decimal valorTotalSaldo = 0; ;

            string sqlQuery = "declare @valorTotal decimal (18,3), " +
                "@valorSaida decimal (18,3), " +
                " @valorEntrada decimal (18,3); " +
                "select @valorSaida = sum( isnull( Valor,0.0)) " +
                "from Movimentacoes as m " +
                "where m.UsuarioID = '" + idUsuario + "' " +
                "and m.Tipo = 'S' " +
                "AND  m.Ativo = 1 " +
                "select @valorEntrada= sum( isnull( Valor,0.0)) " +
                "from Movimentacoes as m " +
                "where m.UsuarioID = '"+idUsuario+"' "+
                " and m.Tipo = 'E'  " +
                "AND  m.Ativo = 1 " +
                "set @valorTotal = isnull(@valorEntrada - @valorSaida ,0)" +
                "select @valorTotal ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                SqlCommand command = new SqlCommand(sqlQuery, connection);


                
                connection.Open();

                
                SqlDataReader reader = command.ExecuteReader();

               
              

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        valorTotalSaldo = reader.GetDecimal(0);
                    }
                }
                else
                {
                    valorTotalSaldo = 0;
                }
                reader.Close();


                return valorTotalSaldo;
                    
            }

        }

        

        public static decimal SomaTipo(List<RelatorioMovimentacao> rel, string tipo)
        {
            decimal valorSoma = 0;

            foreach(RelatorioMovimentacao dados in rel)
            {
                if (dados.Tipo == tipo)
                {
                    valorSoma += dados.Valor;
                }
                }

                return valorSoma;
        }


        public static decimal SomaTotal(List<RelatorioMovimentacao> rel)
        {
            decimal valorSoma = 0;

            valorSoma = SomaTipo(rel, "E");
            valorSoma -= SomaTipo(rel, "S");

            return valorSoma;
        }

      



        public static List<RelatorioMovimentacao> FiltrarTiposMovimentacoes(List<RelatorioMovimentacao> rel, string filtro)
        {

            List<RelatorioMovimentacao> relatorioFiltrado = rel.Where(r => r.Tipo == filtro).ToList();

            return relatorioFiltrado;

        }


        public static List<RelatorioMovimentacao> FiltrarCategoriasList (List<RelatorioMovimentacao> rel, string selecionados)
        {

            string[] numeros = selecionados.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> numerosInt = numeros.Select(n => int.Parse(n.Trim())).ToList();

            List<RelatorioMovimentacao> relatorioFiltrado = rel.Where(r => numerosInt.Contains(r.IDCategoria)).ToList();

            return relatorioFiltrado;

        }

    }
}

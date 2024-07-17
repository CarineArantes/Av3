using SuaCarteiraEmDia.Controller;
using SuaCarteiraEmDia.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuaCarteiraEmDia.View
{
    internal class EstiloRelatorio
    {

        public void Colunas(DataGridView grid)
        {
            grid.Columns.Add("Valor", "Valor");
            grid.Columns.Add("Tipo", "Tipo");
            grid.Columns.Add("Descricao", "Descrição");
            grid.Columns.Add("DataMovimentacao", "Data da Movimentação");
            grid.Columns.Add("NomeCategoria", "Categoria");

        }

        public void PopularGrid(DataGridView grid,List<RelatorioMovimentacao> rel)
        {
            

            grid.Rows.Clear();
            foreach (RelatorioMovimentacao x in rel)
            {

                grid.Rows.Add(
                 x.Valor,
                x.Tipo,
                 x.Descricao,
                 x.DataMovimentacao,
                x.Categoria

                );

            }
            PintarCategoria(grid, rel);
        }


        public void PintarCategoria(DataGridView grid, List<RelatorioMovimentacao> rel )
        {

            for (int i = 0; i < rel.Count; i++)
            {

                Categoria c = CategoriaController.PesquisarCategoria(new Categoria() {  Id = rel[i].IDCategoria });

                Color color = ColorTranslator.FromHtml(c.Cor);

                grid.Rows[i].Cells[4].Style.BackColor = color;
                grid.Rows[i].Cells[4].Style.ForeColor = color;
                

            }
        }
    }
}

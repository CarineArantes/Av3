using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SuaCarteiraEmDia.Controller;
using SuaCarteiraEmDia.Data;
using SuaCarteiraEmDia.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuaCarteiraEmDia.View.Principal
{



    public partial class UserControlRelatorio : UserControl
    {

        List<RelatorioMovimentacao> rel = new List<RelatorioMovimentacao>();
        decimal somaTotal = 0;
        decimal somaEntrada = 0;
        decimal somaSaida = 0;
        int IDUser;

        public UserControlRelatorio(int IDUser)
        {
            InitializeComponent();
            this.IDUser = IDUser;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControlRelatorio_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker2.MaxDate = DateTime.Now;


            checkedListBox1.Items.Clear();
            checkedListBox1.Enabled = false;

            List<Categoria> categorias = CategoriaController.listarCategorias("Todos",IDUser);

            // Defina as propriedades DisplayMember e ValueMember
            checkedListBox1.DisplayMember = "Nome";
            checkedListBox1.ValueMember = "Id";

            // Adicione as categorias ao CheckedListBox
            foreach (var categoria in categorias)
            {
                checkedListBox1.Items.Add(categoria);
            }





            DateTime DataAtual = DateTime.Now;
            rel = RelatorioController.GetRelatorios(IDUser, DataAtual, DataAtual);

            EstiloRelatorio er = new EstiloRelatorio();
            er.Colunas(dataGridView1);
            er.PopularGrid(dataGridView1, rel);
            er.PintarCategoria(dataGridView1, rel);

            somaTotal = RelatorioController.SomaTotal(rel);

            somaTotal = somaTotal < 0 ? somaTotal * -1 : somaTotal;


            label1.Text = "Soma total: " + somaTotal.ToString();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            somaTotal = 0;

            DateTime dataInicio = dateTimePicker1.Value;
            DateTime dataFinal = dateTimePicker2.Value;

            DateOnly data_inicial = DateOnly.FromDateTime(dataInicio);
            DateOnly data_final = DateOnly.FromDateTime(dataFinal);


            if (data_inicial > data_final)
            {
                MessageBox.Show("A data inicial não pode ser maior que a final");

                return;
            }

            string itensSelecionados = "";

            int quantSelecionados = 0;

            foreach (var item in checkedListBox1.CheckedItems)
            {
                Categoria categoria = (Categoria)item;
                int categoriaId = categoria.Id;
                itensSelecionados += categoriaId.ToString() + ",";
                quantSelecionados++;

            }

            if (radioButton2.Checked && quantSelecionados == 0)
            {
                MessageBox.Show("Necessário selecionar 1 ou mais categorias  para filtrar por categoria", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            rel = RelatorioController.GetRelatorios(1, dataInicio, dataFinal);

            if (radioButton2.Checked)
            {
                rel = RelatorioController.FiltrarCategoriasList(rel, itensSelecionados);
            }


            if (PegarValorRadio(tiposMovimentacoes) == "E")
            {
                rel = RelatorioController.FiltrarTiposMovimentacoes(rel, PegarValorRadio(tiposMovimentacoes));

            }

            if (PegarValorRadio(tiposMovimentacoes) == "S")
            {
                rel = RelatorioController.FiltrarTiposMovimentacoes(rel, PegarValorRadio(tiposMovimentacoes));

                
                
            }

            somaTotal = RelatorioController.SomaTotal(rel);



            EstiloRelatorio er = new EstiloRelatorio();
            er.PopularGrid(dataGridView1, rel);

            somaTotal = somaTotal < 0 ? somaTotal*-1 : somaTotal ;

            label1.Text = "Soma de movimentações do valor filtrado: " + somaTotal.ToString();


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                checkedListBox1.Enabled = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                checkedListBox1.Enabled = false;
            }
        }

        

        private void relatorioControllerBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private string PegarValorRadio(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }
            return string.Empty; // Retorna uma string vazia se nenhum RadioButton estiver selecionado
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

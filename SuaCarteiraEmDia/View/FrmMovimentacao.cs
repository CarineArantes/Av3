using SuaCarteiraEmDia.Controller;
using SuaCarteiraEmDia.Model;
using SuaCarteiraEmDia.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SuaCarteiraEmDia.View
{
    public partial class FrmMovimentacao : Form
    {
        int IDUsuario;
        Action Action;
        Movimentacao ?Movimentacao;

        public class Tipo
        {
            public string tipo { get; set; }
            public string nome { get; set; }
        }

        public FrmMovimentacao(int iDUsuario, Action action)
        {
            InitializeComponent();
            this.IDUsuario = iDUsuario;
            this.Action = action;
        }

        public FrmMovimentacao(int IDUsuario, Movimentacao movimentacao, Action action)
        {
            InitializeComponent();
            this.Action = action;
            this.Movimentacao = movimentacao;
            this.IDUsuario = IDUsuario;
        }


        private void FrmMovimentacao_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now;

            // comboBoxTipo tipo de  movimentação
            List<Tipo> items = new List<Tipo>{
                new Tipo { tipo = "E", nome = "Entrada" },
                new Tipo { tipo = "S", nome = "Saida" },
            };
            comboBoxTipo.DataSource = items;
            comboBoxTipo.DisplayMember = "nome";
            comboBoxTipo.ValueMember = "tipo";



            // comboBoxCategoria categoria
            var categorias = CategoriaController.listarCategorias("Ativos", IDUsuario);
            if (categorias.Count > 0)
            {
                comboBoxCategoria.DataSource = categorias;
                comboBoxCategoria.DisplayMember = "Nome";
                comboBoxCategoria.ValueMember = "Id";
                comboBoxCategoria.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Para criar uma nova movimentação é necessario ter ao menos 1 categoria ativa");
                this.Close();
            }

            if (Movimentacao != null) {
                textBoxDescricao.Text = Movimentacao.Descricao;
                textBoxValor.Text = Movimentacao.Valor.ToString();
                int index = -1;
                for (int i = 0; i < comboBoxCategoria.Items.Count; i++)
                {
                    var categoria = (Categoria)comboBoxCategoria.Items[i];
                    if (categoria.Id == Movimentacao.CategoriaID)
                    {
                        index = i;
                        break;
                    }
                }
                if (index != -1)
                {
                    comboBoxCategoria.SelectedIndex = index;
                }
                else
                {
                    MessageBox.Show("Categoria da movimentação não encontrada na lista.");
                }

                for (int i = 0; i < comboBoxTipo.Items.Count; i++)
                {
                    var tipo = (Tipo)comboBoxTipo.Items[i];
                    if (tipo.tipo == Movimentacao.Tipo.ToString())
                    {
                        index = i;
                        break;
                    }
                }
                if (index != -1)
                {
                    comboBoxTipo.SelectedIndex = index;
                }
                else
                {
                    MessageBox.Show("Tipo da movimentação não encontrado na lista.");
                }
                dateTimePicker1.Value = Movimentacao.DataMovimentacao;
            }








        }

        private void textBoxValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // Apenas permite uma vírgula para separação decimal
            if ((e.KeyChar == ',') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (comboBoxTipo.SelectedIndex == -1)
            {
                MessageBox.Show("TIPO: Informe o tipo de movimentação !");
                return;
            }
            if (textBoxValor.Text.Trim().Length <= 0)
            {
                MessageBox.Show("MOVIMENTAÇÃO: Informe o valor da movimentação !");
                return;
            }
            if (comboBoxCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("CATEGORIA: Informe uma categoria !");
                return;
            }
            if (textBoxDescricao.Text.Trim().Length < 3 || textBoxDescricao.Text.Trim().Length > 100)
            {
                MessageBox.Show("DESCRIÇÃO: Descrição deve conter no mínimo 3 caracteres e no máximo 100 caracteres.");
                return;
            }

            char tipo;
            if (comboBoxTipo.SelectedIndex != -1)
            {
                tipo = comboBoxTipo.SelectedValue.ToString()[0];
            }
            else
            {
                MessageBox.Show("Erro ao validar tipo de movimentação");
                return;
            }

            decimal valor;
            if (!decimal.TryParse(textBoxValor.Text, out valor))
            {
                MessageBox.Show("Erro ao validar valor informado");
                return;
            }

            int idCategoria;
            if (!int.TryParse(comboBoxCategoria?.SelectedValue?.ToString(), out idCategoria))
            {
                MessageBox.Show("Erro ao validar categoria");
                return;
            }

            if (Movimentacao != null)
            {
                bool sucesso = MovimentacaoController.Editar(
                  Movimentacao.Id,
                  tipo,
                  idCategoria,
                  valor,
                  textBoxDescricao.Text,
                  IDUsuario,
                  dateTimePicker1.Value.Date
              );
                if (sucesso)
                {
                    MessageBox.Show("Movimentação editada com sucesso !");
                    Action();
                    this.Close();
                    return;
                }
                MessageBox.Show("Erro ao editar movimentação !");
            }
            else {

                bool sucesso = MovimentacaoController.Salvar(
                   tipo,
                   idCategoria,
                   valor,
                   textBoxDescricao.Text,
                   IDUsuario,
                   dateTimePicker1.Value.Date
               );
                if (sucesso)
                {
                    MessageBox.Show("Movimentação salva com sucesso !");
                    Action();
                    this.Close();
                    return;
                }
                MessageBox.Show("Erro ao salvar movimentação !");
            }
        }
    }
}

using SuaCarteiraEmDia.Controller;
using SuaCarteiraEmDia.Model;
using SuaCarteiraEmDia.View.Principal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuaCarteiraEmDia.View.Catagoria
{
    public partial class FrmCategoriaEditar : Form
    {
        int? idUsuario;
        int? IdAtual = null;
        DateTime? dataCricao = null;
        string cor = "";
        public FrmCategoriaEditar(int id, int? iduser)
        {
            InitializeComponent();
            idUsuario = iduser;
            IdAtual = id;

            Categoria categoria = CategoriaController.PesquisarCategoria(new Categoria() { Id = id });
            dataCricao = categoria.DataCriacao;


            if (categoria != null)
            {
                txtNomCategoria.Text = categoria.Nome;

                Color color = ColorTranslator.FromHtml(categoria.Cor);

                txtCor.BackColor = color;
                txtCorHexadecimal.Text = categoria.Cor.ToString();
                checkAtivo.Checked = categoria.Ativo;


            }
            else
            {
                MessageBox.Show("Selecione outra categoria, essa não existe");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (txtNomCategoria.Text.Trim() == "")
            {
                MessageBox.Show("Digite um nome para a categoria", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtCorHexadecimal.Text.Trim() == "")
            {
                MessageBox.Show("Selecione uma cor para a categoria", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            string ativo = "Ativos";
            ativo = checkAtivo.Checked ? "Ativos" : "Inativos";




            Categoria categoria = new Categoria();
            categoria.Nome = txtNomCategoria.Text.Trim();
            categoria.Ativo = checkAtivo.Checked;
            categoria.Cor = txtCorHexadecimal.Text;
            categoria.DataCriacao = (DateTime)dataCricao;
            categoria.DataAlteracao = DateTime.Now;
            categoria.Id = (int)IdAtual;
            categoria.UsuarioID = (int)idUsuario;

            try
            {

                CategoriaController.Atualizar(categoria);

                MessageBox.Show("Categoria cadastrada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();




            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog1.Color;
                string hexColor = ColorToHex(selectedColor);
                MessageBox.Show($"A cor selecionada é {hexColor}");

                Color color = ColorTranslator.FromHtml(hexColor);


                txtCor.BackColor = color;
                txtCorHexadecimal.Text = hexColor.ToString();
                cor = hexColor.ToString();

            }

        }
        public string ColorToHex(Color color)
        {
            return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
        }
    }


}

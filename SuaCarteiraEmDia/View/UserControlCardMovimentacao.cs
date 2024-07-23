using SuaCarteiraEmDia.Controller;
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
    public partial class UserControlCardMovimentacao : UserControl
    {
        Movimentacao Movimentacao;
        Action Action;
        public UserControlCardMovimentacao(Movimentacao movimentacao, Action action)
        {
            InitializeComponent();
            this.Movimentacao = movimentacao;
            this.Action = action;
        }

        private void UserControlCardMovimentacao_Load(object sender, EventArgs e)
        {
            Image img = pictureBox.Image;
            textBoxValor.Text = Movimentacao.Valor.ToString();
            textBoxCategoria.Text = Movimentacao.Categoria.Nome.ToString();
            richTextBoxDescricao.Text = Movimentacao.Descricao.ToString();
            textBoxCategoria.ForeColor = ColorTranslator.FromHtml(Movimentacao.Categoria.Cor);

            // Centraliza o texto no RichTextBox
            richTextBoxDescricao.SelectAll(); // Seleciona todo o texto
            richTextBoxDescricao.SelectionAlignment = HorizontalAlignment.Center; // Alinha o texto ao centro
            richTextBoxDescricao.DeselectAll(); // Deseleciona o texto

            if (Movimentacao.Tipo == 'S')
            {
                img.RotateFlip(RotateFlipType.Rotate180FlipNone);
                pictureBox.BackColor = Color.FromArgb(222, 73, 56);
                textBoxValor.ForeColor = Color.FromArgb(222, 73, 56);
            }
            else
            {
                pictureBox.BackColor = Color.FromArgb(0, 167, 89);
                textBoxValor.ForeColor = Color.FromArgb(0, 167, 89);
            }
            pictureBox.Image = img;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Deseja realmete excluir está movimentação ?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );

            if (result == DialogResult.Yes)
            {
                bool desativado = MovimentacaoController.Desativar(Movimentacao.Id);
                if (desativado)
                {
                    MessageBox.Show("Movimentação excluida com sucesso !");
                    Action();
                    return;
                }
                MessageBox.Show("Erro ao excluida movimentação !");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmMovimentacao editarMovimentacao = new FrmMovimentacao(Movimentacao.UsuarioID, Movimentacao, () => Action());
            editarMovimentacao.Show();
        }

    }
}

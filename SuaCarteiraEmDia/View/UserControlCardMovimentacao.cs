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
        public UserControlCardMovimentacao(Movimentacao movimentacao)
        {
            InitializeComponent();
            this.Movimentacao = movimentacao;
        }

        private void UserControlCardMovimentacao_Load(object sender, EventArgs e)
        {
            textBox1.Text = Movimentacao.Tipo.ToString();
            textBox2.Text = Movimentacao.Valor.ToString();
            textBox3.Text = Movimentacao.Categoria.Nome.ToString();
            textBox4.Text = Movimentacao.Descricao.ToString();
            textBox5.Text = Movimentacao.DataMovimentacao.Date.ToString();
        }
    }
}

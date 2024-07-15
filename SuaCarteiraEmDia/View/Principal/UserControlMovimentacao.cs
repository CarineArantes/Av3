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
using static Azure.Core.HttpHeader;

namespace SuaCarteiraEmDia.View.Principal
{
    public partial class UserControlMovimentacao : UserControl
    {
        int IDUsuario;
        public UserControlMovimentacao(int IDUsuario)
        {
            InitializeComponent();
            this.IDUsuario = IDUsuario;
        }

        private void buscaDados()
        {
            List<Movimentacao> movimentacaos = MovimentacaoController.Busca(IDUsuario, dateTimePicker1.Value.Date);
            if (movimentacaos.Count > 1)
            {
                foreach (Movimentacao movimentacao in movimentacaos) {
                    flowLayou1.Controls.Add(new UserControlCardMovimentacao(movimentacao));
                }
            }
            else
            {
                MessageBox.Show("NAO há dados");
            }

        }

        private void UserControlMovimentacao_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now;
            buscaDados();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            buscaDados();
        }
    }
}

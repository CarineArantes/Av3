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

        private void BuscaDados()
        {
            flowLayou1.Controls.Clear();
            List<Movimentacao> movimentacoes = MovimentacaoController.Busca(IDUsuario, dateTimePicker1.Value.Date);
            if (movimentacoes.Count > 1)
            {
                foreach (Movimentacao movimentacao in movimentacoes) {
                    flowLayou1.Controls.Add(new UserControlCardMovimentacao(movimentacao));
                }
            }

            decimal totalCarteira = MovimentacaoController.SaldoCarteira(IDUsuario);
            decimal totalEntrada = movimentacoes.Where(m => m.Tipo == 'E').Sum(m => m.Valor);
            decimal totalSaida = movimentacoes.Where(m => m.Tipo == 'S').Sum(m => m.Valor);


            textBoxSaldoCarteira.Text = totalCarteira.ToString();
            textBoxEntrada.Text = totalEntrada.ToString();
            textBoxSaida.Text = totalSaida.ToString(); 
            textBoxSaldoDia.Text = (totalEntrada - totalSaida).ToString();
        }

        private void UserControlMovimentacao_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now;
            BuscaDados();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            BuscaDados();
        }
    }
}

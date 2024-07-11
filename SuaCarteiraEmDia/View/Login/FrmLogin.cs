using Microsoft.EntityFrameworkCore;
using SuaCarteiraEmDia.Data;
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

namespace SuaCarteiraEmDia.View.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            using (var dbContext = new DataContext())
            {
                try
                {
                    if (dbContext.Database.CanConnect())
                    {
                    }
                    else
                    {
                        MessageBox.Show($"Erro ao iniciar o sistema!{Environment.NewLine}Por favor entre em contato com o administrador. ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                    }
                }
                catch
                {
                    MessageBox.Show($"Erro ao iniciar o sistema!{Environment.NewLine}Por favor entre em contato com o administrador. ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void esqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRecuperarSenha recuperarSenha = new FrmRecuperarSenha();
            recuperarSenha.Show();
        }

        private void cadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCadastro cadastro = new FrmCadastro();
            cadastro.Show();
        }
    }
}

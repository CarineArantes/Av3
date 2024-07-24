using Microsoft.EntityFrameworkCore;
using SuaCarteiraEmDia.Data;
using SuaCarteiraEmDia.Model;
using SuaCarteiraEmDia.Utils;
using SuaCarteiraEmDia.View;
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
            ConfigurarCamposDeSenha();
        }
        
        private void ConfigurarCamposDeSenha()
        {
            senha.UseSystemPasswordChar = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text.Trim().Length <= 0 || senha.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!");
            }
            else
            {
                try
                {
                    Usuario usuario = Controller.UsuarioController.Login(username.Text, senha.Text);
                    if (usuario != null)
                    {
                        FrmPrincipal principal = new FrmPrincipal(usuario);
                        principal.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void esqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Verificacoes verificacoes = new Verificacoes();

            if (string.IsNullOrWhiteSpace(username.Text))
            {
                MessageBox.Show("Por favor, informe o username");
                return;
            }

            if (!verificacoes.verificarCaracteres(username.Text, 60, 4))
            {
                MessageBox.Show("O username deve conter entre 4 e 60 caracteres");
                return;
            }

            Usuario usuario = Controller.UsuarioController.BuscarUsuario(username.Text, true);

            if (usuario != null)
            {
                FrmRecuperarSenha recuperarSenha = new FrmRecuperarSenha(usuario.Id);
                recuperarSenha.Show();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado!");
            }

        }

        private void cadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCadastro cadastro = new FrmCadastro();
            cadastro.Show();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

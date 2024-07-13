using Microsoft.EntityFrameworkCore;
using SuaCarteiraEmDia.Data;
using SuaCarteiraEmDia.Utils;
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

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void senha_TextChanged(object sender, EventArgs e)
        {

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
                  bool login = Controller.UsuarioController.Login(username.Text, senha.Text);
                    if (login)
                    {
                        FrmPrincipal principal = new FrmPrincipal();
                        principal.Show();
                        this.Hide();
                           
                    }
                }
                catch(Exception ex) {
                    MessageBox.Show(ex.Message);
                }
               
            }


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

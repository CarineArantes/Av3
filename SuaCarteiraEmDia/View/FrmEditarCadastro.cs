using System;
using System.Collections.Generic;
using SuaCarteiraEmDia.Model;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuaCarteiraEmDia.Utils;
using SuaCarteiraEmDia.Controller;
using SuaCarteiraEmDia.View.Login;

namespace SuaCarteiraEmDia.View
{
    public partial class FrmEditarCadastro : Form
    {
        Usuario usuario;
        bool redefinirSenha = false;

        public FrmEditarCadastro(Usuario usuario)
        {
            InitializeComponent();
            ConfigurarCamposDeSenha();
            this.usuario = usuario;
            nomeCadastro.Text = usuario.Nome;
            usernameCadastro.Text = usuario.UserName;
        }

        private void ConfigurarCamposDeSenha()
        {
            senhaAtual.UseSystemPasswordChar = true;
            novaSenha.UseSystemPasswordChar = true;
            confNovaSenha.UseSystemPasswordChar = true;
        }

        private void btnRedefinirSenha_Click(object sender, EventArgs e)
        {
            if (!redefinirSenha)
            {
                groupBox1.Enabled = true;
                senhaAtual.Text = "";
            }
            else
            {
                groupBox1.Enabled = false;
                senhaAtual.Text = "";
                novaSenha.Text = "";
                confNovaSenha.Text = "";
            }

            redefinirSenha = !redefinirSenha;
            if (redefinirSenha)
            {
                btnRedefinirSenha.Text = "Cancelar redefinição de senha";
            }
            else
            {
                btnRedefinirSenha.Text = "Redefinir Senha";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Verificacoes verificacoes = new Verificacoes();

            if (!verificacoes.verificarCaracteres(nomeCadastro.Text, 60, 3))
            {
                MessageBox.Show("O nome deve conter entre 3 e 60 caracteres");
                return;
            }

            if (!verificacoes.verificarCaracteres(usernameCadastro.Text, 60, 4))
            {
                MessageBox.Show("O username deve conter entre 4 e 60 caracteres");
                return;
            }

            if (redefinirSenha)
            {
                if (!verificacoes.verificarCaracteres(novaSenha.Text, 16, 5))
                {
                    MessageBox.Show("A senha deve conter entre 5 e 16 caracteres");
                    return;
                }
                if (novaSenha.Text != confNovaSenha.Text)
                {
                    MessageBox.Show("As senhas não são compatíveis!");
                    return;
                }
                if (GeraHash.SHA_256(senhaAtual.Text) != usuario.Senha)
                {
                    MessageBox.Show("Senha atual incorreta!");
                    return;
                }
            }
            bool usuarioAlterado = UsuarioController.Editar(usuario.Id, nomeCadastro.Text, usernameCadastro.Text, (redefinirSenha) ? novaSenha.Text : null);
            if (usuarioAlterado)
            {
                MessageBox.Show("Usuário alterado com sucesso!");
                this.Close();
                return;
            }
            MessageBox.Show("Não foi possível alterar usuário!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Deseja realmente desativar sua conta?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );

            if (result == DialogResult.Yes)
            {
               bool usuarioDesativado = UsuarioController.Desativar(usuario.Id);
               if (usuarioDesativado)
               {
                    MessageBox.Show("Usuário desativado com sucesso! \n O programa será encerrado.");
                    Application.Exit();

                    return;
               }
                MessageBox.Show("Não foi possível desativar o usuário no momento!");

            }
        }
    }
}

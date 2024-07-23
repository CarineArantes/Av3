using SuaCarteiraEmDia.Controller;
using SuaCarteiraEmDia.Model;
using SuaCarteiraEmDia.Utils;
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
    public partial class FrmRecuperarSenha : Form
    {
        PerguntaSeguranca ?perguntaSeguranca;

        int IDUsuario { get; }

        public FrmRecuperarSenha(int idusuario)
        {
            IDUsuario = idusuario;
    
            InitializeComponent();
            ConfigurarCamposDeSenha();
        }

        private void ConfigurarCamposDeSenha()
        {
            novaSenha.UseSystemPasswordChar = true;
            confNovaSenha.UseSystemPasswordChar = true;
        }

        private void FrmRecuperarSenha_Load(object sender, EventArgs e)
        {
            perguntaSeguranca = PerguntaController.BuscarPergunta(IDUsuario);
            pergunta.Text = perguntaSeguranca.Pergunta;

        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            Verificacoes verificacoes = new Verificacoes();

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

            if (perguntaSeguranca?.Resposta == GeraHash.SHA_256(resposta.Text))
            {
                bool alterarSenha = UsuarioController.AlterarSenha(IDUsuario, novaSenha.Text);
                if (alterarSenha) {
                    MessageBox.Show("Senha alterada com sucesso!");
                    this.Hide();
                    return;
                }
                MessageBox.Show("Não foi possível alterar a senha!");
            }
            else {
                MessageBox.Show("Resposta Inválida!");
            }
        }
    }
}

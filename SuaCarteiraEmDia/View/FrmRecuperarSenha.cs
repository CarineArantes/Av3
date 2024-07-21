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
        PerguntaSeguranca perguntaSeguranca;
        int Idusuario;
        public FrmRecuperarSenha(int idusuario)
        {
            Idusuario = idusuario;
            InitializeComponent();
        }

        private void FrmRecuperarSenha_Load(object sender, EventArgs e)
        {
            perguntaSeguranca = PerguntaController.BuscarPergunta(Idusuario);
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

            


        }
    }
}

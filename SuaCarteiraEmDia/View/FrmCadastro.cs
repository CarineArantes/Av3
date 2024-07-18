using SuaCarteiraEmDia.Model;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SuaCarteiraEmDia.View.Login
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Verificacoes verificacoes = new Verificacoes();

            if (usernameCadastro.Text.Trim().Length <= 0 || senhaCadastro.Text.Trim().Length <= 0 || nomeCadastro.Text.Trim().Length <= 0 || confsenhaCadastro.Text.Trim().Length <= 0 || perguntaCadastro.Text.Trim().Length <= 0 || respostaCadastro.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!");
            }
            else
            {
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

                if (!verificacoes.verificarCaracteres(senhaCadastro.Text, 16, 5))
                {
                    MessageBox.Show("A senha deve conter entre 5 e 16 caracteres");
                    return;
                }
                else if (senhaCadastro.Text != confsenhaCadastro.Text)
                {
                    MessageBox.Show("As senhas não são compatíveis!");
                    return;
                }

                if (!verificacoes.verificarCaracteres(perguntaCadastro.Text, 100, 5))
                {
                    MessageBox.Show("A pergunta deve conter entre 5 e 100 caracteres");
                    return;
                }

                if (!verificacoes.verificarCaracteres(respostaCadastro.Text, 20, 2))
                {
                    MessageBox.Show("A resposta deve conter entre 2 e 20 caracteres");
                    return;
                }


            }
        }
    }
}
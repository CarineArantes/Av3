using SuaCarteiraEmDia.Controller;
using SuaCarteiraEmDia.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuaCarteiraEmDia.View.Principal
{
    public partial class FrmPrincipal : Form
    {
        private Usuario usuario;

        public FrmPrincipal(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        enum menu
        {
            UserControlMovimentacao,
            UserControlCategoria,
            UserControlRelatorio
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Open(menu.UserControlMovimentacao);
        }

        private void btn_movimetacao_Click(object sender, EventArgs e)
        {
            Open(menu.UserControlMovimentacao);
        }

        private void btn_categoria_Click(object sender, EventArgs e)
        {
            Open(menu.UserControlCategoria);
        }

        private void btn_relatorio_Click(object sender, EventArgs e)
        {
            Open(menu.UserControlRelatorio);
        }


        private void Open(menu menu)
        {

            if (panelConteudo.Controls.Count > 0)
            {

                if (menu == menu.UserControlMovimentacao && !(panelConteudo.Controls[0] is UserControlMovimentacao))
                {
                    panelConteudo.Controls.Clear();
                    panelConteudo.Controls.Add(new UserControlMovimentacao(usuario.Id) { Dock = DockStyle.Fill });
                }
                else if (menu == menu.UserControlCategoria && !(panelConteudo.Controls[0] is UserControlCategoria))
                {
                    panelConteudo.Controls.Clear();

                    panelConteudo.Controls.Add(new UserControlCategoria(usuario.Id) { Dock = DockStyle.Fill });
                }
                else if (menu == menu.UserControlRelatorio && !(panelConteudo.Controls[0] is UserControlRelatorio))
                {
                    panelConteudo.Controls.Clear();

                    panelConteudo.Controls.Add(new UserControlRelatorio(usuario.Id) { Dock = DockStyle.Fill });
                }
            }
            else
            {
                switch (menu)
                {
                    case menu.UserControlMovimentacao:
                        panelConteudo.Controls.Add(new UserControlMovimentacao(usuario.Id) { Dock = DockStyle.Fill }); break;
                    case menu.UserControlCategoria:
                        panelConteudo.Controls.Add(new UserControlCategoria(usuario.Id) { Dock = DockStyle.Fill }); break;
                    case menu.UserControlRelatorio:
                        panelConteudo.Controls.Add(new UserControlRelatorio(usuario.Id) { Dock = DockStyle.Fill }); break;

                }
            }

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Deseja realmete sair?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );

            if (result == DialogResult.Yes)
            {
               Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Usuario usuarioPerfil = UsuarioController.BuscarUsuario(usuario.Id, false);
            FrmEditarCadastro editarCadastro = new FrmEditarCadastro(usuarioPerfil);
            editarCadastro.ShowDialog();
        }
    }
}

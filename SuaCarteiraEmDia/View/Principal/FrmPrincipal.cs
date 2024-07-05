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

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        enum menu
        {
            UserControlMovimentacao,
            UserControlCategoria,
            UserControlRelatorio
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
                int radius = 10; // Define o raio dos cantos arredondados

                path.AddArc(rect.X, rect.Y, 2 * radius, 2 * radius, 180, 90); // Canto superior esquerdo
                path.AddArc(rect.X + rect.Width - 2 * radius, rect.Y, 2 * radius, 2 * radius, 270, 90); // Canto superior direito
                path.AddArc(rect.X + rect.Width - 2 * radius, rect.Y + rect.Height - 2 * radius, 2 * radius, 2 * radius, 0, 90); // Canto inferior direito
                path.AddArc(rect.X, rect.Y + rect.Height - 2 * radius, 2 * radius, 2 * radius, 90, 90); // Canto inferior esquerdo

                path.CloseFigure();

                this.Region = new Region(path);
            }
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
                    panelConteudo.Controls.Add(new UserControlMovimentacao() { Dock = DockStyle.Fill });
                }
                else if (menu == menu.UserControlCategoria && !(panelConteudo.Controls[0] is UserControlCategoria))
                {
                    panelConteudo.Controls.Clear();

                    panelConteudo.Controls.Add(new UserControlCategoria() { Dock = DockStyle.Fill });
                }
                else if (menu == menu.UserControlRelatorio && !(panelConteudo.Controls[0] is UserControlRelatorio))
                {
                    panelConteudo.Controls.Clear();

                    panelConteudo.Controls.Add(new UserControlRelatorio() { Dock = DockStyle.Fill });
                }
            }
            else
            {
                switch (menu)
                {
                    case menu.UserControlMovimentacao:
                        panelConteudo.Controls.Add(new UserControlMovimentacao() { Dock = DockStyle.Fill }); break;
                    case menu.UserControlCategoria:
                        panelConteudo.Controls.Add(new UserControlCategoria() { Dock = DockStyle.Fill }); break;
                    case menu.UserControlRelatorio:
                        panelConteudo.Controls.Add(new UserControlRelatorio() { Dock = DockStyle.Fill }); break;

                }
            }

        }

    }
}

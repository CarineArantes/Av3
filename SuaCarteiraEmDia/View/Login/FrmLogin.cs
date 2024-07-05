using Microsoft.EntityFrameworkCore;
using SuaCarteiraEmDia.Data;
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
    }
}

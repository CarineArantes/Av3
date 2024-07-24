using SuaCarteiraEmDia.Controller;
using SuaCarteiraEmDia.Model;
using SuaCarteiraEmDia.View.Catagoria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuaCarteiraEmDia.View.Principal
{


    public partial class UserControlCategoria : UserControl
    {
        List<Categoria> listCategorias;
        int id;




        public UserControlCategoria(int? idUser)
        {
            id = (int)idUser;
            InitializeComponent();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControlCategoria_Load(object sender, EventArgs e)
        {
            listCategorias = CategoriaController.listarCategorias("Ativos", id);

            viewCatagorias.DataSource = listCategorias;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim().Equals(""))
            {
                MessageBox.Show("Selecione uma opção  para filtrar as categorias");
                return;
            }



            PopularGrid(comboBox1.Text);
        }

        public void PopularGrid(string ativos)
        {
            listCategorias = CategoriaController.listarCategorias(ativos, id);

            viewCatagorias.DataSource = listCategorias;

            for (int i = 0; i < listCategorias.Count; i++)
            {

                Color color = ColorTranslator.FromHtml(listCategorias[i].Cor);
                viewCatagorias.Rows[i].Cells[2].Style.BackColor = color;
                viewCatagorias.Rows[i].Cells[2].Style.ForeColor = color;

            }

        }



        private void novaToolStripButton_Click(object sender, EventArgs e)
        {
            new FormCategoria(id, this).Show();
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            if (viewCatagorias.SelectedRows.Count > 0)
            {

                Categoria selecionado = (Categoria)viewCatagorias.SelectedRows[0].DataBoundItem;
                FrmEditarCategoria frm = new FrmEditarCategoria(selecionado.Id, id, this);
                frm.ShowDialog();
               


            }
        }

        private void recortarToolStripButton_Click(object sender, EventArgs e)
        {
            if (viewCatagorias.SelectedRows.Count > 0)
            {
                Categoria selecionado = (Categoria)viewCatagorias.SelectedRows[0].DataBoundItem;

                DialogResult resposta = MessageBox.Show(
                    $"Deseja realmente excluir a categoria selecionada: '{selecionado.Nome}' ?",
                    "",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (resposta == DialogResult.Yes)
                {
                    CategoriaController.Excluir(new Categoria { Id = selecionado.Id, UsuarioID = selecionado.UsuarioID });
                    PopularGrid("Ativos");
                }
            }
        }

        private void viewCatagorias_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }

        private void viewCatagorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

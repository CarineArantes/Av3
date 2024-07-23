using SuaCarteiraEmDia.Controller;
using SuaCarteiraEmDia.Model;
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

namespace SuaCarteiraEmDia.View.Catagoria
{
    
    public partial class FormCategoria : Form
    {
        int id;
        string cor = "";

        public FormCategoria(int ?iduser)
        {
            id = (int)iduser;
           
            InitializeComponent();
        }

        public string ColorToHex(Color color)
        {
            return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();




            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog1.Color;
                string hexColor = ColorToHex(selectedColor);
                MessageBox.Show($"A cor selecionada é {hexColor}");

                Color color = ColorTranslator.FromHtml(hexColor);

             
                txtCor.BackColor = color; 
                txtCorHexadecimal.Text = hexColor.ToString();
                cor = hexColor.ToString();
                
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtNomCategoria.Text.Trim()=="")
            {
                MessageBox.Show("Digite um nome para a categoria", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtCorHexadecimal.Text.Trim() == "")
            {
                MessageBox.Show("Selecione uma cor para a categoria", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            try
            {



                CategoriaController.CriarCategoria(txtNomCategoria.Text, cor, id);


                MessageBox.Show("Categoria cadastrada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            this.Close();
        }
    }
}

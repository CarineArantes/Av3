using SuaCarteiraEmDia.Controller;
using SuaCarteiraEmDia.Model;
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
        string cor = "";
        public FormCategoria()
        {
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

                // Alterar a cor do CheckBox
                textBox2.BackColor = color;  // Define a cor de fundo
                textBox3.Text = hexColor.ToString();
                cor = hexColor.ToString();
                // checkBox1.ForeColor = color;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            Usuario usuario = new Usuario
            {
                Nome = "root",
                UserName = "root",
                Senha = "admin",
                DataCriacao = DateTime.Now,
                DataAlteracao = DateTime.Now,
                Ativo = true
            };

            UsuarioController.Salvar(usuario);

            Categoria categoria = new Categoria
            {
                Nome = textBox1.Text,
                Cor = cor,
                UsuarioID = 1

            };

            CategoriaController.CriarCategoria(categoria);


        }
    }
}

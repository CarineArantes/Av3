using Microsoft.Data.SqlClient;
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

namespace SuaCarteiraEmDia.View.Principal
{



    public partial class UserControlRelatorio : UserControl
    {



        public UserControlRelatorio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControlRelatorio_Load(object sender, EventArgs e)
        {
            checkedListBox1.Enabled = false;
            List<Categoria> categorias = CategoriaController.listarCategorias();

            checkedListBox1.Items.Clear();

            // Iterar sobre a lista de categorias
            foreach (var categoria in categorias)
            {
                // Adicionar o nome da categoria ao CheckedListBox
                checkedListBox1.Items.Add(categoria.Nome);

                // Associar o ID da categoria como o valor do item no CheckedListBox
                int index = checkedListBox1.Items.Count - 1; // índice do item recém-adicionado
                checkedListBox1.Items[index] = new KeyValuePair<int, string>(categoria.Id, categoria.Nome);

            }

    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selecioandos = "";

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                // Verificar se o item no índice i está marcado
                if (checkedListBox1.GetItemChecked(i))
                {
                    selecioandos += checkedListBox1.Items[i].ToString() + ",";
                    // Mostrar o nome do item marcado usando ToString() do item específico

                }
            }

            dataGridView1.Columns.Add("Valor", "Valor");
            dataGridView1.Columns.Add("Tipo", "Tipo");
            dataGridView1.Columns.Add("Descricao", "Descrição");
            dataGridView1.Columns.Add("DataMovimentacao", "Data da Movimentação");
            dataGridView1.Columns.Add("NomeCategoria", "Categoria");
            List<RelatorioMovimentacao> rel = new List<RelatorioMovimentacao>();


      

         
            // Converter os números para inteiros
          
            rel = GetRelatorios();

            string numerosString = "2,1,3";

            // Separar os números da string
            string[] numeros = numerosString.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> numerosInt = numeros.Select(n => int.Parse(n.Trim())).ToList();


            List<RelatorioMovimentacao> categoriasFiltradas = rel.Where(r => numerosInt.Contains(r.IDCategoria)).ToList();



            dataGridView1.Rows.Clear();
            foreach (RelatorioMovimentacao x in categoriasFiltradas)
            {
               
                          dataGridView1.Rows.Add(
                x.Valor,
                x.Tipo,
                x.Descricao,
                x.DataMovimentacao,
                x.Categoria
            );

            }

            MessageBox.Show(selecioandos);



        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                checkedListBox1.Enabled = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                checkedListBox1.Enabled = false;
            }
        }

        private List<RelatorioMovimentacao> GetRelatorios()
        {
            string connectionString = "Data Source=LABBPC03\\SQLSERVER2014ECE; Initial Catalog=DBSuaCarteiraEmDia; Integrated Security=SSPI; Trust Server Certificate=True";

            // Comando SQL a ser executado
            string sqlQuery = "SELECT m.Valor, m.Tipo, m.Descricao, m.DataMovimentacao, " +
             "c.Nome, c.id FROM Movimentacoes AS m INNER JOIN Categorias AS c ON c.Id = m.CategoriaID AND c.UsuarioID = c.UsuarioID INNER JOIN Usuarios AS u ON u.Id = m.UsuarioID WHERE u.Id = 1";


            List<RelatorioMovimentacao> listRel = new List<RelatorioMovimentacao>();
            // Criar uma conexão SQL
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Criar um comando SQL
                SqlCommand command = new SqlCommand(sqlQuery, connection);

               
                    // Abrir a conexão com o banco de dados
                    connection.Open();

                    // Executar o comando e obter um leitor de dados
                    SqlDataReader reader = command.ExecuteReader();

                    // Ler os dados retornados pela consulta
                    while (reader.Read())
                    {
                        decimal valor = (decimal)reader["Valor"];
                        string tipo = (string)reader["Tipo"];
                        string  descricao= (string)reader["Descricao"];
                        DateTime dataMovimentacao = (DateTime) reader["DataMovimentacao"];
                    string nomeCategoria = (string)reader["Nome"];
                    int idCategoria = (int)reader["id"];

                    listRel.Add(new RelatorioMovimentacao { Valor = valor, Tipo = tipo, Descricao = descricao, DataMovimentacao = dataMovimentacao, Categoria = nomeCategoria, IDCategoria = idCategoria});
                    }

                    
                    // Fechar o leitor de dados
                    reader.Close();

                return listRel;


            }
        }
    }
}

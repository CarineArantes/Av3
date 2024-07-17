namespace SuaCarteiraEmDia.View.Principal
{
    partial class UserControlRelatorio
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            checkedListBox1 = new CheckedListBox();
            btnBuscar = new Button();
            dataGridView1 = new DataGridView();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            filtrarCategorias = new GroupBox();
            tiposMovimentacoes = new GroupBox();
            radioEntrada = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            filtrarCategorias.SuspendLayout();
            tiposMovimentacoes.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 29);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Relatorio";
            label1.Click += label1_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(584, 159);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 94);
            checkedListBox1.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(415, 298);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(544, 160);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(6, 35);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(126, 19);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Todas as categorias";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(18, 60);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(114, 19);
            radioButton2.TabIndex = 6;
            radioButton2.Text = "Filtrar Categorias";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(3, 296);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 8;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "";
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(209, 296);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 9;
            // 
            // filtrarCategorias
            // 
            filtrarCategorias.Controls.Add(radioButton1);
            filtrarCategorias.Controls.Add(radioButton2);
            filtrarCategorias.Location = new Point(569, 15);
            filtrarCategorias.Name = "filtrarCategorias";
            filtrarCategorias.Size = new Size(161, 92);
            filtrarCategorias.TabIndex = 10;
            filtrarCategorias.TabStop = false;
            filtrarCategorias.Text = "Filtrar Cagetorias";
            // 
            // tiposMovimentacoes
            // 
            tiposMovimentacoes.Controls.Add(radioEntrada);
            tiposMovimentacoes.Controls.Add(radioButton4);
            tiposMovimentacoes.Controls.Add(radioButton3);
            tiposMovimentacoes.Location = new Point(296, 29);
            tiposMovimentacoes.Name = "tiposMovimentacoes";
            tiposMovimentacoes.Size = new Size(267, 54);
            tiposMovimentacoes.TabIndex = 11;
            tiposMovimentacoes.TabStop = false;
            tiposMovimentacoes.Text = "Filtrar Tipo Movimentações";
            tiposMovimentacoes.Enter += groupBox2_Enter;
            // 
            // radioEntrada
            // 
            radioEntrada.AutoSize = true;
            radioEntrada.Location = new Point(164, 22);
            radioEntrada.Name = "radioEntrada";
            radioEntrada.Size = new Size(31, 19);
            radioEntrada.TabIndex = 2;
            radioEntrada.Text = "E";
            radioEntrada.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Checked = true;
            radioButton4.Location = new Point(29, 24);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(56, 19);
            radioButton4.TabIndex = 1;
            radioButton4.TabStop = true;
            radioButton4.Text = "Todos";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(105, 22);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(31, 19);
            radioButton3.TabIndex = 0;
            radioButton3.Text = "S";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 68);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 12;
            label2.Text = "Total filtrado";
            label2.Click += label2_Click;
            // 
            // UserControlRelatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(tiposMovimentacoes);
            Controls.Add(filtrarCategorias);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(btnBuscar);
            Controls.Add(checkedListBox1);
            Controls.Add(label1);
            Name = "UserControlRelatorio";
            Size = new Size(757, 383);
            Load += UserControlRelatorio_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            filtrarCategorias.ResumeLayout(false);
            filtrarCategorias.PerformLayout();
            tiposMovimentacoes.ResumeLayout(false);
            tiposMovimentacoes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckedListBox checkedListBox1;
        private Button btnBuscar;
        private DataGridView dataGridView1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private GroupBox filtrarCategorias;
        private GroupBox tiposMovimentacoes;
        private RadioButton radioButton3;
        private RadioButton radioEntrada;
        private RadioButton radioButton4;
        private Label label2;
    }
}

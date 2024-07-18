namespace SuaCarteiraEmDia.View.Principal
{
    partial class UserControlCategoria
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlCategoria));
            label1 = new Label();
            bindingSource1 = new BindingSource(components);
            viewCatagorias = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            corDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataCriacaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataAlteracaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ativoDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            button2 = new Button();
            comboBox1 = new ComboBox();
            toolStrip2 = new ToolStrip();
            novaToolStripButton = new ToolStripButton();
            abrirToolStripButton = new ToolStripButton();
            recortarToolStripButton = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewCatagorias).BeginInit();
            toolStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(46, 57);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "Categoria";
            label1.Click += label1_Click_1;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Model.Categoria);
            // 
            // viewCatagorias
            // 
            viewCatagorias.AllowUserToAddRows = false;
            viewCatagorias.AllowUserToDeleteRows = false;
            viewCatagorias.AutoGenerateColumns = false;
            viewCatagorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewCatagorias.Columns.AddRange(new DataGridViewColumn[] { Id, nomeDataGridViewTextBoxColumn, corDataGridViewTextBoxColumn, dataCriacaoDataGridViewTextBoxColumn, dataAlteracaoDataGridViewTextBoxColumn, ativoDataGridViewCheckBoxColumn });
            viewCatagorias.DataSource = bindingSource1;
            viewCatagorias.Location = new Point(14, 142);
            viewCatagorias.Name = "viewCatagorias";
            viewCatagorias.ReadOnly = true;
            viewCatagorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            viewCatagorias.Size = new Size(728, 99);
            viewCatagorias.TabIndex = 10;
            viewCatagorias.CellFormatting += viewCatagorias_CellFormatting;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // corDataGridViewTextBoxColumn
            // 
            corDataGridViewTextBoxColumn.DataPropertyName = "Cor";
            corDataGridViewTextBoxColumn.HeaderText = "Cor";
            corDataGridViewTextBoxColumn.Name = "corDataGridViewTextBoxColumn";
            corDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataCriacaoDataGridViewTextBoxColumn
            // 
            dataCriacaoDataGridViewTextBoxColumn.DataPropertyName = "DataCriacao";
            dataCriacaoDataGridViewTextBoxColumn.HeaderText = "DataCriacao";
            dataCriacaoDataGridViewTextBoxColumn.Name = "dataCriacaoDataGridViewTextBoxColumn";
            dataCriacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataAlteracaoDataGridViewTextBoxColumn
            // 
            dataAlteracaoDataGridViewTextBoxColumn.DataPropertyName = "DataAlteracao";
            dataAlteracaoDataGridViewTextBoxColumn.HeaderText = "DataAlteracao";
            dataAlteracaoDataGridViewTextBoxColumn.Name = "dataAlteracaoDataGridViewTextBoxColumn";
            dataAlteracaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ativoDataGridViewCheckBoxColumn
            // 
            ativoDataGridViewCheckBoxColumn.DataPropertyName = "Ativo";
            ativoDataGridViewCheckBoxColumn.HeaderText = "Ativo";
            ativoDataGridViewCheckBoxColumn.Name = "ativoDataGridViewCheckBoxColumn";
            ativoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // button2
            // 
            button2.ForeColor = Color.CornflowerBlue;
            button2.Location = new Point(529, 53);
            button2.Name = "button2";
            button2.Size = new Size(186, 23);
            button2.TabIndex = 11;
            button2.Text = "Filtrar Categoria Ativas";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ativos", "Inativos", "Todos" });
            comboBox1.Location = new Point(281, 49);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 13;
            comboBox1.Tag = "";
            // 
            // toolStrip2
            // 
            toolStrip2.Items.AddRange(new ToolStripItem[] { novaToolStripButton, abrirToolStripButton, recortarToolStripButton });
            toolStrip2.Location = new Point(0, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(757, 25);
            toolStrip2.TabIndex = 14;
            toolStrip2.Text = "toolStrip2";
 
            // 
            // novaToolStripButton
            // 
            novaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            novaToolStripButton.Image = (Image)resources.GetObject("novaToolStripButton.Image");
            novaToolStripButton.ImageTransparentColor = Color.Magenta;
            novaToolStripButton.Name = "novaToolStripButton";
            novaToolStripButton.Size = new Size(23, 22);
            novaToolStripButton.Text = "&Nova";
            novaToolStripButton.Click += novaToolStripButton_Click;
            // 
            // abrirToolStripButton
            // 
            abrirToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            abrirToolStripButton.Image = (Image)resources.GetObject("abrirToolStripButton.Image");
            abrirToolStripButton.ImageTransparentColor = Color.Magenta;
            abrirToolStripButton.Name = "abrirToolStripButton";
            abrirToolStripButton.Size = new Size(23, 22);
            abrirToolStripButton.Text = "&Abrir";
            abrirToolStripButton.Click += abrirToolStripButton_Click;
            // 
            // recortarToolStripButton
            // 
            recortarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            recortarToolStripButton.Image = (Image)resources.GetObject("recortarToolStripButton.Image");
            recortarToolStripButton.ImageTransparentColor = Color.Magenta;
            recortarToolStripButton.Name = "recortarToolStripButton";
            recortarToolStripButton.Size = new Size(23, 22);
            recortarToolStripButton.Text = "R&ecortar";
            recortarToolStripButton.Click += recortarToolStripButton_Click;
            // 
            // UserControlCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(toolStrip2);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(viewCatagorias);
            Controls.Add(label1);
            Name = "UserControlCategoria";
            Size = new Size(757, 383);
            Load += UserControlCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewCatagorias).EndInit();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private BindingSource bindingSource1;
        private DataGridView viewCatagorias;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn corDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataCriacaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataAlteracaoDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn;
        private Button button2;
        private ComboBox comboBox1;
        private ToolStrip toolStrip2;
        private ToolStripButton novaToolStripButton;
        private ToolStripButton abrirToolStripButton;
        private ToolStripButton recortarToolStripButton;
    }
}

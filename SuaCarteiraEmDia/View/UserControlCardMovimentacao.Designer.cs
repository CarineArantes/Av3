namespace SuaCarteiraEmDia.View.Principal
{
    partial class UserControlCardMovimentacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlCardMovimentacao));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBoxValor = new TextBox();
            textBoxCategoria = new TextBox();
            panel1 = new Panel();
            pictureBox = new PictureBox();
            richTextBoxDescricao = new RichTextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.1194038F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 53.8461533F));
            tableLayoutPanel1.Size = new Size(936, 40);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.WhiteSmoke;
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.0512829F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.9487152F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 216F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 281F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            tableLayoutPanel2.Controls.Add(textBoxValor, 1, 0);
            tableLayoutPanel2.Controls.Add(textBoxCategoria, 2, 0);
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(richTextBoxDescricao, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(936, 40);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // textBoxValor
            // 
            textBoxValor.BackColor = Color.WhiteSmoke;
            textBoxValor.BorderStyle = BorderStyle.None;
            textBoxValor.Dock = DockStyle.Fill;
            textBoxValor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxValor.ForeColor = Color.Black;
            textBoxValor.Location = new Point(81, 10);
            textBoxValor.Margin = new Padding(10);
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(233, 18);
            textBoxValor.TabIndex = 1;
            textBoxValor.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxCategoria
            // 
            textBoxCategoria.BackColor = Color.WhiteSmoke;
            textBoxCategoria.BorderStyle = BorderStyle.None;
            textBoxCategoria.Dock = DockStyle.Fill;
            textBoxCategoria.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxCategoria.ForeColor = Color.Black;
            textBoxCategoria.Location = new Point(334, 10);
            textBoxCategoria.Margin = new Padding(10);
            textBoxCategoria.Name = "textBoxCategoria";
            textBoxCategoria.Size = new Size(196, 18);
            textBoxCategoria.TabIndex = 2;
            textBoxCategoria.Text = "Oii";
            textBoxCategoria.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(71, 40);
            panel1.TabIndex = 3;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.Black;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(71, 40);
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox.TabIndex = 4;
            pictureBox.TabStop = false;
            // 
            // richTextBoxDescricao
            // 
            richTextBoxDescricao.BackColor = Color.WhiteSmoke;
            richTextBoxDescricao.BorderStyle = BorderStyle.None;
            richTextBoxDescricao.Dock = DockStyle.Fill;
            richTextBoxDescricao.Location = new Point(543, 3);
            richTextBoxDescricao.Name = "richTextBoxDescricao";
            richTextBoxDescricao.Size = new Size(275, 34);
            richTextBoxDescricao.TabIndex = 4;
            richTextBoxDescricao.Text = "";
            // 
            // UserControlCardMovimentacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(tableLayoutPanel1);
            Name = "UserControlCardMovimentacao";
            Size = new Size(936, 40);
            Load += UserControlCardMovimentacao_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBoxValor;
        private TextBox textBoxCategoria;
        private Panel panel1;
        private PictureBox pictureBox;
        private RichTextBox richTextBoxDescricao;
    }
}

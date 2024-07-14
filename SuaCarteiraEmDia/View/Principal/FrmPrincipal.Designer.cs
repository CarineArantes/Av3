namespace SuaCarteiraEmDia.View.Principal
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            tableLayoutPanel1 = new TableLayoutPanel();
            panelConteudo = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panelMenu = new Panel();
            btn_sair = new Button();
            btn_relatorio = new Button();
            btn_categoria = new Button();
            btn_movimetacao = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.CornflowerBlue;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.625F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.375F));
            tableLayoutPanel1.Controls.Add(panelConteudo, 1, 1);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panelMenu, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 433F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(849, 468);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelConteudo
            // 
            panelConteudo.BackColor = Color.White;
            panelConteudo.Dock = DockStyle.Fill;
            panelConteudo.Location = new Point(124, 35);
            panelConteudo.Margin = new Padding(0);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Size = new Size(725, 433);
            panelConteudo.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(124, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(725, 35);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(651, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(74, 35);
            panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.CornflowerBlue;
            panelMenu.Controls.Add(btn_sair);
            panelMenu.Controls.Add(btn_relatorio);
            panelMenu.Controls.Add(btn_categoria);
            panelMenu.Controls.Add(btn_movimetacao);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(0, 35);
            panelMenu.Margin = new Padding(0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(124, 419);
            panelMenu.TabIndex = 2;
            // 
            // btn_sair
            // 
            btn_sair.BackColor = Color.CornflowerBlue;
            btn_sair.Cursor = Cursors.Hand;
            btn_sair.FlatAppearance.BorderSize = 0;
            btn_sair.FlatStyle = FlatStyle.Flat;
            btn_sair.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_sair.ForeColor = Color.White;
            btn_sair.Location = new Point(0, 376);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(124, 43);
            btn_sair.TabIndex = 8;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = false;
            btn_sair.Click += btn_sair_Click;
            // 
            // btn_relatorio
            // 
            btn_relatorio.BackColor = Color.CornflowerBlue;
            btn_relatorio.Cursor = Cursors.Hand;
            btn_relatorio.FlatAppearance.BorderSize = 0;
            btn_relatorio.FlatStyle = FlatStyle.Flat;
            btn_relatorio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_relatorio.ForeColor = Color.White;
            btn_relatorio.Location = new Point(0, 250);
            btn_relatorio.Name = "btn_relatorio";
            btn_relatorio.Size = new Size(124, 41);
            btn_relatorio.TabIndex = 7;
            btn_relatorio.Text = "Relatórios";
            btn_relatorio.UseVisualStyleBackColor = false;
            btn_relatorio.Click += btn_relatorio_Click;
            // 
            // btn_categoria
            // 
            btn_categoria.BackColor = Color.CornflowerBlue;
            btn_categoria.Cursor = Cursors.Hand;
            btn_categoria.FlatAppearance.BorderSize = 0;
            btn_categoria.FlatStyle = FlatStyle.Flat;
            btn_categoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_categoria.ForeColor = Color.White;
            btn_categoria.Location = new Point(0, 193);
            btn_categoria.Name = "btn_categoria";
            btn_categoria.Size = new Size(124, 41);
            btn_categoria.TabIndex = 6;
            btn_categoria.Text = "Categorias";
            btn_categoria.UseVisualStyleBackColor = false;
            btn_categoria.Click += btn_categoria_Click;
            // 
            // btn_movimetacao
            // 
            btn_movimetacao.BackColor = Color.CornflowerBlue;
            btn_movimetacao.Cursor = Cursors.Hand;
            btn_movimetacao.FlatAppearance.BorderSize = 0;
            btn_movimetacao.FlatStyle = FlatStyle.Flat;
            btn_movimetacao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_movimetacao.ForeColor = Color.White;
            btn_movimetacao.Location = new Point(0, 133);
            btn_movimetacao.Name = "btn_movimetacao";
            btn_movimetacao.Size = new Size(124, 41);
            btn_movimetacao.TabIndex = 5;
            btn_movimetacao.Text = "Movimentações";
            btn_movimetacao.UseVisualStyleBackColor = false;
            btn_movimetacao.Click += btn_movimetacao_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(849, 468);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sua Carteira Em Dia ";
            Load += FrmPrincipal_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelConteudo;
        private Panel panel2;
        private Panel panelMenu;
        private Button btn_sair;
        private Button btn_relatorio;
        private Button btn_categoria;
        private Button btn_movimetacao;
        private Panel panel3;
        private PictureBox pictureBox1;
    }
}
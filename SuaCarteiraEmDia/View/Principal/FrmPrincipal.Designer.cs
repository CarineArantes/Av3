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
            tableLayoutPanel1 = new TableLayoutPanel();
            panelConteudo = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panelMenu = new Panel();
            btn_sair = new Button();
            btn_relatorio = new Button();
            btn_categoria = new Button();
            btn_movimetacao = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.DeepSkyBlue;
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 413F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(849, 468);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelConteudo
            // 
            panelConteudo.BackColor = Color.White;
            panelConteudo.Dock = DockStyle.Fill;
            panelConteudo.Location = new Point(124, 55);
            panelConteudo.Margin = new Padding(0);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Size = new Size(725, 413);
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
            panel2.Size = new Size(725, 55);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(652, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(73, 55);
            panel3.TabIndex = 0;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.DeepSkyBlue;
            panelMenu.Controls.Add(btn_sair);
            panelMenu.Controls.Add(btn_relatorio);
            panelMenu.Controls.Add(btn_categoria);
            panelMenu.Controls.Add(btn_movimetacao);
            panelMenu.Dock = DockStyle.Fill;
            panelMenu.Location = new Point(0, 55);
            panelMenu.Margin = new Padding(0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(124, 413);
            panelMenu.TabIndex = 2;
            // 
            // btn_sair
            // 
            btn_sair.BackColor = Color.DeepSkyBlue;
            btn_sair.FlatAppearance.BorderSize = 0;
            btn_sair.FlatStyle = FlatStyle.Flat;
            btn_sair.Location = new Point(-25, 369);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(159, 44);
            btn_sair.TabIndex = 8;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = false;
            // 
            // btn_relatorio
            // 
            btn_relatorio.BackColor = Color.DeepSkyBlue;
            btn_relatorio.FlatAppearance.BorderSize = 0;
            btn_relatorio.FlatStyle = FlatStyle.Flat;
            btn_relatorio.Location = new Point(-25, 195);
            btn_relatorio.Name = "btn_relatorio";
            btn_relatorio.Size = new Size(159, 41);
            btn_relatorio.TabIndex = 7;
            btn_relatorio.Text = "Relatórios";
            btn_relatorio.UseVisualStyleBackColor = false;
            btn_relatorio.Click += btn_relatorio_Click;
            // 
            // btn_categoria
            // 
            btn_categoria.BackColor = Color.DeepSkyBlue;
            btn_categoria.FlatAppearance.BorderSize = 0;
            btn_categoria.FlatStyle = FlatStyle.Flat;
            btn_categoria.Location = new Point(-25, 138);
            btn_categoria.Name = "btn_categoria";
            btn_categoria.Size = new Size(159, 41);
            btn_categoria.TabIndex = 6;
            btn_categoria.Text = "Categoria";
            btn_categoria.UseVisualStyleBackColor = false;
            btn_categoria.Click += btn_categoria_Click;
            // 
            // btn_movimetacao
            // 
            btn_movimetacao.BackColor = Color.DeepSkyBlue;
            btn_movimetacao.FlatAppearance.BorderSize = 0;
            btn_movimetacao.FlatStyle = FlatStyle.Flat;
            btn_movimetacao.Location = new Point(-25, 81);
            btn_movimetacao.Name = "btn_movimetacao";
            btn_movimetacao.Size = new Size(159, 41);
            btn_movimetacao.TabIndex = 5;
            btn_movimetacao.Text = "Movimentação";
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sua Carteira Em Dia ";
            Load += FrmPrincipal_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
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
    }
}
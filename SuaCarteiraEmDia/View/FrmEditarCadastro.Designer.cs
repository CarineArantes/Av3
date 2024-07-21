namespace SuaCarteiraEmDia.View
{
    partial class FrmEditarCadastro
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
            panel2 = new Panel();
            btnRedefinirSenha = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            novaSenha = new TextBox();
            label7 = new Label();
            confNovaSenha = new TextBox();
            label3 = new Label();
            senhaAtual = new TextBox();
            button2 = new Button();
            nomeCadastro = new TextBox();
            usernameCadastro = new TextBox();
            label4 = new Label();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.CornflowerBlue;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.994004F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.01199F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.994004F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.8863049F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 88.11369F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.Size = new Size(919, 463);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(btnRedefinirSenha);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(nomeCadastro);
            panel2.Controls.Add(usernameCadastro);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(94, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(729, 358);
            panel2.TabIndex = 0;
            // 
            // btnRedefinirSenha
            // 
            btnRedefinirSenha.BackColor = Color.FromArgb(224, 224, 224);
            btnRedefinirSenha.Cursor = Cursors.Hand;
            btnRedefinirSenha.FlatAppearance.BorderColor = Color.CornflowerBlue;
            btnRedefinirSenha.FlatStyle = FlatStyle.System;
            btnRedefinirSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRedefinirSenha.ForeColor = SystemColors.ControlLightLight;
            btnRedefinirSenha.Location = new Point(384, 293);
            btnRedefinirSenha.Margin = new Padding(0);
            btnRedefinirSenha.Name = "btnRedefinirSenha";
            btnRedefinirSenha.Size = new Size(293, 30);
            btnRedefinirSenha.TabIndex = 13;
            btnRedefinirSenha.Text = "Redefinir Senha";
            btnRedefinirSenha.UseVisualStyleBackColor = false;
            btnRedefinirSenha.Click += btnRedefinirSenha_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.BackgroundImageLayout = ImageLayout.Center;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(novaSenha);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(confNovaSenha);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(senhaAtual);
            groupBox1.Enabled = false;
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(369, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 264);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(15, 104);
            label1.Name = "label1";
            label1.Size = new Size(92, 21);
            label1.TabIndex = 21;
            label1.Text = "Nova senha";
            // 
            // novaSenha
            // 
            novaSenha.BackColor = Color.WhiteSmoke;
            novaSenha.BorderStyle = BorderStyle.FixedSingle;
            novaSenha.Font = new Font("Segoe UI", 12F);
            novaSenha.Location = new Point(15, 133);
            novaSenha.Margin = new Padding(0);
            novaSenha.Name = "novaSenha";
            novaSenha.Size = new Size(293, 29);
            novaSenha.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(15, 174);
            label7.Name = "label7";
            label7.Size = new Size(158, 21);
            label7.TabIndex = 19;
            label7.Text = "Confirme nova senha";
            // 
            // confNovaSenha
            // 
            confNovaSenha.BackColor = Color.WhiteSmoke;
            confNovaSenha.BorderStyle = BorderStyle.FixedSingle;
            confNovaSenha.Font = new Font("Segoe UI", 12F);
            confNovaSenha.Location = new Point(15, 203);
            confNovaSenha.Margin = new Padding(0);
            confNovaSenha.Name = "confNovaSenha";
            confNovaSenha.Size = new Size(293, 29);
            confNovaSenha.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(15, 30);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 18;
            label3.Text = "Senha atual";
            // 
            // senhaAtual
            // 
            senhaAtual.BackColor = Color.WhiteSmoke;
            senhaAtual.BorderStyle = BorderStyle.FixedSingle;
            senhaAtual.Font = new Font("Segoe UI", 12F);
            senhaAtual.Location = new Point(15, 59);
            senhaAtual.Margin = new Padding(0);
            senhaAtual.Name = "senhaAtual";
            senhaAtual.Size = new Size(293, 29);
            senhaAtual.TabIndex = 16;
            senhaAtual.Text = "***********************************************************************";
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(39, 303);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(293, 36);
            button2.TabIndex = 11;
            button2.Text = "Desativar Conta";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // nomeCadastro
            // 
            nomeCadastro.BackColor = Color.WhiteSmoke;
            nomeCadastro.BorderStyle = BorderStyle.FixedSingle;
            nomeCadastro.Font = new Font("Segoe UI", 12F);
            nomeCadastro.ForeColor = Color.Black;
            nomeCadastro.Location = new Point(39, 72);
            nomeCadastro.Margin = new Padding(0);
            nomeCadastro.Name = "nomeCadastro";
            nomeCadastro.Size = new Size(293, 29);
            nomeCadastro.TabIndex = 1;
            // 
            // usernameCadastro
            // 
            usernameCadastro.BackColor = Color.WhiteSmoke;
            usernameCadastro.BorderStyle = BorderStyle.FixedSingle;
            usernameCadastro.Font = new Font("Segoe UI", 12F);
            usernameCadastro.ForeColor = Color.Black;
            usernameCadastro.Location = new Point(39, 139);
            usernameCadastro.Margin = new Padding(0);
            usernameCadastro.Name = "usernameCadastro";
            usernameCadastro.Size = new Size(293, 29);
            usernameCadastro.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(39, 110);
            label4.Name = "label4";
            label4.Size = new Size(81, 21);
            label4.TabIndex = 6;
            label4.Text = "Username";
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.CornflowerBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(39, 189);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(117, 36);
            button1.TabIndex = 10;
            button1.Text = "Salvar Alterações";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FrmEditarCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 463);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmEditarCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Cadastro";
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        internal TextBox nomeCadastro;
        internal TextBox usernameCadastro;
        private Label label4;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox novaSenha;
        private Label label7;
        private TextBox confNovaSenha;
        private Label label3;
        private TextBox senhaAtual;
        private Button btnRedefinirSenha;
    }
}
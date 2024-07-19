namespace SuaCarteiraEmDia.View.Login
{
    partial class FrmCadastro
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
            panel1 = new Panel();
            senha = new TextBox();
            btnLogin = new Button();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            respostaCadastro = new TextBox();
            label8 = new Label();
            perguntaCadastro = new TextBox();
            label6 = new Label();
            label7 = new Label();
            confsenhaCadastro = new TextBox();
            nomeCadastro = new TextBox();
            label5 = new Label();
            label3 = new Label();
            senhaCadastro = new TextBox();
            usernameCadastro = new TextBox();
            label4 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(senha);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(71, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(429, 346);
            panel1.TabIndex = 1;
            // 
            // senha
            // 
            senha.BackColor = Color.WhiteSmoke;
            senha.BorderStyle = BorderStyle.FixedSingle;
            senha.Font = new Font("Segoe UI", 12F);
            senha.Location = new Point(41, 183);
            senha.Margin = new Padding(0);
            senha.Name = "senha";
            senha.Size = new Size(293, 29);
            senha.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.CornflowerBlue;
            btnLogin.FlatAppearance.BorderColor = Color.CornflowerBlue;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 14F);
            btnLogin.ForeColor = SystemColors.ControlLightLight;
            btnLogin.Location = new Point(141, 279);
            btnLogin.Margin = new Padding(0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(144, 35);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Acessar";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(41, 146);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 3;
            label2.Text = "Resposta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(41, 50);
            label1.Name = "label1";
            label1.Size = new Size(72, 21);
            label1.TabIndex = 2;
            label1.Text = "Pergunta";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.CornflowerBlue;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.21102858F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 92.78897F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.8863049F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 88.11369F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.Size = new Size(938, 527);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(confsenhaCadastro);
            panel2.Controls.Add(nomeCadastro);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(senhaCadastro);
            panel2.Controls.Add(usernameCadastro);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(66, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(808, 415);
            panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.BackgroundImageLayout = ImageLayout.Center;
            groupBox1.Controls.Add(respostaCadastro);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(perguntaCadastro);
            groupBox1.Controls.Add(label6);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(424, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 264);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Crie uma pergunta de segurança para recuperar a senha";
            // 
            // respostaCadastro
            // 
            respostaCadastro.BackColor = Color.WhiteSmoke;
            respostaCadastro.BorderStyle = BorderStyle.FixedSingle;
            respostaCadastro.Font = new Font("Segoe UI", 12F);
            respostaCadastro.ForeColor = Color.Black;
            respostaCadastro.Location = new Point(15, 198);
            respostaCadastro.Margin = new Padding(0);
            respostaCadastro.Name = "respostaCadastro";
            respostaCadastro.Size = new Size(293, 29);
            respostaCadastro.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(15, 171);
            label8.Name = "label8";
            label8.Size = new Size(73, 21);
            label8.TabIndex = 20;
            label8.Text = "Resposta";
            // 
            // perguntaCadastro
            // 
            perguntaCadastro.BackColor = Color.WhiteSmoke;
            perguntaCadastro.BorderStyle = BorderStyle.FixedSingle;
            perguntaCadastro.Font = new Font("Segoe UI", 12F);
            perguntaCadastro.ForeColor = Color.Black;
            perguntaCadastro.Location = new Point(15, 104);
            perguntaCadastro.Margin = new Padding(0);
            perguntaCadastro.Name = "perguntaCadastro";
            perguntaCadastro.Size = new Size(293, 29);
            perguntaCadastro.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(15, 77);
            label6.Name = "label6";
            label6.Size = new Size(72, 21);
            label6.TabIndex = 18;
            label6.Text = "Pergunta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(39, 249);
            label7.Name = "label7";
            label7.Size = new Size(132, 21);
            label7.TabIndex = 15;
            label7.Text = "Confirme a senha";
            // 
            // confsenhaCadastro
            // 
            confsenhaCadastro.BackColor = Color.WhiteSmoke;
            confsenhaCadastro.BorderStyle = BorderStyle.FixedSingle;
            confsenhaCadastro.Font = new Font("Segoe UI", 12F);
            confsenhaCadastro.Location = new Point(39, 278);
            confsenhaCadastro.Margin = new Padding(0);
            confsenhaCadastro.Name = "confsenhaCadastro";
            confsenhaCadastro.Size = new Size(293, 29);
            confsenhaCadastro.TabIndex = 4;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(39, 43);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 10;
            label5.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(39, 178);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 9;
            label3.Text = "Senha";
            // 
            // senhaCadastro
            // 
            senhaCadastro.BackColor = Color.WhiteSmoke;
            senhaCadastro.BorderStyle = BorderStyle.FixedSingle;
            senhaCadastro.Font = new Font("Segoe UI", 12F);
            senhaCadastro.Location = new Point(39, 207);
            senhaCadastro.Margin = new Padding(0);
            senhaCadastro.Name = "senhaCadastro";
            senhaCadastro.Size = new Size(293, 29);
            senhaCadastro.TabIndex = 3;
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
            button1.FlatAppearance.BorderColor = Color.CornflowerBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(329, 352);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(144, 35);
            button1.TabIndex = 10;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FrmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 527);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox senha;
        private Button btnLogin;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Button button1;
        internal TextBox nomeCadastro;
        private Label label5;
        private Label label3;
        private TextBox senhaCadastro;
        internal TextBox usernameCadastro;
        private Label label4;
        private Label label7;
        private TextBox confsenhaCadastro;
        private GroupBox groupBox1;
        internal TextBox respostaCadastro;
        private Label label8;
        internal TextBox perguntaCadastro;
        private Label label6;
    }
}
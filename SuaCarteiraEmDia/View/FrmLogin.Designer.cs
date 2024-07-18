namespace SuaCarteiraEmDia.View.Login
{
    partial class FrmLogin
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
            cadastrar = new LinkLabel();
            esqueciSenha = new LinkLabel();
            label3 = new Label();
            senha = new TextBox();
            username = new TextBox();
            label2 = new Label();
            btnLogin = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(cadastrar);
            panel1.Controls.Add(esqueciSenha);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(senha);
            panel1.Controls.Add(username);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(140, 60);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 447);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // cadastrar
            // 
            cadastrar.ActiveLinkColor = Color.CornflowerBlue;
            cadastrar.AutoSize = true;
            cadastrar.Font = new Font("Segoe UI", 12F);
            cadastrar.LinkColor = Color.CornflowerBlue;
            cadastrar.Location = new Point(270, 265);
            cadastrar.Name = "cadastrar";
            cadastrar.Size = new Size(77, 21);
            cadastrar.TabIndex = 7;
            cadastrar.TabStop = true;
            cadastrar.Text = "Cadastrar";
            cadastrar.VisitedLinkColor = Color.CornflowerBlue;
            cadastrar.LinkClicked += cadastrar_LinkClicked;
            // 
            // esqueciSenha
            // 
            esqueciSenha.ActiveLinkColor = Color.CornflowerBlue;
            esqueciSenha.AutoSize = true;
            esqueciSenha.Font = new Font("Segoe UI", 12F);
            esqueciSenha.LinkColor = Color.CornflowerBlue;
            esqueciSenha.Location = new Point(54, 265);
            esqueciSenha.Name = "esqueciSenha";
            esqueciSenha.Size = new Size(119, 21);
            esqueciSenha.TabIndex = 6;
            esqueciSenha.TabStop = true;
            esqueciSenha.Text = "Esqueci a senha";
            esqueciSenha.VisitedLinkColor = Color.CornflowerBlue;
            esqueciSenha.LinkClicked += esqueciSenha_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(54, 193);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 5;
            label3.Text = "Senha";
            // 
            // senha
            // 
            senha.BackColor = Color.WhiteSmoke;
            senha.BorderStyle = BorderStyle.FixedSingle;
            senha.Font = new Font("Segoe UI", 12F);
            senha.Location = new Point(54, 222);
            senha.Margin = new Padding(0);
            senha.Name = "senha";
            senha.Size = new Size(293, 29);
            senha.TabIndex = 4;
            senha.TextChanged += senha_TextChanged;
            // 
            // username
            // 
            username.BackColor = Color.WhiteSmoke;
            username.BorderStyle = BorderStyle.FixedSingle;
            username.Font = new Font("Segoe UI", 12F);
            username.ForeColor = Color.Black;
            username.Location = new Point(54, 136);
            username.Margin = new Padding(0);
            username.Name = "username";
            username.Size = new Size(293, 29);
            username.TabIndex = 3;
            username.TextChanged += username_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(54, 107);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.CornflowerBlue;
            btnLogin.FlatAppearance.BorderColor = Color.CornflowerBlue;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 14F);
            btnLogin.ForeColor = SystemColors.ControlLightLight;
            btnLogin.Location = new Point(54, 375);
            btnLogin.Margin = new Padding(0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(293, 44);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Acessar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(54, 39);
            label1.Name = "label1";
            label1.Size = new Size(73, 32);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(681, 567);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmLogin";
            Padding = new Padding(140, 60, 140, 60);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sua Carteira Em Dia ";
            Load += FrmLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnLogin;
        private Label label2;
        private Label label3;
        private TextBox senha;
        internal TextBox username;
        private LinkLabel cadastrar;
        private LinkLabel esqueciSenha;
    }
}
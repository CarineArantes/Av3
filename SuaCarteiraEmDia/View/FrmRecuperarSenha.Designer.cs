namespace SuaCarteiraEmDia.View.Login
{
    partial class FrmRecuperarSenha
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
            panel1 = new Panel();
            confNovaSenha = new TextBox();
            label4 = new Label();
            novaSenha = new TextBox();
            label3 = new Label();
            resposta = new TextBox();
            btnRecuperar = new Button();
            label2 = new Label();
            pergunta = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.CornflowerBlue;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.958333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.0416641F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.8863049F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 88.11369F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.Size = new Size(571, 531);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(confNovaSenha);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(novaSenha);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(resposta);
            panel1.Controls.Add(btnRecuperar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pergunta);
            panel1.Location = new Point(73, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(429, 418);
            panel1.TabIndex = 0;
            // 
            // confNovaSenha
            // 
            confNovaSenha.BackColor = Color.WhiteSmoke;
            confNovaSenha.BorderStyle = BorderStyle.FixedSingle;
            confNovaSenha.Font = new Font("Segoe UI", 12F);
            confNovaSenha.Location = new Point(41, 301);
            confNovaSenha.Margin = new Padding(0);
            confNovaSenha.Name = "confNovaSenha";
            confNovaSenha.Size = new Size(293, 29);
            confNovaSenha.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(41, 266);
            label4.Name = "label4";
            label4.Size = new Size(132, 21);
            label4.TabIndex = 9;
            label4.Text = "Confirme a senha";
            // 
            // novaSenha
            // 
            novaSenha.BackColor = Color.WhiteSmoke;
            novaSenha.BorderStyle = BorderStyle.FixedSingle;
            novaSenha.Font = new Font("Segoe UI", 12F);
            novaSenha.Location = new Point(41, 223);
            novaSenha.Margin = new Padding(0);
            novaSenha.Name = "novaSenha";
            novaSenha.Size = new Size(293, 29);
            novaSenha.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(41, 186);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 7;
            label3.Text = "Nova senha";
            // 
            // resposta
            // 
            resposta.BackColor = Color.WhiteSmoke;
            resposta.BorderStyle = BorderStyle.FixedSingle;
            resposta.Font = new Font("Segoe UI", 12F);
            resposta.Location = new Point(41, 137);
            resposta.Margin = new Padding(0);
            resposta.Name = "resposta";
            resposta.Size = new Size(293, 29);
            resposta.TabIndex = 1;
            // 
            // btnRecuperar
            // 
            btnRecuperar.BackColor = Color.CornflowerBlue;
            btnRecuperar.Cursor = Cursors.Hand;
            btnRecuperar.FlatAppearance.BorderColor = Color.CornflowerBlue;
            btnRecuperar.FlatStyle = FlatStyle.Flat;
            btnRecuperar.Font = new Font("Segoe UI", 14F);
            btnRecuperar.ForeColor = SystemColors.ControlLightLight;
            btnRecuperar.Location = new Point(132, 359);
            btnRecuperar.Margin = new Padding(0);
            btnRecuperar.Name = "btnRecuperar";
            btnRecuperar.Size = new Size(144, 35);
            btnRecuperar.TabIndex = 4;
            btnRecuperar.Text = "Redefinir";
            btnRecuperar.UseVisualStyleBackColor = false;
            btnRecuperar.Click += btnRecuperar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(41, 100);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 3;
            label2.Text = "Resposta";
            // 
            // pergunta
            // 
            pergunta.AutoSize = true;
            pergunta.Font = new Font("Segoe UI", 12F);
            pergunta.Location = new Point(41, 50);
            pergunta.Name = "pergunta";
            pergunta.Size = new Size(72, 21);
            pergunta.TabIndex = 2;
            pergunta.Text = "Pergunta";
            // 
            // FrmRecuperarSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 531);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmRecuperarSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recuperar senha";
            Load += FrmRecuperarSenha_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label2;
        private Label pergunta;
        private Button btnRecuperar;
        private TextBox resposta;
        private TextBox confNovaSenha;
        private Label label4;
        private TextBox novaSenha;
        private Label label3;
    }
}
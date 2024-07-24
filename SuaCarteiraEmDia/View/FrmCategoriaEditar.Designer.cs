namespace SuaCarteiraEmDia.View.Catagoria
{
    partial class FrmCategoriaEditar
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
            btnAdicionar = new Button();
            txtCorHexadecimal = new TextBox();
            txtCor = new TextBox();
            btnEditar = new Button();
            txtNomCategoria = new TextBox();
            label1 = new Label();
            colorDialog1 = new ColorDialog();
            checkAtivo = new CheckBox();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.ForeColor = Color.CornflowerBlue;
            btnAdicionar.Location = new Point(284, 304);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 12;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += button2_Click;
            // 
            // txtCorHexadecimal
            // 
            txtCorHexadecimal.Enabled = false;
            txtCorHexadecimal.Location = new Point(302, 220);
            txtCorHexadecimal.Name = "txtCorHexadecimal";
            txtCorHexadecimal.Size = new Size(80, 23);
            txtCorHexadecimal.TabIndex = 11;
            // 
            // txtCor
            // 
            txtCor.Enabled = false;
            txtCor.Location = new Point(276, 220);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(20, 23);
            txtCor.TabIndex = 10;
            // 
            // btnEditar
            // 
            btnEditar.ForeColor = Color.CornflowerBlue;
            btnEditar.Location = new Point(513, 194);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Escolher cor";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += button1_Click;
            // 
            // txtNomCategoria
            // 
            txtNomCategoria.Location = new Point(270, 150);
            txtNomCategoria.Name = "txtNomCategoria";
            txtNomCategoria.Size = new Size(172, 23);
            txtNomCategoria.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(270, 123);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 7;
            label1.Text = "Nome";
            // 
            // checkAtivo
            // 
            checkAtivo.AutoSize = true;
            checkAtivo.ForeColor = Color.CornflowerBlue;
            checkAtivo.Location = new Point(534, 123);
            checkAtivo.Name = "checkAtivo";
            checkAtivo.Size = new Size(54, 19);
            checkAtivo.TabIndex = 13;
            checkAtivo.Text = "Ativo";
            checkAtivo.UseVisualStyleBackColor = true;
            // 
            // FrmCategoriaEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkAtivo);
            Controls.Add(btnAdicionar);
            Controls.Add(txtCorHexadecimal);
            Controls.Add(txtCor);
            Controls.Add(btnEditar);
            Controls.Add(txtNomCategoria);
            Controls.Add(label1);
            Name = "FrmCategoriaEditar";
            Text = "FrmCategoriaEditar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdicionar;
        private TextBox txtCorHexadecimal;
        private TextBox txtCor;
        private Button btnEditar;
        private TextBox txtNomCategoria;
        private Label label1;
        private ColorDialog colorDialog1;
        private CheckBox checkAtivo;
    }
}
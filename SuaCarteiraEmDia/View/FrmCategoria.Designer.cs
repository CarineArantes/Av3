namespace SuaCarteiraEmDia.View.Catagoria
{
    partial class FormCategoria
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
            label1 = new Label();
            txtNomCategoria = new TextBox();
            btnEscolher = new Button();
            colorDialog1 = new ColorDialog();
            txtCor = new TextBox();
            txtCorHexadecimal = new TextBox();
            btnAdicionar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(106, 85);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // txtNomCategoria
            // 
            txtNomCategoria.Location = new Point(106, 112);
            txtNomCategoria.Name = "txtNomCategoria";
            txtNomCategoria.Size = new Size(172, 23);
            txtNomCategoria.TabIndex = 2;
            // 
            // btnEscolher
            // 
            btnEscolher.ForeColor = Color.CornflowerBlue;
            btnEscolher.Location = new Point(292, 181);
            btnEscolher.Name = "btnEscolher";
            btnEscolher.Size = new Size(75, 23);
            btnEscolher.TabIndex = 3;
            btnEscolher.Text = "Escolher cor";
            btnEscolher.UseVisualStyleBackColor = true;
            btnEscolher.Click += button1_Click;
            // 
            // txtCor
            // 
            txtCor.Enabled = false;
            txtCor.Location = new Point(112, 182);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(20, 23);
            txtCor.TabIndex = 4;
            // 
            // txtCorHexadecimal
            // 
            txtCorHexadecimal.Enabled = false;
            txtCorHexadecimal.Location = new Point(138, 182);
            txtCorHexadecimal.Name = "txtCorHexadecimal";
            txtCorHexadecimal.Size = new Size(80, 23);
            txtCorHexadecimal.TabIndex = 5;
            // 
            // btnAdicionar
            // 
            btnAdicionar.ForeColor = Color.CornflowerBlue;
            btnAdicionar.Location = new Point(120, 266);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += button2_Click;
            // 
            // FormCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdicionar);
            Controls.Add(txtCorHexadecimal);
            Controls.Add(txtCor);
            Controls.Add(btnEscolher);
            Controls.Add(txtNomCategoria);
            Controls.Add(label1);
            Name = "FormCategoria";
            Text = "FormCategoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtNomCategoria;
        private Button btnEscolher;
        private ColorDialog colorDialog1;
        private TextBox txtCor;
        private TextBox txtCorHexadecimal;
        private Button btnAdicionar;
    }
}
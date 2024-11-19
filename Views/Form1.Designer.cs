namespace Projeto_Agenda_Destruidora_De_Mundos_Do_Alex
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            botao_login = new Button();
            botao_cadastrar = new Button();
            label1 = new Label();
            label2 = new Label();
            txb_senha = new TextBox();
            txb_usuario = new TextBox();
            Fechado = new PictureBox();
            Aberto = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Fechado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Aberto).BeginInit();
            SuspendLayout();
            // 
            // botao_login
            // 
            botao_login.BackColor = Color.DodgerBlue;
            botao_login.Enabled = false;
            botao_login.FlatStyle = FlatStyle.Flat;
            botao_login.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic);
            botao_login.ForeColor = Color.White;
            botao_login.Location = new Point(20, 450);
            botao_login.Name = "botao_login";
            botao_login.Size = new Size(106, 37);
            botao_login.TabIndex = 0;
            botao_login.Text = "Login";
            botao_login.UseVisualStyleBackColor = false;
            botao_login.Click += botao_login_Click;
            // 
            // botao_cadastrar
            // 
            botao_cadastrar.BackColor = Color.DodgerBlue;
            botao_cadastrar.FlatStyle = FlatStyle.Flat;
            botao_cadastrar.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic);
            botao_cadastrar.ForeColor = Color.White;
            botao_cadastrar.Location = new Point(280, 450);
            botao_cadastrar.Name = "botao_cadastrar";
            botao_cadastrar.Size = new Size(106, 37);
            botao_cadastrar.TabIndex = 1;
            botao_cadastrar.Text = "Cadastrar";
            botao_cadastrar.UseVisualStyleBackColor = false;
            botao_cadastrar.Click += botao_cadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(49, 38);
            label1.Name = "label1";
            label1.Size = new Size(54, 16);
            label1.TabIndex = 2;
            label1.Text = "Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.White;
            label2.Location = new Point(49, 141);
            label2.Name = "label2";
            label2.Size = new Size(46, 16);
            label2.TabIndex = 5;
            label2.Text = "Senha";
            // 
            // txb_senha
            // 
            txb_senha.BackColor = Color.DodgerBlue;
            txb_senha.Font = new Font("Arial", 9.75F, FontStyle.Italic);
            txb_senha.ForeColor = Color.White;
            txb_senha.Location = new Point(49, 178);
            txb_senha.Name = "txb_senha";
            txb_senha.PasswordChar = '☢';
            txb_senha.Size = new Size(298, 22);
            txb_senha.TabIndex = 4;
            txb_senha.TextAlign = HorizontalAlignment.Center;
            txb_senha.TextChanged += textBox_senha_TextChanged;
            // 
            // txb_usuario
            // 
            txb_usuario.BackColor = Color.DodgerBlue;
            txb_usuario.Font = new Font("Arial", 9.75F, FontStyle.Italic);
            txb_usuario.ForeColor = Color.White;
            txb_usuario.Location = new Point(49, 80);
            txb_usuario.Name = "txb_usuario";
            txb_usuario.Size = new Size(298, 22);
            txb_usuario.TabIndex = 3;
            txb_usuario.TextAlign = HorizontalAlignment.Center;
            txb_usuario.TextChanged += textBox_usuario_TextChanged;
            // 
            // Fechado
            // 
            Fechado.Image = Properties.Resources.Errado_01;
            Fechado.Location = new Point(100, 220);
            Fechado.Name = "Fechado";
            Fechado.Size = new Size(200, 200);
            Fechado.SizeMode = PictureBoxSizeMode.StretchImage;
            Fechado.TabIndex = 6;
            Fechado.TabStop = false;
            // 
            // Aberto
            // 
            Aberto.Image = Properties.Resources.Certo_01;
            Aberto.Location = new Point(100, 220);
            Aberto.Name = "Aberto";
            Aberto.Size = new Size(200, 200);
            Aberto.SizeMode = PictureBoxSizeMode.StretchImage;
            Aberto.TabIndex = 8;
            Aberto.TabStop = false;
            Aberto.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(400, 500);
            Controls.Add(Aberto);
            Controls.Add(Fechado);
            Controls.Add(label2);
            Controls.Add(txb_senha);
            Controls.Add(txb_usuario);
            Controls.Add(label1);
            Controls.Add(botao_cadastrar);
            Controls.Add(botao_login);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Fechado).EndInit();
            ((System.ComponentModel.ISupportInitialize)Aberto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botao_login;
        private Button botao_cadastrar;
        private Label label1;
        private Label label2;
        private TextBox txb_senha;
        private TextBox txb_usuario;
        private PictureBox Fechado;
        private PictureBox Aberto;
    }
}

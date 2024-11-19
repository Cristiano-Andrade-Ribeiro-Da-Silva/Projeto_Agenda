namespace Projeto_Agenda_Destruidora_De_Mundos_Do_Alex
{
    partial class FrmTestes
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
            btn_guardar = new Button();
            txb_usuario = new TextBox();
            btn_mostrar = new Button();
            txb_senha = new TextBox();
            txb_nome = new TextBox();
            SuspendLayout();
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(111, 257);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(75, 23);
            btn_guardar.TabIndex = 0;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += button1_Click;
            // 
            // txb_usuario
            // 
            txb_usuario.Location = new Point(111, 107);
            txb_usuario.Name = "txb_usuario";
            txb_usuario.Size = new Size(200, 23);
            txb_usuario.TabIndex = 1;
            // 
            // btn_mostrar
            // 
            btn_mostrar.Location = new Point(236, 257);
            btn_mostrar.Name = "btn_mostrar";
            btn_mostrar.Size = new Size(75, 23);
            btn_mostrar.TabIndex = 2;
            btn_mostrar.Text = "Mostrar";
            btn_mostrar.UseVisualStyleBackColor = true;
            btn_mostrar.Click += button2_Click;
            // 
            // txb_senha
            // 
            txb_senha.Location = new Point(111, 157);
            txb_senha.Name = "txb_senha";
            txb_senha.Size = new Size(200, 23);
            txb_senha.TabIndex = 3;
            // 
            // txb_nome
            // 
            txb_nome.Location = new Point(111, 57);
            txb_nome.Name = "txb_nome";
            txb_nome.Size = new Size(200, 23);
            txb_nome.TabIndex = 4;
            // 
            // FrmTestes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(txb_nome);
            Controls.Add(txb_senha);
            Controls.Add(btn_mostrar);
            Controls.Add(txb_usuario);
            Controls.Add(btn_guardar);
            Name = "FrmTestes";
            Text = "FrmTestes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_guardar;
        private TextBox txb_usuario;
        private Button btn_mostrar;
        private TextBox txb_senha;
        private TextBox txb_nome;
    }
}
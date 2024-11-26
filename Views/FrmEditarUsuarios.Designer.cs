namespace Projeto_Agenda_Destruidora_De_Mundos_Do_Alex.Views
{
    partial class FrmEditarUsuarios
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
            btn_voltar = new Button();
            groupBox_Tabela1 = new GroupBox();
            dgv_Usuario = new DataGridView();
            btn_excluir_usuario = new Button();
            btn_alterar_senha = new Button();
            txb_alterar_senha = new TextBox();
            groupBox_alterar_senha = new GroupBox();
            groupBox_Tabela1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Usuario).BeginInit();
            groupBox_alterar_senha.SuspendLayout();
            SuspendLayout();
            // 
            // btn_voltar
            // 
            btn_voltar.Location = new Point(241, 565);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(82, 23);
            btn_voltar.TabIndex = 8;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // groupBox_Tabela1
            // 
            groupBox_Tabela1.Controls.Add(dgv_Usuario);
            groupBox_Tabela1.Controls.Add(btn_excluir_usuario);
            groupBox_Tabela1.Location = new Point(49, 241);
            groupBox_Tabela1.Name = "groupBox_Tabela1";
            groupBox_Tabela1.Size = new Size(473, 272);
            groupBox_Tabela1.TabIndex = 9;
            groupBox_Tabela1.TabStop = false;
            groupBox_Tabela1.Text = "Usuários";
            // 
            // dgv_Usuario
            // 
            dgv_Usuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Usuario.Location = new Point(16, 22);
            dgv_Usuario.Name = "dgv_Usuario";
            dgv_Usuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Usuario.Size = new Size(440, 200);
            dgv_Usuario.TabIndex = 5;
            // 
            // btn_excluir_usuario
            // 
            btn_excluir_usuario.Location = new Point(192, 245);
            btn_excluir_usuario.Margin = new Padding(3, 2, 3, 2);
            btn_excluir_usuario.Name = "btn_excluir_usuario";
            btn_excluir_usuario.Size = new Size(82, 22);
            btn_excluir_usuario.TabIndex = 1;
            btn_excluir_usuario.Text = "Excluir";
            btn_excluir_usuario.UseVisualStyleBackColor = true;
            btn_excluir_usuario.Click += btn_excluir_categoria_Click_1;
            // 
            // btn_alterar_senha
            // 
            btn_alterar_senha.Location = new Point(81, 100);
            btn_alterar_senha.Margin = new Padding(3, 2, 3, 2);
            btn_alterar_senha.Name = "btn_alterar_senha";
            btn_alterar_senha.Size = new Size(82, 22);
            btn_alterar_senha.TabIndex = 1;
            btn_alterar_senha.Text = "Atualizar";
            btn_alterar_senha.UseVisualStyleBackColor = true;
            btn_alterar_senha.Click += btn_alterar_senha_Click;
            // 
            // txb_alterar_senha
            // 
            txb_alterar_senha.Location = new Point(69, 40);
            txb_alterar_senha.Margin = new Padding(3, 2, 3, 2);
            txb_alterar_senha.Name = "txb_alterar_senha";
            txb_alterar_senha.Size = new Size(110, 23);
            txb_alterar_senha.TabIndex = 0;
            // 
            // groupBox_alterar_senha
            // 
            groupBox_alterar_senha.Controls.Add(txb_alterar_senha);
            groupBox_alterar_senha.Controls.Add(btn_alterar_senha);
            groupBox_alterar_senha.Location = new Point(160, 40);
            groupBox_alterar_senha.Name = "groupBox_alterar_senha";
            groupBox_alterar_senha.Size = new Size(250, 170);
            groupBox_alterar_senha.TabIndex = 10;
            groupBox_alterar_senha.TabStop = false;
            groupBox_alterar_senha.Text = "Altere a senha";
            // 
            // FrmEditarUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 600);
            Controls.Add(groupBox_alterar_senha);
            Controls.Add(groupBox_Tabela1);
            Controls.Add(btn_voltar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEditarUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Usuários";
            groupBox_Tabela1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Usuario).EndInit();
            groupBox_alterar_senha.ResumeLayout(false);
            groupBox_alterar_senha.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_voltar;
        private GroupBox groupBox_Tabela1;
        private DataGridView dgv_Usuario;
        private Button btn_excluir_usuario;
        private Button btn_alterar_senha;
        private TextBox txb_alterar_senha;
        private GroupBox groupBox_alterar_senha;
    }
}
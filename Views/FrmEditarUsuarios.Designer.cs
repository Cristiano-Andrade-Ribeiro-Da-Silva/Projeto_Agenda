﻿namespace Projeto_Agenda_Destruidora_De_Mundos_Do_Alex.Views
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
            groupBox_Tabela = new GroupBox();
            dgv_Usuario = new DataGridView();
            btn_excluir_usuarios = new Button();
            btn_voltar = new Button();
            groupBox_Tabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Usuario).BeginInit();
            SuspendLayout();
            // 
            // groupBox_Tabela
            // 
            groupBox_Tabela.Controls.Add(dgv_Usuario);
            groupBox_Tabela.Controls.Add(btn_excluir_usuarios);
            groupBox_Tabela.Location = new Point(27, 23);
            groupBox_Tabela.Name = "groupBox_Tabela";
            groupBox_Tabela.Size = new Size(313, 272);
            groupBox_Tabela.TabIndex = 7;
            groupBox_Tabela.TabStop = false;
            groupBox_Tabela.Text = "Usuários";
            // 
            // dgv_Usuario
            // 
            dgv_Usuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Usuario.Location = new Point(19, 22);
            dgv_Usuario.Name = "dgv_Usuario";
            dgv_Usuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Usuario.Size = new Size(274, 200);
            dgv_Usuario.TabIndex = 5;
            // 
            // btn_excluir_usuarios
            // 
            btn_excluir_usuarios.Location = new Point(118, 245);
            btn_excluir_usuarios.Margin = new Padding(3, 2, 3, 2);
            btn_excluir_usuarios.Name = "btn_excluir_usuarios";
            btn_excluir_usuarios.Size = new Size(82, 22);
            btn_excluir_usuarios.TabIndex = 1;
            btn_excluir_usuarios.Text = "Excluir";
            btn_excluir_usuarios.UseVisualStyleBackColor = true;
            btn_excluir_usuarios.Click += btn_excluir_categoria_Click;
            // 
            // btn_voltar
            // 
            btn_voltar.Location = new Point(285, 315);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(75, 23);
            btn_voltar.TabIndex = 8;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += button1_Click;
            // 
            // FrmEditarUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 350);
            Controls.Add(btn_voltar);
            Controls.Add(groupBox_Tabela);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEditarUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Usuários";
            groupBox_Tabela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Usuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_Tabela;
        private DataGridView dgv_Usuario;
        private Button btn_excluir_usuarios;
        private Button btn_voltar;
    }
}
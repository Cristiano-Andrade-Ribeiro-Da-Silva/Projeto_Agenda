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
            dgv_Categoria = new DataGridView();
            btn_excluir_categoria = new Button();
            groupBox_Tabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Categoria).BeginInit();
            SuspendLayout();
            // 
            // groupBox_Tabela
            // 
            groupBox_Tabela.Controls.Add(dgv_Categoria);
            groupBox_Tabela.Controls.Add(btn_excluir_categoria);
            groupBox_Tabela.Location = new Point(373, 12);
            groupBox_Tabela.Name = "groupBox_Tabela";
            groupBox_Tabela.Size = new Size(240, 272);
            groupBox_Tabela.TabIndex = 7;
            groupBox_Tabela.TabStop = false;
            groupBox_Tabela.Text = "Usuários";
            // 
            // dgv_Categoria
            // 
            dgv_Categoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Categoria.Location = new Point(19, 22);
            dgv_Categoria.Name = "dgv_Categoria";
            dgv_Categoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Categoria.Size = new Size(200, 200);
            dgv_Categoria.TabIndex = 5;
            // 
            // btn_excluir_categoria
            // 
            btn_excluir_categoria.Location = new Point(86, 245);
            btn_excluir_categoria.Margin = new Padding(3, 2, 3, 2);
            btn_excluir_categoria.Name = "btn_excluir_categoria";
            btn_excluir_categoria.Size = new Size(82, 22);
            btn_excluir_categoria.TabIndex = 1;
            btn_excluir_categoria.Text = "Excluir";
            btn_excluir_categoria.UseVisualStyleBackColor = true;
            btn_excluir_categoria.Click += btn_excluir_categoria_Click;
            // 
            // FrmEditarUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 350);
            Controls.Add(groupBox_Tabela);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEditarUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Usuários";
            groupBox_Tabela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Categoria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_Tabela;
        private DataGridView dgv_Categoria;
        private Button btn_excluir_categoria;
    }
}
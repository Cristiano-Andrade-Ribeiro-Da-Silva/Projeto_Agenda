namespace Projeto_Agenda_Destruidora_De_Mundos_Do_Alex.Views
{
    partial class Frm_Contatos
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
            dgv_Contatos = new DataGridView();
            btn_excluir_contato = new Button();
            btn_Voltar = new Button();
            gbx_menu_edição = new GroupBox();
            cbx_Categoria = new ComboBox();
            txb_Telefone = new TextBox();
            btn_atualizar_contato = new Button();
            txb_Contato = new TextBox();
            btn_cadastrar_contato = new Button();
            groupBox_Tabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Contatos).BeginInit();
            gbx_menu_edição.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_Tabela
            // 
            groupBox_Tabela.Controls.Add(dgv_Contatos);
            groupBox_Tabela.Controls.Add(btn_excluir_contato);
            groupBox_Tabela.Location = new Point(308, 30);
            groupBox_Tabela.Name = "groupBox_Tabela";
            groupBox_Tabela.Size = new Size(464, 295);
            groupBox_Tabela.TabIndex = 9;
            groupBox_Tabela.TabStop = false;
            groupBox_Tabela.Text = "Categorias";
            // 
            // dgv_Contatos
            // 
            dgv_Contatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Contatos.Location = new Point(23, 22);
            dgv_Contatos.Name = "dgv_Contatos";
            dgv_Contatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Contatos.Size = new Size(423, 212);
            dgv_Contatos.TabIndex = 5;
            // 
            // btn_excluir_contato
            // 
            btn_excluir_contato.Location = new Point(192, 249);
            btn_excluir_contato.Margin = new Padding(3, 2, 3, 2);
            btn_excluir_contato.Name = "btn_excluir_contato";
            btn_excluir_contato.Size = new Size(82, 22);
            btn_excluir_contato.TabIndex = 1;
            btn_excluir_contato.Text = "Excluir";
            btn_excluir_contato.UseVisualStyleBackColor = true;
            // 
            // btn_Voltar
            // 
            btn_Voltar.Location = new Point(331, 372);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(82, 23);
            btn_Voltar.TabIndex = 8;
            btn_Voltar.Text = "Voltar";
            btn_Voltar.UseVisualStyleBackColor = true;
            // 
            // gbx_menu_edição
            // 
            gbx_menu_edição.Controls.Add(cbx_Categoria);
            gbx_menu_edição.Controls.Add(txb_Telefone);
            gbx_menu_edição.Controls.Add(btn_atualizar_contato);
            gbx_menu_edição.Controls.Add(txb_Contato);
            gbx_menu_edição.Controls.Add(btn_cadastrar_contato);
            gbx_menu_edição.Location = new Point(28, 30);
            gbx_menu_edição.Name = "gbx_menu_edição";
            gbx_menu_edição.Size = new Size(250, 295);
            gbx_menu_edição.TabIndex = 7;
            gbx_menu_edição.TabStop = false;
            gbx_menu_edição.Text = "Menu";
            // 
            // cbx_Categoria
            // 
            cbx_Categoria.FormattingEnabled = true;
            cbx_Categoria.Location = new Point(70, 141);
            cbx_Categoria.Name = "cbx_Categoria";
            cbx_Categoria.Size = new Size(110, 23);
            cbx_Categoria.TabIndex = 10;
            // 
            // txb_Telefone
            // 
            txb_Telefone.Location = new Point(70, 89);
            txb_Telefone.Margin = new Padding(3, 2, 3, 2);
            txb_Telefone.Name = "txb_Telefone";
            txb_Telefone.Size = new Size(110, 23);
            txb_Telefone.TabIndex = 8;
            // 
            // btn_atualizar_contato
            // 
            btn_atualizar_contato.Location = new Point(85, 248);
            btn_atualizar_contato.Name = "btn_atualizar_contato";
            btn_atualizar_contato.Size = new Size(82, 23);
            btn_atualizar_contato.TabIndex = 7;
            btn_atualizar_contato.Text = "Atualizar";
            btn_atualizar_contato.UseVisualStyleBackColor = true;
            btn_atualizar_contato.Click += btn_atualizar_contato_Click;
            // 
            // txb_Contato
            // 
            txb_Contato.Location = new Point(70, 40);
            txb_Contato.Margin = new Padding(3, 2, 3, 2);
            txb_Contato.Name = "txb_Contato";
            txb_Contato.Size = new Size(110, 23);
            txb_Contato.TabIndex = 0;
            // 
            // btn_cadastrar_contato
            // 
            btn_cadastrar_contato.Location = new Point(85, 200);
            btn_cadastrar_contato.Margin = new Padding(3, 2, 3, 2);
            btn_cadastrar_contato.Name = "btn_cadastrar_contato";
            btn_cadastrar_contato.Size = new Size(82, 22);
            btn_cadastrar_contato.TabIndex = 1;
            btn_cadastrar_contato.Text = "Cadastrar";
            btn_cadastrar_contato.UseVisualStyleBackColor = true;
            btn_cadastrar_contato.Click += btn_cadastrar_contato_Click;
            // 
            // Frm_Contatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 420);
            Controls.Add(groupBox_Tabela);
            Controls.Add(btn_Voltar);
            Controls.Add(gbx_menu_edição);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Contatos";
            Text = "Frm_Contatos";
            groupBox_Tabela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Contatos).EndInit();
            gbx_menu_edição.ResumeLayout(false);
            gbx_menu_edição.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_Tabela;
        private DataGridView dgv_Contatos;
        private Button btn_excluir_contato;
        private Button btn_Voltar;
        private GroupBox gbx_menu_edição;
        private Button btn_atualizar_contato;
        private TextBox txb_Contato;
        private Button btn_cadastrar_contato;
        private TextBox txb_Telefone;
        private ComboBox cbx_Categoria;
    }
}
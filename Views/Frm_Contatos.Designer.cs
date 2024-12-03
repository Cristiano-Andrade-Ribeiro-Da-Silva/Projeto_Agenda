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
            lbl_categoria_do_contato = new Label();
            lbl_telefone_do_contato = new Label();
            lbl_nome_do_contato = new Label();
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
            groupBox_Tabela.Location = new Point(352, 40);
            groupBox_Tabela.Margin = new Padding(3, 4, 3, 4);
            groupBox_Tabela.Name = "groupBox_Tabela";
            groupBox_Tabela.Padding = new Padding(3, 4, 3, 4);
            groupBox_Tabela.Size = new Size(530, 393);
            groupBox_Tabela.TabIndex = 9;
            groupBox_Tabela.TabStop = false;
            groupBox_Tabela.Text = "Contatos";
            // 
            // dgv_Contatos
            // 
            dgv_Contatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Contatos.Location = new Point(26, 29);
            dgv_Contatos.Margin = new Padding(3, 4, 3, 4);
            dgv_Contatos.Name = "dgv_Contatos";
            dgv_Contatos.RowHeadersWidth = 51;
            dgv_Contatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Contatos.Size = new Size(483, 283);
            dgv_Contatos.TabIndex = 5;
            // 
            // btn_excluir_contato
            // 
            btn_excluir_contato.Location = new Point(219, 332);
            btn_excluir_contato.Name = "btn_excluir_contato";
            btn_excluir_contato.Size = new Size(94, 29);
            btn_excluir_contato.TabIndex = 1;
            btn_excluir_contato.Text = "Excluir";
            btn_excluir_contato.UseVisualStyleBackColor = true;
            btn_excluir_contato.Click += btn_excluir_contato_Click;
            // 
            // btn_Voltar
            // 
            btn_Voltar.Location = new Point(378, 496);
            btn_Voltar.Margin = new Padding(3, 4, 3, 4);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(94, 31);
            btn_Voltar.TabIndex = 8;
            btn_Voltar.Text = "Voltar";
            btn_Voltar.UseVisualStyleBackColor = true;
            btn_Voltar.Click += btn_Voltar_Click;
            // 
            // gbx_menu_edição
            // 
            gbx_menu_edição.Controls.Add(lbl_categoria_do_contato);
            gbx_menu_edição.Controls.Add(lbl_telefone_do_contato);
            gbx_menu_edição.Controls.Add(lbl_nome_do_contato);
            gbx_menu_edição.Controls.Add(cbx_Categoria);
            gbx_menu_edição.Controls.Add(txb_Telefone);
            gbx_menu_edição.Controls.Add(btn_atualizar_contato);
            gbx_menu_edição.Controls.Add(txb_Contato);
            gbx_menu_edição.Controls.Add(btn_cadastrar_contato);
            gbx_menu_edição.Location = new Point(32, 40);
            gbx_menu_edição.Margin = new Padding(3, 4, 3, 4);
            gbx_menu_edição.Name = "gbx_menu_edição";
            gbx_menu_edição.Padding = new Padding(3, 4, 3, 4);
            gbx_menu_edição.Size = new Size(286, 393);
            gbx_menu_edição.TabIndex = 7;
            gbx_menu_edição.TabStop = false;
            gbx_menu_edição.Text = "Menu";
            // 
            // lbl_categoria_do_contato
            // 
            lbl_categoria_do_contato.AutoSize = true;
            lbl_categoria_do_contato.Location = new Point(80, 164);
            lbl_categoria_do_contato.Name = "lbl_categoria_do_contato";
            lbl_categoria_do_contato.Size = new Size(153, 20);
            lbl_categoria_do_contato.TabIndex = 13;
            lbl_categoria_do_contato.Text = "Categoria do Contato";
            // 
            // lbl_telefone_do_contato
            // 
            lbl_telefone_do_contato.AutoSize = true;
            lbl_telefone_do_contato.Location = new Point(76, 96);
            lbl_telefone_do_contato.Name = "lbl_telefone_do_contato";
            lbl_telefone_do_contato.Size = new Size(145, 20);
            lbl_telefone_do_contato.TabIndex = 12;
            lbl_telefone_do_contato.Text = "Telefone do Contato";
            // 
            // lbl_nome_do_contato
            // 
            lbl_nome_do_contato.AutoSize = true;
            lbl_nome_do_contato.Location = new Point(76, 24);
            lbl_nome_do_contato.Name = "lbl_nome_do_contato";
            lbl_nome_do_contato.Size = new Size(129, 20);
            lbl_nome_do_contato.TabIndex = 11;
            lbl_nome_do_contato.Text = "Nome do Contato";
            // 
            // cbx_Categoria
            // 
            cbx_Categoria.FormattingEnabled = true;
            cbx_Categoria.Location = new Point(80, 188);
            cbx_Categoria.Margin = new Padding(3, 4, 3, 4);
            cbx_Categoria.Name = "cbx_Categoria";
            cbx_Categoria.Size = new Size(125, 28);
            cbx_Categoria.TabIndex = 10;
            // 
            // txb_Telefone
            // 
            txb_Telefone.Location = new Point(80, 119);
            txb_Telefone.Name = "txb_Telefone";
            txb_Telefone.Size = new Size(125, 27);
            txb_Telefone.TabIndex = 8;
            // 
            // btn_atualizar_contato
            // 
            btn_atualizar_contato.Location = new Point(97, 331);
            btn_atualizar_contato.Margin = new Padding(3, 4, 3, 4);
            btn_atualizar_contato.Name = "btn_atualizar_contato";
            btn_atualizar_contato.Size = new Size(94, 31);
            btn_atualizar_contato.TabIndex = 7;
            btn_atualizar_contato.Text = "Atualizar";
            btn_atualizar_contato.UseVisualStyleBackColor = true;
            btn_atualizar_contato.Click += btn_atualizar_contato_Click;
            // 
            // txb_Contato
            // 
            txb_Contato.Location = new Point(80, 53);
            txb_Contato.Name = "txb_Contato";
            txb_Contato.Size = new Size(125, 27);
            txb_Contato.TabIndex = 0;
            // 
            // btn_cadastrar_contato
            // 
            btn_cadastrar_contato.Location = new Point(97, 267);
            btn_cadastrar_contato.Name = "btn_cadastrar_contato";
            btn_cadastrar_contato.Size = new Size(94, 29);
            btn_cadastrar_contato.TabIndex = 1;
            btn_cadastrar_contato.Text = "Cadastrar";
            btn_cadastrar_contato.UseVisualStyleBackColor = true;
            btn_cadastrar_contato.Click += btn_cadastrar_contato_Click;
            // 
            // Frm_Contatos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 560);
            Controls.Add(groupBox_Tabela);
            Controls.Add(btn_Voltar);
            Controls.Add(gbx_menu_edição);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Frm_Contatos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Contatos";
            Load += Frm_Contatos_Load_1;
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
        private Label lbl_categoria_do_contato;
        private Label lbl_telefone_do_contato;
        private Label lbl_nome_do_contato;
    }
}
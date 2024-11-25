namespace Projeto_Agenda_Destruidora_De_Mundos_Do_Alex.Views
{
    partial class FrmCadastrarCategoriacs
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
            txb_criar_categoria = new TextBox();
            btn_cadastrar_categoria = new Button();
            groupBox_nova_categoria = new GroupBox();
            btn_atualizar = new Button();
            btn_Voltar = new Button();
            dgv_Categoria = new DataGridView();
            btn_excluir_categoria = new Button();
            groupBox_Tabela = new GroupBox();
            groupBox1 = new GroupBox();
            txb_novo_nome_categoria = new TextBox();
            txb_cod_categoria = new TextBox();
            groupBox_nova_categoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Categoria).BeginInit();
            groupBox_Tabela.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txb_criar_categoria
            // 
            txb_criar_categoria.Location = new Point(71, 42);
            txb_criar_categoria.Margin = new Padding(3, 2, 3, 2);
            txb_criar_categoria.Name = "txb_criar_categoria";
            txb_criar_categoria.Size = new Size(110, 23);
            txb_criar_categoria.TabIndex = 0;
            // 
            // btn_cadastrar_categoria
            // 
            btn_cadastrar_categoria.Location = new Point(85, 99);
            btn_cadastrar_categoria.Margin = new Padding(3, 2, 3, 2);
            btn_cadastrar_categoria.Name = "btn_cadastrar_categoria";
            btn_cadastrar_categoria.Size = new Size(82, 22);
            btn_cadastrar_categoria.TabIndex = 1;
            btn_cadastrar_categoria.Text = "Cadastrar";
            btn_cadastrar_categoria.UseVisualStyleBackColor = true;
            btn_cadastrar_categoria.Click += btn_cadastrar_categoria_Click;
            // 
            // groupBox_nova_categoria
            // 
            groupBox_nova_categoria.Controls.Add(txb_criar_categoria);
            groupBox_nova_categoria.Controls.Add(btn_cadastrar_categoria);
            groupBox_nova_categoria.Location = new Point(69, 35);
            groupBox_nova_categoria.Name = "groupBox_nova_categoria";
            groupBox_nova_categoria.Size = new Size(250, 150);
            groupBox_nova_categoria.TabIndex = 3;
            groupBox_nova_categoria.TabStop = false;
            groupBox_nova_categoria.Text = "Insira a nova categoria";
            // 
            // btn_atualizar
            // 
            btn_atualizar.Location = new Point(85, 113);
            btn_atualizar.Name = "btn_atualizar";
            btn_atualizar.Size = new Size(82, 23);
            btn_atualizar.TabIndex = 7;
            btn_atualizar.Text = "Atualizar";
            btn_atualizar.UseVisualStyleBackColor = true;
            btn_atualizar.Click += btn_atualizar_Click;
            // 
            // btn_Voltar
            // 
            btn_Voltar.Location = new Point(203, 565);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(82, 23);
            btn_Voltar.TabIndex = 4;
            btn_Voltar.Text = "Voltar";
            btn_Voltar.UseVisualStyleBackColor = true;
            btn_Voltar.Click += btn_Voltar_Click;
            // 
            // dgv_Categoria
            // 
            dgv_Categoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Categoria.Location = new Point(19, 22);
            dgv_Categoria.Name = "dgv_Categoria";
            dgv_Categoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Categoria.Size = new Size(342, 200);
            dgv_Categoria.TabIndex = 5;
            // 
            // btn_excluir_categoria
            // 
            btn_excluir_categoria.Location = new Point(153, 245);
            btn_excluir_categoria.Margin = new Padding(3, 2, 3, 2);
            btn_excluir_categoria.Name = "btn_excluir_categoria";
            btn_excluir_categoria.Size = new Size(82, 22);
            btn_excluir_categoria.TabIndex = 1;
            btn_excluir_categoria.Text = "Excluir";
            btn_excluir_categoria.UseVisualStyleBackColor = true;
            btn_excluir_categoria.Click += btn_excluir_categoria_Click;
            // 
            // groupBox_Tabela
            // 
            groupBox_Tabela.Controls.Add(dgv_Categoria);
            groupBox_Tabela.Controls.Add(btn_excluir_categoria);
            groupBox_Tabela.Location = new Point(50, 250);
            groupBox_Tabela.Name = "groupBox_Tabela";
            groupBox_Tabela.Size = new Size(383, 272);
            groupBox_Tabela.TabIndex = 6;
            groupBox_Tabela.TabStop = false;
            groupBox_Tabela.Text = "Categorias";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_atualizar);
            groupBox1.Controls.Add(txb_novo_nome_categoria);
            groupBox1.Controls.Add(txb_cod_categoria);
            groupBox1.Location = new Point(446, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 170);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Atualizar categoria";
            // 
            // txb_novo_nome_categoria
            // 
            txb_novo_nome_categoria.Location = new Point(70, 74);
            txb_novo_nome_categoria.Margin = new Padding(3, 2, 3, 2);
            txb_novo_nome_categoria.Name = "txb_novo_nome_categoria";
            txb_novo_nome_categoria.Size = new Size(110, 23);
            txb_novo_nome_categoria.TabIndex = 8;
            // 
            // txb_cod_categoria
            // 
            txb_cod_categoria.Location = new Point(71, 31);
            txb_cod_categoria.Margin = new Padding(3, 2, 3, 2);
            txb_cod_categoria.Name = "txb_cod_categoria";
            txb_cod_categoria.Size = new Size(110, 23);
            txb_cod_categoria.TabIndex = 0;
            // 
            // FrmCadastrarCategoriacs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 600);
            Controls.Add(groupBox1);
            Controls.Add(groupBox_Tabela);
            Controls.Add(btn_Voltar);
            Controls.Add(groupBox_nova_categoria);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmCadastrarCategoriacs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCadastrarCategoriacs";
            Load += FrmCadastrarCategoriacs_Load;
            groupBox_nova_categoria.ResumeLayout(false);
            groupBox_nova_categoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Categoria).EndInit();
            groupBox_Tabela.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txb_criar_categoria;
        private Button btn_cadastrar_categoria;
        private GroupBox groupBox_nova_categoria;
        private Button btn_Voltar;
        private DataGridView dgv_Categoria;
        private Button btn_excluir_categoria;
        private GroupBox groupBox_Tabela;
        private Button btn_atualizar;
        private GroupBox groupBox1;
        private TextBox txb_novo_nome_categoria;
        private TextBox txb_cod_categoria;
    }
}
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
            textBox_categoria = new TextBox();
            btn_cadastrar_categoria = new Button();
            groupBox_nova_categoria = new GroupBox();
            btn_Voltar = new Button();
            dgv_Categoria = new DataGridView();
            btn_dgv = new Button();
            groupBox_nova_categoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Categoria).BeginInit();
            SuspendLayout();
            // 
            // textBox_categoria
            // 
            textBox_categoria.Location = new Point(71, 42);
            textBox_categoria.Margin = new Padding(3, 2, 3, 2);
            textBox_categoria.Name = "textBox_categoria";
            textBox_categoria.Size = new Size(110, 23);
            textBox_categoria.TabIndex = 0;
            // 
            // btn_cadastrar_categoria
            // 
            btn_cadastrar_categoria.Location = new Point(84, 98);
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
            groupBox_nova_categoria.Controls.Add(textBox_categoria);
            groupBox_nova_categoria.Controls.Add(btn_cadastrar_categoria);
            groupBox_nova_categoria.Location = new Point(50, 50);
            groupBox_nova_categoria.Name = "groupBox_nova_categoria";
            groupBox_nova_categoria.Size = new Size(250, 150);
            groupBox_nova_categoria.TabIndex = 3;
            groupBox_nova_categoria.TabStop = false;
            groupBox_nova_categoria.Text = "Insira a nova categoria";
            // 
            // btn_Voltar
            // 
            btn_Voltar.Location = new Point(300, 250);
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
            dgv_Categoria.Location = new Point(400, 50);
            dgv_Categoria.Name = "dgv_Categoria";
            dgv_Categoria.Size = new Size(240, 150);
            dgv_Categoria.TabIndex = 5;
            // 
            // btn_dgv
            // 
            btn_dgv.Location = new Point(485, 21);
            btn_dgv.Name = "btn_dgv";
            btn_dgv.Size = new Size(75, 23);
            btn_dgv.TabIndex = 6;
            btn_dgv.Text = "button1";
            btn_dgv.UseVisualStyleBackColor = true;
            btn_dgv.Click += btn_dgv_Click;
            // 
            // FrmCadastrarCategoriacs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 300);
            Controls.Add(btn_dgv);
            Controls.Add(dgv_Categoria);
            Controls.Add(btn_Voltar);
            Controls.Add(groupBox_nova_categoria);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmCadastrarCategoriacs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCadastrarCategoriacs";
            groupBox_nova_categoria.ResumeLayout(false);
            groupBox_nova_categoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Categoria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox_categoria;
        private Button btn_cadastrar_categoria;
        private GroupBox groupBox_nova_categoria;
        private Button btn_Voltar;
        private DataGridView dgv_Categoria;
        private Button btn_dgv;
    }
}
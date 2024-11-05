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
            btn_criar_categoria = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox_categoria
            // 
            textBox_categoria.Location = new Point(287, 184);
            textBox_categoria.Name = "textBox_categoria";
            textBox_categoria.Size = new Size(125, 27);
            textBox_categoria.TabIndex = 0;
            // 
            // btn_criar_categoria
            // 
            btn_criar_categoria.Location = new Point(303, 237);
            btn_criar_categoria.Name = "btn_criar_categoria";
            btn_criar_categoria.Size = new Size(94, 29);
            btn_criar_categoria.TabIndex = 1;
            btn_criar_categoria.Text = "Criar";
            btn_criar_categoria.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(287, 141);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 2;
            label1.Text = "Digite a Categoria";
            // 
            // FrmCadastrarCategoriacs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btn_criar_categoria);
            Controls.Add(textBox_categoria);
            Name = "FrmCadastrarCategoriacs";
            Text = "FrmCadastrarCategoriacs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_categoria;
        private Button btn_criar_categoria;
        private Label label1;
    }
}
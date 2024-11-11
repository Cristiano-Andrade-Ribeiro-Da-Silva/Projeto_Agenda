using Projeto_Agenda_Destruidora_De_Mundos_Do_Alex.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Agenda_Destruidora_De_Mundos_Do_Alex.Views
{
    public partial class FrmCadastrarCategoriacs : Form
    {
        public FrmCadastrarCategoriacs()
        {
            InitializeComponent();
            CategoriaController controleCategoria = new CategoriaController();
            DataTable tabela = controleCategoria.GetCategorias();
            dgv_Categoria.DataSource = tabela;
        }

        private void btn_cadastrar_categoria_Click(object sender, EventArgs e)
        {
            string categoria = textBox_categoria.Text;

            CategoriaController categoriaController = new CategoriaController();


            bool resultado = categoriaController.AddCategoria(categoria);

            //
            if (resultado == true)
            {
                MessageBox.Show("Cadastrado com Sucesso");
            }

            CategoriaController controleCategoria = new CategoriaController();
            DataTable tabela = controleCategoria.GetCategorias();
            dgv_Categoria.DataSource = tabela;
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

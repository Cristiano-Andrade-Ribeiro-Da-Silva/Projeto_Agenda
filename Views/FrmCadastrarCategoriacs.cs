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
        }

        private void Atalizador_DataGrid()
        {
            CategoriaController controleCategoria = new CategoriaController();
            DataTable tabela = controleCategoria.GetCategorias();
            dgv_Categoria.DataSource = tabela;
        }
        private void btn_cadastrar_categoria_Click(object sender, EventArgs e)
        {
            //Cria a variavel string para TextBox 
            string criar_categoria = txt_criar_categoria.Text;

            //Cria uma nova categoria controler
            CategoriaController categoriaController = new CategoriaController();

            //Criando variavel resultado
            bool resultado = categoriaController.AddCategoria(criar_categoria);

            //Usando Função
            Atalizador_DataGrid();

            //Usando variavel resultado
            if (resultado == true)
            {
                MessageBox.Show("Cadastro efetuado com Sucesso");
            }
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_excluir_categoria_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(dgv_Categoria.SelectedRows[0].Cells[0].Value);

            CategoriaController categoriaController = new CategoriaController();

            categoriaController.DelCategoria(codigo);

            Atalizador_DataGrid();
        }

        private void FrmCadastrarCategoriacs_Load(object sender, EventArgs e)
        {
            Atalizador_DataGrid();
        }
    }
}

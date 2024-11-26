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
    public partial class Frm_Contatos : Form
    {
        public Frm_Contatos()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_categoria_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Contatos_Load(object sender, EventArgs e)
        {
            CategoriaController categoriaController = new CategoriaController();

            DataTable tabela = categoriaController.GetCategorias();

            cbx_Categoria.DataSource = tabela;
            cbx_Categoria.DisplayMember = "categoria";
            cbx_Categoria.DisplayMember = "cod_categoria";


        }
    }
}

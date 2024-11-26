﻿using Projeto_Agenda_Destruidora_De_Mundos_Do_Alex.Controller;
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
    public partial class FrmEditarUsuarios : Form
    {
        public FrmEditarUsuarios()
        {
            InitializeComponent();
            UsuarioController usuarioController = new UsuarioController();
            DataTable tabela = usuarioController.GetUsuarios();
            dgv_Usuario.DataSource = tabela;
        }

        private void Atualizador_DataGrid()
        {
            CategoriaController controleCategoria = new CategoriaController();
            DataTable tabela = controleCategoria.GetCategorias();
            dgv_Usuario.DataSource = tabela;
        }

        private void btn_excluir_categoria_Click(object sender, EventArgs e)
        {

        }

        private void btn_excluir_usuarios_Click(object sender, EventArgs e)
        {
            string usuario = dgv_Usuario.SelectedRows[0].Cells[1].Value.ToString();

            UsuarioController usuarioController = new UsuarioController();

            usuarioController.DelUsuario(usuario);

            Atualizador_DataGrid();


        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

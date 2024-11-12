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
    public partial class FrmEditarUsuarios : Form
    {
        public FrmEditarUsuarios()
        {
            InitializeComponent();
            UsuarioController usuarioController = new UsuarioController();
            DataTable tabela = usuarioController.GetUsuarios();
            dgv_Usuario.DataSource = tabela;
        }

        private void btn_excluir_categoria_Click(object sender, EventArgs e)
        {

        }
    }
}

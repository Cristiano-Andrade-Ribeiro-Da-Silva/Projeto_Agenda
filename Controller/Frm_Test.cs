using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Agenda_Destruidora_De_Mundos_Do_Alex.Controller
{
    public partial class Frm_Test : Form
    {
        public Frm_Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioController controle_usuario = new UsuarioController();

            bool resultado = controle_usuario.ValidarLogin("Gorgon", "Cristiano123456_marito");

            MessageBox.Show(resultado.ToString());
        }
    }
}

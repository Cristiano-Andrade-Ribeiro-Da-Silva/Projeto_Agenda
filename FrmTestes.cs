using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Agenda_Destruidora_De_Mundos_Do_Alex.VariableGlobal;

namespace Projeto_Agenda_Destruidora_De_Mundos_Do_Alex
{
    public partial class FrmTestes : Form
    {
        public FrmTestes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserSession.NomeSession = txb_nome.Text;
            UserSession.UsuarioSession = txb_usuario.Text;
            UserSession.SenhaSession = txb_senha.Text; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Bem vindo {UserSession.NomeSession}");
;           MessageBox.Show(UserSession.UsuarioSession);
            MessageBox.Show(UserSession.SenhaSession);
        }
    }
}

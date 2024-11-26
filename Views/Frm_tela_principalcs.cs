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
    public partial class Frm_tela_principalcs : Form
    {
        public Frm_tela_principalcs()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_tela_principalcs_Load(object sender, EventArgs e)
        {
            lbl_ola_nome.Text = $"Bem vindo(a) {VariableGlobal.UserSession.NomeSession.ToString()}, use nosso aplicativo com moderação";
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditarUsuarios frmEditarUsuarios = new FrmEditarUsuarios();
            frmEditarUsuarios.ShowDialog();
        }

        private void contatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Contatos frm_Contatos = new Frm_Contatos();
            frm_Contatos.ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastrarCategoriacs FrmCadastrarCategoria = new FrmCadastrarCategoriacs();
            FrmCadastrarCategoria.ShowDialog();
        }
    }
}

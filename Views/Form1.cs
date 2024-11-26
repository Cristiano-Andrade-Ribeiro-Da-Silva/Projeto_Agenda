using Projeto_Agenda_Destruidora_De_Mundos_Do_Alex.Controller;
using Projeto_Agenda_Destruidora_De_Mundos_Do_Alex.Views;
using Projeto_Agenda_Destruidora_De_Mundos_Do_Alex.VariableGlobal;

namespace Projeto_Agenda_Destruidora_De_Mundos_Do_Alex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void abilitar_login_botao()
        {
            //Se o Usuário for diferente do que vazio e a senha for maior ou igual que 8, abilita o botão "botao_login".
            // && serve igual and ou e.
            if (txb_usuario.Text != "" && txb_senha.Text.Length >= 8)
            {
                botao_login.Enabled = true;
                Fechado.Visible = false;
                Aberto.Visible = true;
            }

            else
            {
                botao_login.Enabled = false;
                Fechado.Visible = true;
                Aberto.Visible = false;
            }
        }

        private void botao_cadastrar_Click(object sender, EventArgs e)
        {
            Frm_Tela_De_Cadastro frm_Tela_De_Cadastro = new Frm_Tela_De_Cadastro();
            frm_Tela_De_Cadastro.ShowDialog();
        }

        private void textBox_usuario_TextChanged(object sender, EventArgs e)
        {
            abilitar_login_botao();

        }

        private void textBox_senha_TextChanged(object sender, EventArgs e)
        {
            abilitar_login_botao();
        }

        private void botao_login_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            string usuario = txb_usuario.Text;
            string senha = txb_senha.Text;

            UsuarioController controle_usuario = new UsuarioController();

            bool resultado = controle_usuario.ValidarLogin(usuario, senha);

            if (resultado == true)
            {
                UserSession.UsuarioSession = txb_usuario.Text;
                UserSession.SenhaSession = txb_senha.Text;

                Frm_tela_principalcs frm_Tela_Principalcs = new Frm_tela_principalcs();
                frm_Tela_Principalcs.ShowDialog();
                this.Close();


            }

            if (resultado == false)
            {
                MessageBox.Show("Erro: Usuário ou Senha incorreta");
                this.Visible = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}

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
            //S e o Usuário for diferente do que vazio e a senha for maior ou igual que 8, abilita o botão "botao_login".
            // && serve igual and ou e.
            if (textBox_usuario.Text != "" && textBox_senha.Text.Length >= 8)
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
    }
}

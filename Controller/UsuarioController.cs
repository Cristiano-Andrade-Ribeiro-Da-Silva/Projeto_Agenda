using Projeto_Agenda_Destruidora_De_Mundos_Do_Alex.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Projeto_Agenda_Destruidora_De_Mundos_Do_Alex.VariableGlobal;

namespace Projeto_Agenda_Destruidora_De_Mundos_Do_Alex.Controller
{
    internal class UsuarioController
    {
        public bool AddUsuario(string nome, string usuario, string telefone, string senha)
        {
            try
            {

                // Cria a conexão, estou utilizando a classe ConexãoDB que está dentro da pasta
                MySqlConnection conexao = ConexãoDB.criador_conexao();

                //Comando SQL que será executado
                string sql = "INSERT INTO tb_usuarios (nome, usuario, telefone, senha) VALUES (@nome, @usuario, @telefone, @senha);" +
                             $"CREATE USER '{usuario}'@'%' IDENTIFIED BY '@senha';" +
                             $"GRANT ALL PRIVILEGES ON db_agenda.* TO '{usuario}'@'%';";

                //Abri a conexão com o banco
                conexao.Open();

                //Linha responsavelpor executar o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, conexao);


                //Estou trocando o valor "@" pelas informações que serão cadastradas
                //As Informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@senha", senha);

                //Executando no banco de dados
                int linhasAfetadas = comando.ExecuteNonQuery();

                //Fecha a conexão
                conexao.Close();

                if (linhasAfetadas > 0)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao cadastrar: {erro.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        public bool DelUsuario(string usuario)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = ConexãoDB.criador_conexao();

                string sql = "DELETE FROM tb_usuarios WHERE usuario = @usuario;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@usuario", usuario);

                int linhasAfetadas = comando.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao deletar: {erro.Message}", "Erro ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            finally
            {
                conexao.Close();
            }
        }

        public DataTable GetUsuarios()
        {
            MySqlConnection conexao = null;
            try
            {


                //Criando a conexão e usando a ConexãoDB que já foi criado
                conexao = ConexãoDB.criador_conexao();

                //SELECT montado para retornar todas as categorias
                string sql = @"SELECT nome AS 'Nome', usuario AS 'Usuário', telefone AS 'Telefone', senha AS 'Senha' FROM tb_usuarios;";

                //Abrindo Conexão
                conexao.Open();

                //Criado o adaptador
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexao);

                //Tabela Vazia Criada
                DataTable tabela = new DataTable();

                //Pedindo Para o adaptador preencher a tabela
                adaptador.Fill(tabela);

                //Retorna a tabela preenchida
                return tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao recuperar os usuários: {erro.Message}");
                return new DataTable();
            }

            finally
            {
                conexao.Close();
            }


        }

        public bool ValidarLogin(string usuario, string senha)
        {
            MySqlConnection conexao = null;
            try
            {

                conexao = ConexãoDB.criador_conexao();

                string sql = @"SELECT nome, usuario, telefone, senha FROM tb_usuarios
                           WHERE usuario = @usuario 
                           AND BINARY senha = @senha;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@senha", senha);

                MySqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {
                    // O "usuario" no "GetString" é o nome da coluna da tabela.
                    // Existe a opção de apenas colocar "0" no lugar do "usuario", independente do lugar da coluna.
                    UserSession.UsuarioSession = resultado.GetString("usuario");
                    UserSession.NomeSession = resultado.GetString("nome");
                    UserSession.SenhaSession = resultado.GetString("senha");

                    conexao.Close();
                    return true;
                }

                else
                {
                    conexao.Close();
                    return false;
                }
            }

            catch
            {
                MessageBox.Show("Erro  ao verificar o usuário");
                return false;
            }

            finally
            {
                conexao.Close();
            }


        }

        public DataTable AlterSenha(string usuario, string senha)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = ConexãoDB.criador_conexao();

                string sql = $"UPDATE tb_usuarios SET senha = '{senha}'" +
                             $"WHERE usuario = @usuario;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@senha", senha);
                int linhasAfetadas = comando.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    return new DataTable();
                }

                else
                {
                    return new DataTable();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao alterar senha : {erro.Message}");
                return new DataTable();
            }
            finally
            {
                conexao.Close();
            }
        }

    }
}

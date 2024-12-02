using MySql.Data.MySqlClient;
using Projeto_Agenda_Destruidora_De_Mundos_Do_Alex.Data;
using Projeto_Agenda_Destruidora_De_Mundos_Do_Alex.VariableGlobal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Agenda_Destruidora_De_Mundos_Do_Alex.Controller
{
    internal class ContatosController
    {

        public bool AddContato(string contato, string telefone, string categoria)
        {
            MySqlConnection conexao = null;
            try
            {

                // Cria a conexão, estou utilizando a classe ConexãoDB que está dentro da pasta
                conexao = ConexãoDB.CriarConexao(UserSession.UsuarioSession, UserSession.SenhaSession);

                //Comando SQL que será executado
                string sql = "INSERT INTO tb_contatos (contato, telefone, categoria) VALUES (@contato, @telefone, @categoria);";

                //Abri a conexão com o banco
                conexao.Open();

                //Linha responsavelpor executar o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, conexao);


                //Estou trocando o valor "@" pelas informações que serão cadastradas
                //As Informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@contato", contato);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@categoria", categoria);

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
                MessageBox.Show($"Erro ao cadastrar: {erro.Message}", "Erro ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            finally
            {
                conexao.Close();
            }
        }

        public DataTable GetContatos()
        {
            MySqlConnection conexao = null;
            try
            {


                //Criando a conexão e usando a ConexãoDB que já foi criado
                conexao = ConexãoDB.CriarConexao(UserSession.UsuarioSession, UserSession.SenhaSession);

                //SELECT montado para retornar todas as categorias
                string sql = @"SELECT cod_contato AS 'Código', contato AS 'Contatos', telefone AS 'Telefone', categoria 'Categorias' FROM tb_contatos;";


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
                MessageBox.Show($"Erro ao recuperar os contatos: {erro.Message}");
                return new DataTable();
            }

            finally
            {
                conexao.Close();
            }


        }

    }
}

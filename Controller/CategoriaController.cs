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
    internal class CategoriaController
    {
        public bool AddCategoria(string categoria)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = ConexãoDB.criador_conexao();

                string sql = "INSERT INTO tb_categoria(categoria) VALUES(@categoria);";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@categoria", categoria);

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
                MessageBox.Show($"Erro ao cadastrar: {erro.Message}", "Erro ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            finally
            {
                conexao.Close();
            }

        }

        public DataTable GetCategorias()
        {
            MySqlConnection conexao = null;
            try
            {


                //Criando a conexão e usando a ConexãoDB que já foi criado
                 conexao = ConexãoDB.CriarConexao(UserSession.UsuarioSession, UserSession.SenhaSession);

                //SELECT montado para retornar todas as categorias
                string sql = @"SELECT cod_categoria AS 'Código', categoria AS 'Categoria', usuario AS Usuário FROM tb_categoria" +
                             "WHERE usuario = USER();";

                // Ou "WHERE usuario LIKE '{UserSession.usuario}'%"
                // Desse segundo modo, existe a possibilidade de ser hakeado 


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
                MessageBox.Show($"Erro ao recuperar as categorias: {erro.Message}");
                return new DataTable();
            }

            finally
            {
                conexao.Close();
            }


        }

        public DataTable DelCategoria(int cod_categoria)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = ConexãoDB.criador_conexao();

                string sql = @"DELETE FROM tb_categoria WHERE cod_categoria = @cod_categoria;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@cod_categoria",cod_categoria);

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
            catch(Exception erro)
            {
                MessageBox.Show($"Erro ao deletar categoria : {erro.Message}");
                return new DataTable();
            }

            finally
            {
                conexao.Close();
            }
        }

        public DataTable AlterCategoria(int cod_categoria,string categoria)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = ConexãoDB.criador_conexao();

                string sql = $"UPDATE tb_categoria SET categoria = '{categoria}'" +
                             $"WHERE cod_categoria = @cod_categoria;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand (sql, conexao);

                comando.Parameters.AddWithValue("@cod_categoria", cod_categoria);
                comando.Parameters.AddWithValue("@categoria", categoria);
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
                MessageBox.Show($"Erro ao excluir categoria : {erro.Message}");
                return new DataTable();
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}


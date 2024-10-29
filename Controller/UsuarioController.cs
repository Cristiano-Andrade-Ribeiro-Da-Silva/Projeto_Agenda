using Projeto_Agenda_Destruidora_De_Mundos_Do_Alex.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Agenda_Destruidora_De_Mundos_Do_Alex.Controller
{
    internal class UsuarioController
    {
        public bool AddUsuario(string nome, string usuario, string telefone, string senha)
        {
            // Cria a conexão, estou utilizando a classe ConexãoDB que está dentro da pasta
            MySqlConnection conexao = ConexãoDB.criador_conexao();

            //Comando SQL que será executado
            string sql = "INSERT INTO tb_usuarios (nome, usuario, telefone, senha) VALUES (@nome, @usuario, @telefone, @senha);";

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
    }
}

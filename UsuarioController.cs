using Projeto_Agenda_Destruidora_De_Mundos_Do_Alex.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Agenda_Destruidora_De_Mundos_Do_Alex
{
    internal class UsuarioController
    {
        public bool AddUsuario(string nome, string usuario, string telefone, string senha) 
        {
            MySqlConnection conexao = ConexãoDB.criador_conexao();

        }
    }
}

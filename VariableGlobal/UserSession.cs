using Projeto_Agenda_Destruidora_De_Mundos_Do_Alex.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Agenda_Destruidora_De_Mundos_Do_Alex.VariableGlobal
{
    // Transformando a classe em pública e em estática para todos os usuários poderem usar a classe. 
    // Pública: Para todos poderem utilizar
    //Estática: Para todos poderem usar a mesma classe
    public static class UserSession
    {
        // Váriaves que irão guardar as imformações
        private static string _nome = null;
        private static string _usuario = null;
        private static string _senha = null;

        // Encapsulei a váriavel para ter controle  do que está sendo inserido ou pego
        public static string NomeSession
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;
            }
        }

        public static string UsuarioSession
        {
            get
            {
                return _usuario;
            }

            set
            {
                value = value.ToUpper();
                _usuario = value;
            }
        }

        public static string SenhaSession
        {
            get
            {
                return _senha;
            }

            set
            {
                _senha = value;
            }
        }
    }
}

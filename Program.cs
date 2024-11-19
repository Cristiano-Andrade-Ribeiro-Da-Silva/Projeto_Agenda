using Projeto_Agenda_Destruidora_De_Mundos_Do_Alex.Controller;
using Projeto_Agenda_Destruidora_De_Mundos_Do_Alex.Views;

namespace Projeto_Agenda_Destruidora_De_Mundos_Do_Alex
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
            Application.Run(new FrmTestes());
            //Se adcionar um "//" de comentário em um formulário aqui, apenas o formulário não comentado irá executar.
        }
    }
}
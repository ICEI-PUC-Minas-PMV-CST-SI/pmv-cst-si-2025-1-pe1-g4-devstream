using System;
using System.Windows.Forms;

namespace DevStreamInventory // Certifique-se que este namespace é o mesmo do seu projeto
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AuthService.LoadUsersFromFile(); // Carregar usuários ao iniciar
            Application.Run(new LoginForm());
            // AuthService.SaveUsersToFile(); // Movido para ser chamado em momentos mais apropriados
        }
    }
}
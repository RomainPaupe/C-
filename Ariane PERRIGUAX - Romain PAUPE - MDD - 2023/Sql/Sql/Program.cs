using MySql.Data.MySqlClient;

namespace Sql
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

            MySqlConnection maConnexion = new MySqlConnection("SERVER=localhost;PORT=3306;DATABASE=magasins;UID=root;PASSWORD=Romainpaupe1");
            maConnexion.Open();


            ApplicationConfiguration.Initialize();
            Application.Run(new FormMagasin(maConnexion));
        }
    }
}
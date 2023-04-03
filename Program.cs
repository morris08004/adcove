using System;
using System.Configuration;
using System.Windows.Forms;
using Datos;


namespace wCWdrmApp
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DbInit.CreateDb();
            //Datos.Main.InstanciarConexion(ConfigurationManager.ConnectionStrings["controlvehicular"].ConnectionString);
            Datos.Main.InstanciarConexion(ConfigurationManager.ConnectionStrings["controlvehicular"].ConnectionString);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal());
        }
    }
}

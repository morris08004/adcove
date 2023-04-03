using MySql.Data.MySqlClient;

namespace wCWdrmApp
{
    class Conexion
    {
        private string cadenaConexion;
        private MySqlConnection conexion;
        private string server = "localhost";
        private string database = "controlvehicular";
        private string user = "root";
        private string passowrd = "Leygris1$";

        public Conexion()
        {
            cadenaConexion = "Database=" + database
                           + "; Data Source=" + server
                           + "; User Id=" + user
                           + "; Password=" + passowrd;
        }

        public MySqlConnection getConexion()
        {
            if (conexion == null)
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();

            }

            return conexion;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Datos
{
    public class Main
    {
        public static clsConexion Conexion;
        private static string cadenaSQl;
        public static string CadenaSQL
        {
            get
            {
                return cadenaSQl;
            }
            set
            {
                cadenaSQl = value;
            }
        }
        public static void InstanciarConexion(String CadenaConexion)
        {
            cadenaSQl = CadenaConexion;
            Conexion = new clsConexion(CadenaConexion,BaseDatos.MySQL);
        }
        public static bool ProbarConexion()
        {
            return Conexion.TestConexion(Conexion.BasedeDatos);
        }
    }
}

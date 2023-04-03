using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class DbInit
    {
        public static void CreateDb()
        {
            using (ControlVehicularContext context = new ControlVehicularContext())
            {
                context.Database.CreateIfNotExists();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class ControlVehicularService : BaseService<Vehiculos>
    {
        public ControlVehicularService(IValidation validation, IRepository<Vehiculos> repository) : base(validation, repository)
        {

        }
    }
}

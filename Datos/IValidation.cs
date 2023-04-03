using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public interface IValidation
    {
        void AgregarError(string key, string errorMessage);
        bool IsValid { get; }
    }
}

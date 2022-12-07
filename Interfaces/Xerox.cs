using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Xerox : ICopiadora
    {
        public string Copiar(string texto)
        {
            return $"Copiando: {texto}";
        }
    }
}

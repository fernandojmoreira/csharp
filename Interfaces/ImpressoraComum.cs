using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class ImpressoraComum : IImpressora
    {
        public string Imprimir(string texto)
        {
            return $"Imprimindo: {texto}";
        }
    }
}

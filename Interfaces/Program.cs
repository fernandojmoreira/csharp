using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMundoDasClassesP2
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = new ImpressoraComum();
            var i2 = new ImpressoraCopiadora();

            Console.WriteLine(i.Imprimir("Estou estudando C#"));
            Console.WriteLine(i2.Copiar("Estou estudando C# - COPIA"));

            CopiarDocumento(new Xerox(), "Olá Mundo !");
        }

        public static void CopiarDocumento(ICopiadora c, string texto)
        {
            Console.WriteLine(c.Copiar(texto));
        }
    }
}
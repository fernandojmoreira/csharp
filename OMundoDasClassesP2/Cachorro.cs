using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMundoDasClassesP2
{
    public class Cachorro : Animais // Herdando código da classe 'Animais'
    {
        public Cachorro(string nome, int idade) : base(nome, idade)
        {

        }

        public override Som SomEmitido => Som.Latido;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMundoDasClassesP2
{
    public class Gato : Animais // Herdando código da classe 'Animais'
    {
        public Gato(string nome, int idade) : base(nome, idade) // base(nome, idade) invoca o construtor da classe 'Animais'
        {

        }
    }
}

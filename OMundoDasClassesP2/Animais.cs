﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMundoDasClassesP2
{
    public class Animais
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Animais(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}

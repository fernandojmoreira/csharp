using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMundoDasClassesP1
{
    public class Carro
    {
        // Atributos do carro
        public int Portas { get; }
        public string Modelo { get; }
        public Cor Cor { get; set; }

        private bool ligado = false; // private = Só a classe tem acesso



        public bool Ligado // Propriedade = define uma maneira de acessar atributos
        {
            get // Retorna valor
            {
                return ligado;
            }
        }

        // Método construtor da classe
        public Carro(Cor cor, int portas, string modelo)
        {
            Cor = cor;
            Portas = portas;
            Modelo = modelo;
        }

        // Comportamento do carro
        public string Ligar()
        {
            ligado = true;
            return " O carro foi ligado.";
        }
        public string Desligar()
        {
            ligado= false;
            return "O carro foi desligado";
        }
        public string Andar()
        {
            return "O carro está andando";
        }
    }
}

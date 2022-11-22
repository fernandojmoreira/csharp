using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMundoDasClassesP1
{
    class Program // Sem modificador de acesso explícito = interno por padrão
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro(Cor.Preto, 4, "Renault Symbol"); // Criando carro

            // Exibindo atributos do carro
            Console.WriteLine("O carro é um " + carro.Modelo + " de cor " + carro.Cor + " e tem " + carro.Portas + " portas.");

            Console.WriteLine(carro.Ligar()); // Ligar o carro
            Console.WriteLine("Ligado ? " + carro.Ligado);
            Console.WriteLine(carro.Andar()); // Andar com o carro
            Console.WriteLine(carro.Desligar());
            Console.WriteLine("Ligado ? " + carro.Ligado);

            carro.Cor = Cor.Vermelho; // Pintando o carro
            Console.WriteLine("A nova cor do carro é " + carro.Cor);
        }
    }
}
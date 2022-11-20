using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            // Laços condicionais => execução mediante determinada condição/situação satisfeita
            int hora = 18;

            // Laço if, else if e else
           if (hora <= 15) // se a hora for menor ou igual a 15, será impressa a mensagem no console
                    Console.WriteLine("São menos que 15h");
                else if (hora <= 18)
                    Console.WriteLine("A hora é menor ou igual a 18");
                else // o else garante a execução do bloco de código seguinte a ele
                {
                    if (hora == 20)
                        Console.WriteLine("São 20h");
                    else
                        Console.WriteLine("Já passou das 20h");
                }

            // switch .. case .. break
            // Geralmente a expressão avaliada é uma constante
            // Em nenhuma hipotese serão executados 2 casos simultaneamente
            switch (hora)
                {
                    case 15: // O teste condicional aqui é exato
                        Console.WriteLine("São 15 horas");
                        break;
                    case 18:
                        Console.WriteLine("São 18 horas");
                        break;
                }

                PrimeiroSemestre mes = PrimeiroSemestre.Agosto;
            switch(mes)
            {
                case PrimeiroSemestre.Janeiro:
                    Console.WriteLine("Estamos em Janeiro");
                    break;
                case PrimeiroSemestre.Fevereiro:
                    Console.WriteLine("Estamos em Fevereiro");
                    break;
                case PrimeiroSemestre.Março:
                    Console.WriteLine("Estamos em Março");
                    break;
                case PrimeiroSemestre.Abril:
                    Console.WriteLine("Estamos em Abril");
                    break;
                case PrimeiroSemestre.Maio:
                    Console.WriteLine("Estamos em Maio");
                    break;
                case PrimeiroSemestre.Junho:
                    Console.WriteLine("Estamos em Junho");
                    break;
                default: // Será executado se nenhum dos outros for satisfeito
                    Console.WriteLine("Estámos no segundo semestre, o mês é " + mes);
                    break;
            }
        }
    }

    public enum PrimeiroSemestre
    {
        Janeiro, Fevereiro, Março, Abril, Maio, Junho, Julho, Agosto, Setembro, Outubro, Novembro, Dezembro
    }
}
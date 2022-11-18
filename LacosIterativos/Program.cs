using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosIterativos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Laços iterativos => estruturas que repetem um bloco de código determinado número de vezes

            // for
            for(int i=0; i<5; i++) // i++ significa que i será incrimentado de 1 em 1
            {
                Console.WriteLine("Valor de i é " + i);
            }

            // while
            int contador = 3;
            while(contador < 10)
            {
                Console.WriteLine(contador);
                contador++;
            }

            // do .. while
            // execução garantida pelo menos uma vez (executa o bloco primeiro e depois faz o teste de condição)
            double j = 10;
            do
            {
                Console.WriteLine(j);
                j = j * 1.5;
            } while (j < 100);

            // foreach
            // percorre todos os elementos de um conjunto
            int[] conjunto = { 1, 2, 3, 8, 13 };
            foreach(int numero in conjunto)
            {
                Console.WriteLine("Esse elemento do conjunto tem valor " + numero + "! Somando esse valor a 10 temos " + (numero + 10));
            }
        }
    }
}
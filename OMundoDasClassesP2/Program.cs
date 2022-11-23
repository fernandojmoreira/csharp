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
            var c = new Cachorro("Capitu", 10);
            var g = new Gato("Chupeta", 6);

            Animais a = new Gato("Felix", 5); // Polimorfismo: O gato também é um animal

            ExibeAnimal(c); // Recebe argumento do tipo cachorro
            ExibeAnimal(g); // Recebe argumento do tipo gato
            ExibeAnimal(a); // Recebe argumento do tipo animal
        }

        public static void ExibeAnimal(Animais animal)
        {
            Console.WriteLine($"Nome: {animal.Nome}");
            Console.WriteLine($"Idade: {animal.Idade}");
        }
    }
}
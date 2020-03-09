using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome");
            string[] nome = Console.ReadLine().Split();
            Console.WriteLine("Resultado");
            Console.WriteLine($"{nome[2]}, {nome[0][0]}. {nome[1][0]}.");
        }
    }
}

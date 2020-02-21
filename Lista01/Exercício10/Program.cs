using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício10
{
    class Program
    {
        static void Main(string[] args)
        {
            int anos, quantidade;
            Console.WriteLine("Há quantos anos você fuma?");
            anos = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos cigarros por dia?");
            quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o preço da carteira de cigarros?");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine($"Total gasto = R$ {((valor * anos * quantidade * 365) / 20):0.00}");
        }
    }
}

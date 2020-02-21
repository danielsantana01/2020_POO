using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício01
{
    class Program
    {
        static void Main(string[] args)
        {
            int L, D;
            Console.WriteLine("Digite dois valores inteiros");
            L = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());
            if (L > D) Console.WriteLine($"Maior = {L}");
            if (D > L) Console.WriteLine($"Maior = {D}");
            if (D == L) Console.WriteLine("Números Iguais");
        }
    }
}

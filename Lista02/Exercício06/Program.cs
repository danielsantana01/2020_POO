using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três valores inteiros");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int maior = 0;
            int menor = 0;
            if (n1 > n2 && n1 > n3) maior = n1;
            if (n2 > n1 && n2 > n3) maior = n2;
            if (n3 > n1 && n3 > n2) maior = n3;
            if (n1 < n2 && n1 < n3) menor = n1;
            if (n2 < n3 && n2 < n1) menor = n2;
            if (n3 < n1 && n3 < n2) menor = n3;
            int s = maior + menor;
            Console.WriteLine($"A soma do maior com o menor número é {s}");
        }
    }
}

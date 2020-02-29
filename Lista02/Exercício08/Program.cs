using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quatro valores inteiros");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int soma;
            int maior = n1;
            int menor = n4;
            if (n1 > n2 && n1 > n3 && n1 > n4) maior = n1;
            if (n2 > n1 && n2 > n3 && n2 > n4) maior = n2;
            if (n3 > n1 && n3 > n2 && n3 > n4) maior = n3;
            if (n4 > n1 && n4 > n2 && n4 > n3) maior = n4;
            if (n1 < n2 && n1 < n3 && n1 < n4) menor = n1;
            if (n2 < n3 && n2 < n1 && n2 < n4) menor = n2;
            if (n3 < n1 && n3 < n2 && n3 < n4) menor = n3;
            if (n4 < n1 && n4 < n2 && n4 < n3) menor = n4;
            soma = n1 + n2 + n3 + n4 - maior - menor;
            Console.WriteLine($"Maior valor = {maior}");
            Console.WriteLine($"Menor valor = {menor}");
            Console.WriteLine($"A soma do segundo maior valor com o segundo menor = {soma}");
        }
    }
}

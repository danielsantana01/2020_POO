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
            int n1, n2, n5, n10, n20, n50, n100;
            Console.WriteLine("Digite um valor monetário inteiro");
            int valor = int.Parse(Console.ReadLine());
            n100 = valor / 100;
            n50 = (valor - n100 * 100) / 50;
            n20 = (valor - n100 * 100 - n50 * 50) / 20;
            n10 = (valor - n100 * 100 - n50 * 50 - n20 * 20) / 10;
            n5 = (valor - n100 * 100 - n50 * 50 - n20 * 20 - n10 * 10) / 5;
            n2 = (valor - n100 * 100 - n50 * 50 - n20 * 20 - n10 * 10 - n5 * 5) / 2;
            n1 = valor - n100 * 100 - n50 * 50 - n20 * 20 - n10 * 10 - n5 * 5 - n2 * 2;
            Console.WriteLine($"{n100} cédula(s) de 100 reais \n{n50} cédula(s) de 50 reais \n{n20} cédula(s) de 20 reais \n{n10} cédula(s) de 10 reais \n{n5} cédula(s) de 5 reais \n{n2} " +
            $"cédula(s) de 2 reais \n{n1} cédula(s) de 1 reais");
        }
    }
}

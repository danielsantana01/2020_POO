using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício09
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, imc;
            Console.WriteLine("Informe sua massa em kg:");
            int massa = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe sua altura em metros:");
            altura = double.Parse(Console.ReadLine());
            imc = massa / (Math.Pow(altura, 2));
            Console.WriteLine($"Seu IMC é {imc:0.00}");
        }
    }
}

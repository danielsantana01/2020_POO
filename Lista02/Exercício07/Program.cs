using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os coeficientes a, b, e c de uma equação do II grau");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2;
            double x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2;
            Console.WriteLine($"As raízes são {x1} e {x2}");
            Console.ReadKey();
        }
    }
}

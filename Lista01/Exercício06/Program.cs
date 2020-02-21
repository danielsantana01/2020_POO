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
            int b, h;
            Console.WriteLine("Digite a base e a altura do retângulo");
            b = int.Parse(Console.ReadLine());
            h = int.Parse(Console.ReadLine());
            Console.WriteLine($"Área = {b * h} - Perímetro = {2 * b + 2 * h} - Diagonal = {Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2))}");
        }
    }
}

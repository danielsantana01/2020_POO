using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício03
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, circunferencia, area;
            Console.WriteLine("Digite o raio de um círculo:");
            raio = double.Parse(Console.ReadLine());
            circunferencia = 2 * Math.PI * raio;
            area = Math.PI * Math.Pow(raio, 2);
            Console.WriteLine($"Circunferência = {circunferencia:0.00}");
            Console.WriteLine($"Área = {area:0.00}");
        }
    }
}

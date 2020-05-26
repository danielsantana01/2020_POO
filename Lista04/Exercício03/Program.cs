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
            Console.WriteLine("Informe o salário atual");
            double salario = double.Parse(Console.ReadLine());
            if (salario < 500) salario = (12 * salario) / 10;
            else if (salario >= 500 && salario < 1000) salario = (115 * salario) / 100;
            else if (salario >= 1000) salario = (11 * salario) / 10;
            Console.WriteLine($"Seu novo salário é {salario:0.00}");
        }
    }
}

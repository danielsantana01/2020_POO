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
            Console.WriteLine("Informe o valor unitário do produto");
            double V = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade comprada");
            int Q = int.Parse(Console.ReadLine());
            double total = 0;
            if (Q > 0 && Q <= 10) total = Q * V * 0.95;
            else if (Q >= 11 && Q <= 50) total = 9.5 * V + (Q - 10) * V * 0.9;
            else if (Q > 50) total = 45.5 * V + (Q - 50) * V * 0.8;
            Console.WriteLine($"O total a ser pago é R$ {total:0.00}");
            Console.ReadKey();
        }
    }
}

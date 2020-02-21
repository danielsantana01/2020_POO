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
            Console.WriteLine("Digite um valor monetário:");
            double din = double.Parse(Console.ReadLine());
            int reais = (int)din;
            int cents = (int)(din * 100 - reais * 100);
            Console.WriteLine($"{reais} reais e {cents} centavos");
        }
    }
}

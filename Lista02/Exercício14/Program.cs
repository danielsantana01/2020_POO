using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três valores:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            if ((n1 + n3) > n2 && (n1 + n2) > n3 && (n2 + n3) > n1)
            {
                Console.WriteLine("Esses valores formam um triângulo");
            }
            else
            {
                Console.WriteLine("Esses valores não formam um triângulo");
            }
        }
    }
}

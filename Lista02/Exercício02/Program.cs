using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, md;
            Console.WriteLine("Digite quatro valores inteiros");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());
            md = (n1 + n2 + n3 + n4) / 4;
            Console.WriteLine($"Média = {md}");
            Console.WriteLine("Números menores que a média");
            if (n1 < md)
            {
                Console.WriteLine(n1);
            }
            if (n2 < md)
            {
                Console.WriteLine(n2);
            }
            if (n3 < md)
            {
                Console.WriteLine(n3);
            }
            if (n4 < md)
            {
                Console.WriteLine(n4);
            }
            Console.WriteLine("Números maiores ou iguais à média");
            if (n1 >= md)
            {
                Console.WriteLine(n1);
            }
            if (n2 >= md)
            {
                Console.WriteLine(n2);
            }
            if (n3 >= md)
            {
                Console.WriteLine(n3);
            }
            if (n4 >= md)
            {
                Console.WriteLine(n4);
            }
    }
}

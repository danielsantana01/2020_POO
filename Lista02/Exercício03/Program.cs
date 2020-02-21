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
            int n1, n2, n3, n4;
            int sp = 0;
            int si = 0;
            Console.WriteLine("Digite quatro valores inteiros");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());
            if (n1 % 2 == 0)
            {
                sp = sp + n1;
            }
            else
            {
                si = si + n1;
            }
            if (n2 % 2 == 0)
            {
                sp = sp + n2;
            }
            else
            {
                si = si + n2;
            }
            if (n3 % 2 == 0)
            {
                sp = sp + n3;
            }
            else
            {
                si = si + n3;
            }
            if (n4 % 2 == 0)
            {
                sp = sp + n4;
            }
            else
            {
                si = si + n4;
            }
            Console.WriteLine($"Soma dos pares = {sp}");
            Console.WriteLine($"Soma dos ímpares = {si}");
        }
    }
}

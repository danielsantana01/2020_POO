using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, md, nota;
            Console.WriteLine("Digite as notas do três primeiros bimestres:");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            md = (n1 * 2 + n2 * 2 + n3 * 3) / 10;
            nota = ((60 - md) * 10) / 3;
            if (nota < 0)
            {
                nota = 0;
            }
            Console.WriteLine($"Nota para passar = {nota}");
        }
    }
}

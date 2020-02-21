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
            int n1, n2, media;
            Console.WriteLine("Digite as notas dos dois bimestres da disciplina:");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            media = ((n1 * 2) + (n2 * 3)) / 5;
            Console.WriteLine($"Média parcial = {media}");
        }
    }
}

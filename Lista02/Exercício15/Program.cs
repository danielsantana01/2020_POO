using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três valores:");
            List<int> lista = new List<int>();
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            lista.Add(n1);
            lista.Add(n2);
            lista.Add(n3);
            lista.Sort();
            Console.WriteLine($"{lista[0]}, {lista[1]}, {lista[2]}");
        }
    }
}

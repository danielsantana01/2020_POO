using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            string[] entry = Console.ReadLine().Split();
            for (int i = 0; i <= 9; i++)
            {
                lista.Add(int.Parse(entry[i]));
            }
            lista.Sort();
            Console.WriteLine($"O maior valor é {lista[9]} e o menor é {lista[0]}");
        }
    }
}

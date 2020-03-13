using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe quatro valores inteiros diferentes");
            List<int> lista = new List<int>();
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            lista.Add(n1);
            lista.Add(n2);
            lista.Add(n3);
            lista.Add(n4);
            lista.Sort();
            Console.WriteLine("Resultado");
            Console.WriteLine($"A soma dos dois menores valores é {lista[0] + lista[1]}");
        }
    }
}

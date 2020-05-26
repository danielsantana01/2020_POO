using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício05
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 10;   
            Console.WriteLine("Informe o dia da semana");
            string dia = Console.ReadLine();
            Console.WriteLine("Informe a hora inicial do filme");
            int hora = int.Parse(Console.ReadLine());
            if (dia.Equals("Segunda") || dia.Equals("Terça") || dia.Equals("Quarta")) valor = valor - 2;
            else if (dia.Equals("Sexta") || dia.Equals("Sábado")) valor = valor + 5;
            if (hora <= 16) valor = valor - 2;
            Console.WriteLine($"O valor da entrada é R$ {valor:0.00}");
        }
    }
}

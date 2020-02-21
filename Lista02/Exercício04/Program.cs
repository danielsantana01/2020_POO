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
            Console.WriteLine("Digite o primeiro horário no formato hh:mm");
            string[] h1 = Console.ReadLine().Split(":");
            int horas1 = int.Parse(h1[0]);
            int minutos1 = int.Parse(h1[1]);
            Console.WriteLine("Digite o segundo horário no formato hh:mm");
            string[] h2 = Console.ReadLine().Split(":");
            int horas2 = int.Parse(h2[0]);
            int minutos2 = int.Parse(h2[1]);
            int horas_final = horas1 + horas2;
            if (horas_final >= 24)
            {
                horas_final = horas_final - 24;
            }
            int minutos_final = minutos1 + minutos2;
            if (minutos_final >= 60)
            {
                minutos_final = minutos_final - 60;
                horas_final = horas_final + 1;
            }
            Console.WriteLine("Total de horas = {horas_final}:{minutos_final}");
        }
    }
}

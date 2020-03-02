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
            Console.WriteLine("Digite o horário no formato hh:mm");
            string[] time = Console.ReadLine().Split(':');
            double horas = double.Parse(time[0]);
            double minutos = double.Parse(time[1]);
            double graus = 0;
            if (horas < 24 && minutos < 60)
            {
                if (horas != 12 && minutos != 0)
                {
                    graus = Math.Abs(((horas * 60 + minutos) / 60) - ((minutos / 60) * 12));
                    graus = (360 * graus) / 12;
                }
                Console.WriteLine($"Menor ângulo entre os ponteiros = {graus} graus");
            }
            else
            {
                Console.WriteLine("Hora Inválida");
            }
            Console.ReadKey();
        }
    }
}

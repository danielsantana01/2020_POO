using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um horário");
            string[] time = Console.ReadLine().Split(':');
            int h = int.Parse(time[0]);
            int m = int.Parse(time[1]);
            if (h <= 23 && m <= 59) Console.WriteLine("O horário informado é válido");
            else Console.WriteLine("O horário informado não é válido");
        }
    }
}

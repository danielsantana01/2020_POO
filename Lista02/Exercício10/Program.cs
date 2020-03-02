using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma data no formato dd/mm/aa");
            string[] lista = Console.ReadLine().Split('/');
            int dias = int.Parse(lista[0]);
            int meses = int.Parse(lista[1]);
            int anos = int.Parse(lista[2]);
            if (anos > 1900 && anos < 2100)
            {
                if ((meses == 1 || meses == 3 || meses == 5 || meses == 7 || meses == 8 || meses == 10 || meses == 12) && dias <= 31)
                {
                    Console.WriteLine("Esta data é válida");
                }
                else if ((meses == 4 || meses == 6 || meses == 9 || meses == 11) && dias <= 30)
                {
                    Console.WriteLine("Esta data é válida");
                }
                else if (meses == 2)
                {
                    if ((anos % 4) == 0 && (anos % 100) != 0 && dias <= 29)
                    {
                        Console.WriteLine("Esta data é válida");
                    }
                    else if ((anos % 400) == 0 && dias <= 29)
                    {
                        Console.WriteLine("Esta data é válida");
                    }
                    else if (dias <= 28)
                    {
                        Console.WriteLine("Esta data é válida");
                    }
                    else
                    {
                        Console.WriteLine("Esta data não é válida");
                    }
                }
                else
                {
                    Console.WriteLine("Esta data não é váida");
                }
            }
            else
            {
                Console.WriteLine("Esta data não é váida");
            }
            Console.ReadKey();
        }
    }
}

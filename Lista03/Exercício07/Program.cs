using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a data do aniversário");
            string[] data = Console.ReadLine().Split('/');
            int d = int.Parse(data[0]);
            int m = int.Parse(data[1]);
            if ((m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12) && d <= 31) Console.WriteLine("A data informada é válida");
            else if ((m == 4 || m == 6 || m == 9 || m == 11) && d <= 30) Console.WriteLine("A data informada é válida");
            else if (m == 2 && d <= 29) Console.WriteLine("A data informada é válida");
            else Console.WriteLine("A data informada não é válida");
            Console.ReadKey();
        }
    }
}

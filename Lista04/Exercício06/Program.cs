using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício06
{
    class Program
    {
        static void Main(string[] args)
        {
            string maior = " ";
            Console.WriteLine("Informe o primeiro horário");
            string h1 = Console.ReadLine();
            string[] l1 = h1.Split(' ', ':');
            Console.WriteLine("Informe o segundo horário");
            string h2 = Console.ReadLine();
            string[] l2 = h2.Split(' ', ':');
            if (l1[2].Equals("AM") && l2[2].Equals("PM")) maior = h2;
            else if (l1[2].Equals("PM") && l2[2].Equals("AM")) maior = h1;
            else
            {
                if (double.Parse(l1[0]) + double.Parse(l1[1]) / 60 > double.Parse(l2[0]) + double.Parse(l2[1]) / 60) maior = h1;
                else if (double.Parse(l1[0]) + double.Parse(l1[1]) / 60 < double.Parse(l2[0]) + double.Parse(l2[1]) / 60) maior = h2;
            }
            Console.WriteLine($"O maior horário é {maior}");
        }
    }
}

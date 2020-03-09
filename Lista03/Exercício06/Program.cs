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
            string maior;
            Console.WriteLine("Informe o primeiro horário");
            string h1 = Console.ReadLine();
            string[] l1 = h1.Split();
            Console.WriteLine("Informe o segundo horário");
            string h2 = Console.ReadLine();
            string[] l2 = Console.ReadLine().Split();
            if (l1[1].Equals("AM") && l2[1].Equals("PM")) maior = h2;
            else if (l1[1].Equals("PM") && l2[1].Equals("AM")) maior = h1;
            else
            {
               
            }
        }
    }
}

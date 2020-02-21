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
            Console.WriteLine("Digite sua data de nascimento:");
            string data = Console.ReadLine();
            int ano = int.Parse(data.Substring(6));
            Console.WriteLine($"Em 31/12/2019 você terá {2019 - ano} anos");
        }
    }
}

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
            int s1 = 0;
            int s2 = 0;
            Console.WriteLine("Informe o nome da primeira pessoa");
            string n1 = Console.ReadLine();
            Console.WriteLine("Informe a data de nascimento");
            string[] d1 = Console.ReadLine().Split('/');
            s1 = int.Parse(d1[0]) + int.Parse(d1[1]) + int.Parse(d1[2]);
            Console.WriteLine("Informe o nome da segunda pessoa");
            string n2 = Console.ReadLine();
            Console.WriteLine("Informe a data de nascimento");
            string[] d2 = Console.ReadLine().Split('/');
            s2 = int.Parse(d2[0]) + int.Parse(d2[1]) + int.Parse(d2[2]);
            if (s1 < s2) Console.WriteLine($"{n1} é mais velho(a) que {n2}");
            else if (s2 < s1) Console.WriteLine($"{n2} é mais velho(a) que {n1}");
            else Console.WriteLine("As idades são iguais");
        }
    }
}

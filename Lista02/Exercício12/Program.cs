using System;

namespace Exercício12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois valores inteiros separados por um operador +, -, * ou /");
            string entry = Console.ReadLine();
            string[] list;
            int n1 = 0;
            int n2 = 0;
            int op = 0;
            int saida = 0;
            for (int i = 0; i < entry.Length; i++)
            {
                if (entry[i] == '+')
                {
                    list = entry.Split('+');
                    n1 = int.Parse(list[0]);
                    n2 = int.Parse(list[1]);
                    saida = n1 + n2;
                }
                else if (entry[i] == '-')
                {
                    list = entry.Split('-');
                    n1 = int.Parse(list[0]);
                    n2 = int.Parse(list[1]);
                    saida = n1 - n2;
                }
                else if (entry[i] == '*')
                {
                    list = entry.Split('*');
                    n1 = int.Parse(list[0]);
                    n2 = int.Parse(list[1]);
                    saida = n1 * n2;
                }
                else if (entry[i] == '/')
                {
                    list = entry.Split('/');
                    n1 = int.Parse(list[0]);
                    n2 = int.Parse(list[1]);
                    saida = n1 / n2;
                }
            }
            Console.WriteLine(saida);
        }
    }
}

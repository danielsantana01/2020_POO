using System;

namespace Exercício11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma data nbo formato dd/mm/aaaa");
            string[] lista = Console.ReadLine().Split('/');
            string d = lista[0];
            string m = lista[1];
            string a = lista[2];
            switch (m)
            {
                case "01":
                    m = "janeiro";
                    break;
                case "02":
                    m = "fevereiro";
                    break;
                case "03":
                    m = "março";
                    break;
                case "04":
                    m = "abril";
                    break;
                case "05":
                    m = "maio";
                    break;
                case "06":
                    m = "junho";
                    break;
                case "07":
                    m = "julho";
                    break;
                case "08":
                    m = "agosto";
                    break;
                case "09":
                    m = "setembro";
                    break;
                case "10":
                    m = "outubro";
                    break;
                case "11":
                    m = "novembro";
                    break;
                case "12":
                    m = "dezembro";
                    break;
            }
            Console.WriteLine($"A data é {d} de {m} de {a}");
            Console.ReadKey();
        }
    }
}
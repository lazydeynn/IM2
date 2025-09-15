using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolarToPesoAndYen
{
    class Program
    {

        static double dollarToPeso(double dollar)
        {
            return dollar * 57.17;
        }

        static double dollarToYen(double dollar)
        {
            return dollar * 146.67;
        }

        static void Main(string[] args)
        {

            Console.Write("Enter currency in ($): ");
            var inp = Console.ReadLine().Trim().Split(',');

            List<double> dollar = new List<double>();

            for(int i = 0; i < inp.Length; i++)
            {
                try
                {
                    dollar.Add(double.Parse(inp[i]));
                }
                catch (FormatException)
                {
                    continue;
                }
            }

            if (dollar.Count == 0)
            {
                Console.WriteLine("Invalid input, try again.");
            }
            else
            {
                Console.WriteLine($"\n{"Dollar($)",-12}{"Peso(P)",-12}{"Yen(¥)",-12}");
                for (int i = 0; i < dollar.Count; i++)
                {
                    Console.WriteLine($"{dollar[i],-12}{dollarToPeso(dollar[i]),-12}{dollarToYen(dollar[i]),-12}");
                }
            }

            Console.ReadKey();
        }
    }
}

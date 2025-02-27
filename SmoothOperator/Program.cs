using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //WriteLine = print
            //ReadLine = user input
            Console.WriteLine("Insere número inteiro:");
            string number = Console.ReadLine();
            sbyte saved_number = sbyte.Parse(number);
            --saved_number;
            Console.WriteLine($"{saved_number}");
            ++saved_number;
            Console.WriteLine($"{saved_number}");
        }
    }
}

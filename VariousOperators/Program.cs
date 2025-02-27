using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insere número inteiro-não negativo:");
            string number = Console.ReadLine();
            byte saved_number = byte.Parse(number);
            Console.WriteLine($"{saved_number/2}");
            Console.WriteLine($"{saved_number<<3}");
            Console.WriteLine($"{saved_number^6}");
            Console.WriteLine($"{saved_number>10}");
        }
    }
}

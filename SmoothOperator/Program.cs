using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insere número inteiro:");
            string number = Console.ReadLine();
            sbyte saved_number = sbyte.Parse(number);
            saved_number = saved_number++;
            Console.ReadLine ($"{saved_number}");
            saved_number = saved_number--;
            Console.ReadLine ($"{saved_number}");
        }
    }
}

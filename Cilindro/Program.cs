using System;
using System.Collections;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Qual é a altura do cilindro?");
            string altura = Console.ReadLine();
            Console.WriteLine("Qual é o raio do cilindro?");
            string raio = Console.ReadLine();

            double real_altura = double.Parse(altura);
            double real_raio = double.Parse(raio);

            double volume = MathF.PI*real_raio*real_raio*real_altura;
            Console.WriteLine($"{volume:f3}");
            double area = 2*MathF.PI*real_raio*(real_raio+real_altura)
            Console.WriteLine($"{area:f3}");
        }
    }
}

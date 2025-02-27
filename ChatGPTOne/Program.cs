using System;
using System.Net;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Colocar questão ao utilizador
            while (question != "Exit")
            question = Console.ReadLine();

            // Verificar se se trata de uma questão conhecida e determinar uma
            // resposta adequada
            Console.Write("Place your question? ");
            {
                if (question == "Who Coded you?")
                {
                    response = "Catiamn";
                    continue;
                }
                else if (question == "Where are you?")
                {
                    response = "At the center of the universe, at a point where everything is equally close by and everything is equally far away.";
                    continue;
                }
                else if (question == "What's your favorite color?")
                {
                    response = "Turquoise, not cyan!";
                    continue;
                }
                else if (question == "How are you?")
                {
                    response = "A little bored of all these questions";
                    continue;
                }
            else if (question != "EXIT")
            {
                response = "My programmer doesn't have an answer for that yet";
                continue;
            }
            // Responder adequadamente
            Console.WriteLine(response);
        }
    }
}

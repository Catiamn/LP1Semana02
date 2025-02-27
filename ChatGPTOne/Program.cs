using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Colocar questão ao utilizador
            Console.Write("Place your question? ");
            question = Console.ReadLine();

            // Verificar se se trata de uma questão conhecida e determinar uma
            // resposta adequada
            switch (question)
            {
                case "Who Coded you?":
                    response = "Catiamn";
                    break;
                case "Where are you?":
                    response = "At the center of the universe, at a point where everything is equally close by and everything is equally far away.";
                    break;
                case "What's your favorite color?":
                    response = "Turquoise, not cyan!";
                    break;
                case "How are you?":
                    response = "A little bored of all these questions";
                    break;
                default:
                    response = "My programmer hasn't coded and answer for that yet";
                    break;
            }

            // Responder adequadamente
            Console.WriteLine(response);
        }
    }
}

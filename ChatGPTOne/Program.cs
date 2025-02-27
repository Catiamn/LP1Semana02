using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string question, response;
            question = "";
            response = "My programmer doesn't have an answer for that yet";
            // Colocar questão ao utilizador
            while (question != "EXIT")
            {
                Console.Write("Place your question? ");
                question = Console.ReadLine();
            // Verificar se se trata de uma questão conhecida e determinar uma
            // resposta adequada
                {
                    if (question == "Who Coded you?")
                    {
                        response = "Catiamn";
                
                    }
                    else if (question == "Where are you?")
                    {
                        response = "At the center of the universe, at a point where everything is equally close by and everything is equally far away.";
                    
                    }
                    else if (question == "What's your favorite color?")
                    {
                        response = "Turquoise, not cyan!";
                    
                    }
                    else if (question == "How are you?")
                    {
                        response = "A little bored of all these questions";
                    
                    }
                    else if (question == "EXIT")
                    {
                        response = "";
                    }
                    // Responder adequadamente
                Console.WriteLine(response);
                }
            }
        }
    }
}


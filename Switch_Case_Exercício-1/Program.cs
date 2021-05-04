using System;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine().ToLower();                       
            string letra = nome.Substring(0, 1);

            switch (letra)
            {
                case "a":
                Console.WriteLine("Seu nome começa com a letra " + letra + " de amor");
                    break;
                case "e":
                Console.WriteLine("Seu nome começa com a letra " + letra + " de escola");
                    break;
                case "i":
                Console.WriteLine("Seu nome começa com a letra " + letra + " de igreja");
                    break;
                case "o":
                Console.WriteLine("Seu nome começa com a letra " + letra + " de ovo");
                    break;
                case "u":
                Console.WriteLine("Seu nome começa com a letra " + letra + " de uva");
                    break;
                default:
                Console.WriteLine("Seu nome não começa com uma vogal");
                    break;
            }
            
        }
    }
}

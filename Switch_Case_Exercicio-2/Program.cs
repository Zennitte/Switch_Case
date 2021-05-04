using System;

namespace Switch_Case_Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um algarismo romano de 1 a 10");
            string numeroRomano = Console.ReadLine().ToUpper();

            switch (numeroRomano)
            {
                case "I":
                Console.WriteLine("Seu número romano em arábico é igual 1");
                    break;
                case "II":
                Console.WriteLine("Seu número romano em arábico é igual 2");
                    break;
                case "III":
                Console.WriteLine("Seu número romano em arábico é igual 3");
                    break;
                case "IV":
                Console.WriteLine("Seu número romano em arábico é igual 4");
                    break;
                case "V":
                Console.WriteLine("Seu número romano em arábico é igual 5");
                    break;
                case "VI":
                Console.WriteLine("Seu número romano em arábico é igual 6");
                    break;
                case "VII":
                Console.WriteLine("Seu número romano em arábico é igual 7");
                    break;
                case "VIII":
                Console.WriteLine("Seu número romano em arábico é igual 8");
                    break;
                case "IX":
                Console.WriteLine("Seu número romano em arábico é igual 9");
                    break;
                case "X":
                Console.WriteLine("Seu número romano em arábico é igual 10");
                    break;
                default:
                Console.WriteLine("Reinicie o algoritimo e digite um número válido");
                    break;
            }
            
        }
    }
}

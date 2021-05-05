using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool notaCorreta = false;


            while (notaCorreta == false)
            {
                Console.WriteLine("Escreva uma nota de 0 a 10: ");
                int nota = int.Parse(Console.ReadLine());

                if (nota <= 10)
                {
                    Console.WriteLine("Sua nota é válida! Boa");
                    notaCorreta = true;
                }
                else
                {
                    Console.WriteLine("Sua nota é inválida, tente novamente.");
                }
            }

        }
    }
}

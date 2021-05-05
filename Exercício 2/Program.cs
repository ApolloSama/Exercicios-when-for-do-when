using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool senhaCerta = false;
            string nome;
            string senha;

            while (senhaCerta == false)
            {
                Console.WriteLine("Digite um nome:\n");
                nome = Console.ReadLine();

                Console.WriteLine("Digite uma senha\n");
                senha = Console.ReadLine();

                if (senha != nome)
                {
                    Console.WriteLine("Cadstro completo!");
                    senhaCerta = true;
                }

                else
                {
                    Console.WriteLine("Sua senha é igual ao seu nome, coloque outra senha");
                }
            }
        }
    }
}
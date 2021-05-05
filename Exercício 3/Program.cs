using System;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool programaCerto = false;
            string nome;
            int idade = 0;
            int salario = 0;
            string estadoCivil;

            while (programaCerto == false)
            {
                Console.WriteLine("Digite o seu nome");
                nome = Console.ReadLine();

                Console.WriteLine("Digite a sua idade");
                idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o seu salário");
                salario = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o seu Estado Civil");
                estadoCivil = Console.ReadLine();

                if (nome == "")
                {
                    Console.WriteLine("Seu nome é inválido ou nulo, digite novamente");
                }

                if (idade > 150)
                {
                    Console.WriteLine("Você é algum parente de Moisés, tente novamente");
                }

                if (idade < 0)
                {
                    Console.WriteLine("Você não nasceu ainda, aguarde uns anos");
                }

                if (salario < 0)
                {
                    Console.WriteLine("Seu salário é menor que 0, tá tenso");
                }

                if (estadoCivil == "s")
                {
                    Console.WriteLine("Solteiro(a)");
                }

                else if (estadoCivil == "c")
                {
                    Console.WriteLine("Casado(a)");
                }

                else if (estadoCivil == "v")
                {
                    Console.WriteLine("Viúvo(a)");
                }

                else if (estadoCivil == "d")
                {
                    Console.WriteLine("Divorciado(a)");
                }

                else
                {
                    Console.WriteLine("Você digitou a uma letra errada, tente novamente");
                }

                programaCerto = true;
            }
        }
    }
}

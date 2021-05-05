using System;

namespace Desafio_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num0 = 0;
            int num1 = 1;
            int counter = 14;

            for (int i = 0; i < counter; i++)
            {
                int temp = num0;
                num0 = num1;
                num1 = temp + num1;
                Console.WriteLine(num0 + "");
            }
        }
    }
}

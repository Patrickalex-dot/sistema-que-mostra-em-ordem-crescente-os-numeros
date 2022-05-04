using System;

namespace sistema_que_mostra_em_ordem_crescente_os_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num1;
            decimal num2;
            decimal num3;

            Console.WriteLine("Digite o primeiro numero");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero");
            num2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o terceiro numero");
            num3 = Convert.ToDecimal(Console.ReadLine());


            if (num1 <= num2 && num2 <= num3)
            {
                Console.WriteLine($"{num3},{num2},{num1}");
            }
            else if (num2 <= num3 && num3 <= num1)
            {
                Console.WriteLine($"{num1},{num3},{num2}");
            }
            else if (num3 <= num1 && num1 <= num2)
            {
                Console.WriteLine($"{num2},{num1},{num3}");
            }
            else if (num3 <= num2 && num2 <= num1)
            {
                Console.WriteLine($"{num1},{num2},{num3}");
            }
            else if (num1 <= num3 && num3 <= num2)
            {
                Console.WriteLine($"{num2},{num3},{num1}");
            }
            else if (num2 <=num1 && num1 <= num3)
            {
                Console.WriteLine($"{num2},{num1},{num3}");
            }
        }
    }
}

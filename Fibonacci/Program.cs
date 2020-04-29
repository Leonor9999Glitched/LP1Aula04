using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variáveis
            string aux;
            int input, fibo;

            //Obter input e coverter
            aux = Console.ReadLine();
            input = int.Parse(aux);

            //Chamar o método Fibonacci e guardar o valor do returno
            fibo = Fibonacci(input);

            //Mostrar o valor
            Console.WriteLine(fibo);
        }

        static int Fibonacci(int n)
        {
            int fib;
            
            if (n <= 2)
            {
                fib = 1;
            }
            else
            {
                fib = Fibonacci(n - 1) + Fibonacci(n - 2);
            }

            return fib;
        }
    }
}

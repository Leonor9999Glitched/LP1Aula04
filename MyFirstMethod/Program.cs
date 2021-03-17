using System;

namespace MyFirstMethod
{
    class Program
    {

        /// <summary>
        /// Prints numbers from 1 to 10
        /// </summary>
        static void CountTo10()
        {
            for (int i = 1 ; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            CountToN(3);
            CountTo10();
        }

        /// <summary>
        /// Prints numbers from n1 to n1
        /// </summary>
        /// <param name="n1">valor minimo</param>
        /// <param name="n2">valor maximo</param>
        static void CountToN(int n1, int n2);
        {
            for (int i = n1 ; i <= n2; i++)
            {
                Console.WriteLine(i);
            }
        }
    }    
}

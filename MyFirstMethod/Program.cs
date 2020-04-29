using System;

namespace MyFirstMethod
{
    class Program
    {

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

        static void CountToN(int n1, int n2);
        {
            for (int i = n1 ; i <= n2; i++)
            {
                Console.WriteLine(i);
            }
        }
    }    
}

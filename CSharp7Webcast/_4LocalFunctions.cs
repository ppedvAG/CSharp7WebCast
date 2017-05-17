using System;

namespace CSharp7Webcast
{
    internal class LocalFunctions : IExample
    {
        public void Run()
        {
            for (int i = 0; i < 100; i++)
            {
                if(IsPrime(i))
                    Console.WriteLine(i);
            }
        }

        private bool IsPrime(int value)
        {
            return isPrime(value, value - 1);


            bool isPrime(int n, int d)
            {
                if (n < 2)
                    return false;

                if (d == 1 || n == 2)
                    return true;

                if (n % d == 0)
                    return false;

                return isPrime(n, d - 1);
            }
        }
    }
}

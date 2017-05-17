using System;

namespace CSharp7Webcast
{
    internal class RefReturns : IExample
    {
        private int[] values = { 3, 8, 2, 10 };

        private ref int GetValue(int index)
        {
            return ref values[index];
        }

        public void Run()
        {
            ref var zahl = ref GetValue(1);
            ref int i = ref zahl;

            Console.WriteLine(zahl);
            zahl++;

            Console.WriteLine($"Aus dem Array: {values[1]}");
        }
    }
}

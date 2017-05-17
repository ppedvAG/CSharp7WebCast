using System;

namespace CSharp7Webcast
{
    internal class OutVariables : IExample
    {
        public void Run()
        {
            Console.Write("Please insert a Number: ");
            var input = Console.ReadLine();

            if(int.TryParse(input, out var zahl))
            {
                Console.WriteLine(zahl + 10);
            }
        }
    }
}

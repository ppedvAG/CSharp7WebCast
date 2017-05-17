using System;

namespace CSharp7Webcast
{
    class Program
    {
        static void Main(string[] args)
        {
            var examples = new IExample[]
            {
                new OutVariables(),
                new PatternMatching(),
                new Tuples(),
                new LocalFunctions(),
                new LiteralImprovements(),
                new RefReturns(),
                new MoreExpressionBodyMembers()
            };

            Console.WriteLine("0. Out variables");
            Console.WriteLine("1. Pattern matching"); 
            Console.WriteLine("2. Tuples"); 
            Console.WriteLine("3. Local functions"); 
            Console.WriteLine("4. Literal improvements"); 
            Console.WriteLine("5. Ref returns"); 
            Console.WriteLine("6. More expression body members");

            var input = Console.ReadLine();

            if (uint.TryParse(input, out var index) && index < examples.Length)
                examples[index].Run();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
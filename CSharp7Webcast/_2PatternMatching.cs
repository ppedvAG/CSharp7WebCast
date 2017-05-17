using System;

namespace CSharp7Webcast
{
    internal class PatternMatching : IExample
    {
        public void Run()
        {
            var values = new object[]
            {
                5,
                "",
                "Hallo Podcast",
                null,
                new Person { Firstname = "Stanislaus" },
                new Person { Firstname = "Cesar" }
            };

            foreach (object v in values)
            {
                #region const Pattern

                if(v is null)
                {
                    Console.WriteLine("Es war null.");
                }
                if(v is 5)
                {
                    Console.WriteLine("Es war fünf.");
                }

                #endregion
                #region type Pattern

                if(v is int i)
                {
                    Console.WriteLine(i + 8);
                }
                if(v is Person p && p.Firstname.StartsWith("S"))
                {
                }

                #endregion

                #region Switch

                switch (v)
                {
                    case int zahl:
                        Console.WriteLine(zahl + 10);
                        break;

                    case null:
                        break;

                    case Person person when person.Firstname.StartsWith("S"):
                        break;

                    case Person person:
                        break;

                    default:
                        break;
                }

                #endregion
            }
        }
    }
}

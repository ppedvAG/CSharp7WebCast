using System;

namespace CSharp7Webcast
{
    internal class LiteralImprovements : IExample
    {
        public void Run()
        {
            var million = 1_000_000;

            var binär = 0b0011_0100;

            var zahl = 1_234_567;

            var hex = 0xFF_99_AB_C3;
        }
    }

    [Flags]
    internal enum WochenTage
    {
        Montag =        0b0000_0001,
        Dienstag =      0b0000_0010,
        Mittwoch =      0b0000_0100,
        Donnerstag =    0b0000_1000,
        Freitag =       0b0001_0000,
        Samstag =       0b0010_0000,
        Sonntag =       0b0100_0000
    }
}

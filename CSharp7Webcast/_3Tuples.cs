using System;

namespace CSharp7Webcast
{
    internal class Tuples : IExample
    {
        public void Run()
        {
            #region since .NET 4.0

            var oldTuple = new Tuple<int, string>(5, "Hallo");
            Console.WriteLine($"{oldTuple.Item1} - {oldTuple.Item2}");

            #endregion

            #region seit C# 7

            var newTuple = (6, "Welt");
            Console.WriteLine($"{newTuple.Item1} - {newTuple.Item2}");

            var benennen = (Nummer: 7, Text: "Mein Text");
            Console.WriteLine($"{benennen.Nummer} - {benennen.Text}");

            (int zahl, string text) = benennen;
            Console.WriteLine($"{zahl} - {text}");

            (var z, var t) = benennen;

            var result = Tanken(650, 40, 45.68);
            Console.WriteLine($"LiterPro100KM: {result.literPro100KM} - Preis Pro KM: {result.preisProKM}");

            #endregion

            #region Deconstruction

            var car = new Car(speed: 80, color: "Red");

            (var speed, var color) = car;

            #endregion
            #region Deconstruction as Extention

            var size = new Size(100, 30);
            (int a, int b) = size;

            #endregion
        }

        private (double literPro100KM, double preisProKM) Tanken(int gefahreneKM, double getankteMenge, double preis)
        {
            var preisProKM = preis / gefahreneKM;
            var literPro100KM = getankteMenge * 100 / gefahreneKM;

            return (literPro100KM, preisProKM);
        }
    }

    internal class Car
    {
        public int Speed { get; private set; }
        public string Color { get; private set; }

        public Car(int speed, string color)
        {
            Speed = speed;
            Color = color;
        }

        public void Deconstruct(out int speed, out string color)
        {
            speed = Speed;
            color = Color;
        }
    }
    internal class Size
    {
        public Size(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; private set; }
        public int Y { get; private set; }
    }

    internal static class SizeExtentions
    {
        public static void Deconstruct(this Size size, out int x, out int y)
        {
            x = size.X;
            y = size.Y;
        }
    }
}

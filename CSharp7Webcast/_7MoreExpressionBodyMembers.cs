using System;

namespace CSharp7Webcast
{
    internal class MoreExpressionBodyMembers : IExample
    {
        public void Run()
        {
            var file = new File(@"C:\WebCast\File.txt");

            Console.WriteLine(file.GetName());
        }
    }

    internal class File
    {
        private string _path;
        public string Path
        {
            get => _path;
            set => _path = value;
        }

        // Constructor
        public File(string path) => Path = path;

        // seit C#6
        public string GetName() => Path.Substring(Path.LastIndexOf('\\') + 1);

        ~File() => Console.WriteLine("Das File wurde zerstört.");
    }
}

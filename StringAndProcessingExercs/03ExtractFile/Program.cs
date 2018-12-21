using System;

namespace _03ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] path = Console.ReadLine().Split('\\');

            string[] fileWithExt = path[path.Length - 1].Split('.');

            string fileName = fileWithExt[0];
            string fileExt = fileWithExt[1];


            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExt}");
        }
    }
}

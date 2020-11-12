using System;
using System.IO;

namespace WriteFilesAndDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            
            WriteFilePaths();
        }

        public static void WriteFilePaths()
        {
            Console.WriteLine("Good Morning!");
            string filePath = @"C:\Users\opilane\Samples\files.txt";
            string directoryPath = @"C:\Users\opilane\Samples";

            string[] files = Directory.GetFiles(directoryPath, "*.*", SearchOption.AllDirectories);

            //save to file
            File.WriteAllLines(filePath, files);
        }
    }
}

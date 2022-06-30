using System;
using System.IO;

namespace directory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (string path in args)
            {
                if (Directory.Exists(path))
                {
                    string[] fileEntries = Directory.GetDirectories(path);
                    foreach (string fileName in fileEntries)
                    {
                        Console.WriteLine(fileName);
                    }
                }
            }
        }

    }
}



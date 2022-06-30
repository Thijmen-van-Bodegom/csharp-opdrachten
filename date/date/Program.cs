
using System;

namespace date
{
    class Program
    {
        static void Main(string[] args)
        {
            string datetime = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            Console.WriteLine(datetime);
        }
    }
}
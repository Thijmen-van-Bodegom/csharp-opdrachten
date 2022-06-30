using System;

namespace ConsoleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args != null && args.Length >= 3)
            {
                int arg1 = int.Parse(args[0]);
                var arg2 = args[1];
                int arg3 = int.Parse(args[2]);
                int sum = arg1 + arg3;

                if (arg2 == "+")
                {
                    sum = arg1 + arg3;
                }
                else if (arg2 == "-")
                {
                    sum = arg1 - arg3;
                }

                else if (arg2 == "/")
                {
                    sum = arg1 / arg3;
                }

                else if (arg2 == "*")
                {
                    sum = arg1 * arg3;
                }
                Console.WriteLine(sum);
            }

            Console.ReadKey();
        }
    }
}

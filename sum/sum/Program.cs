using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args != null && args.Length >= 2)
            {
                int arg1 = int.Parse(args[0]);
                int arg2 = int.Parse(args[1]);  
                int sum = arg1 + arg2;
                Console.WriteLine(arg1 + "+" +  arg2 +  "=" + sum);
            }
        }
    }
}

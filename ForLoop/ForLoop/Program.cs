using System;

namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)

        {
            for (int outer = 0; outer <= 20; outer++)
            {
                string str = outer + ":";
                string tekst = ("");
                if (outer <= 10)
                {
                    for (int inner = 0; inner <= outer; inner++)
                    {
                        if (inner % 2 != 0)
                        {
                            tekst = (" uneven ");
                        }
                        else
                        {
                            tekst = (" even ");
                        }
                        str += tekst + "(" + inner + ")";
                    }
                }
                else
                {
                    for (int inner = 0; inner <= 20 - outer; inner++)
                    {
                        if (inner % 2 != 0)
                        {
                            tekst = (" uneven ");
                        }
                        else
                        {
                            tekst = (" even ");
                        }

                        str += tekst + "(" + inner + ")";
                    }
                }
                Console.WriteLine(str);
            }
        }
    }
}
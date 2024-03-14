using System;

namespace BetterDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print based on the different arguments
            Console.WriteLine(Decor(args[0], char.Parse(args[1]), int.Parse(args[2])));
        }

        //Set the parameters for each argument
        private static string Decor (string s, char c, int i)
        {
            string p = "";
            string d = "";

            //Specify the special character and the amount of times used
            for (int j = 1; j <= i; ++j)
            {
                d += c;
            }

            //Form of the print
            p += $"{d} {s} {d}";

            return p;
        }
    }
}

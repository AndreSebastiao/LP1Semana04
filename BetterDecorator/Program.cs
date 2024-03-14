using System;

namespace BetterDecorator
{
    /// <summary>
    /// Main class of the program
    /// Get an input of 3 parameters and print
    /// a text based on said parameters
    /// </summary>
    class Program
    {
        /// <summary>
        /// Method that prints the the text
        /// </summary>
        /// <param name="args">Arguments needed to print the text
        /// A string with "", a char with "" and and int
        /// </param>
        static void Main(string[] args)
        {
            //Check if it has enough arguments or not 
            if (args.Length != 3)
            {
                Console.WriteLine(Decor("User did not specify args!", '=', 3));
            }
            else
            {
                //Print based on the different arguments
                Console.WriteLine(Decor(args[0], char.Parse(args[1]), int.Parse(args[2])));
            }
        }

        /// <summary>
        /// Reads input and returns a string
        /// </summary>
        /// <param name="s">String provided</param>
        /// <param name="c">Special char provided</param>
        /// <param name="i">Int provided</param>
        /// <returns>A string</returns>
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

using System;
using System.Xml.XPath;

namespace Special
{
    /// <summary>
    /// Main class of the program
    /// Get an int and return another int
    /// corresponding to the number in the sequence
    /// </summary>
    class Program
    {
        /// <summary>
        /// Method that prints and reads input
        /// </summary>
        /// <param name="args">n-th number of the sequence</param>
        static void Main(string[] args)
        {
            Console.Write("Insert n-th number of the special sequence: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSpecial(n));
        }

        /// <summary>
        /// Calculates the sequence
        /// </summary>
        /// <param name="n">n-th number of the sequence</param>
        /// <returns>teh value of the n-te number</returns>
        private static int GetSpecial(int n)
        {
            int result;

            //Check if the number is one of the first two numbers of the sequence
            if (n == 0)
            {
                result = 0;
            }
            else if (n == 1)
            {
                result = 1;
            }
            else
            {
                //Equation of the sequence
                result = GetSpecial(n - 1) + (GetSpecial(n - 2) * 2);
            }

            return result;
        }
    }
}

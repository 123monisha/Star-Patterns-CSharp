using System;


namespace Patterns
{
    internal class Pascal_Triangle
    {
        static void Main(string[] args)
        {
            int rows = 5;

            for (int i = 0; i < rows; i++)
            {
                int val = 1;
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(val + " ");
                    val = val * (i - j) / (j + 1);
                }
                Console.WriteLine();
            }
        }
    }
}

using System;


namespace Patterns
{
    internal class Pyramid
    {
        static void Main(string[] args)
        {
            int n = 5;
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<n-i;j++)
                {
                    Console.Write(" ");
                }
                for(int k=0;k<2*i-1;k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
        }
    }
}

using System;

namespace testhomework
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, s;

            Console.WriteLine(" Enter the number of iterations");
            n = Convert.ToInt32(Console.ReadLine());

            for ( i = 0; i < n; i++)
            {
                  s = i + 2;
                Console.WriteLine( $"S = {s}" );
            }
            
        }

    }
}

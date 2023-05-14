using System;

namespace testhomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is bear sleeping? Press 'Y'");

            string? i = Console.ReadLine();

            if ( i == "Y")
            {
                Console.WriteLine("    ***       ***    ");
                Console.WriteLine("   ***************   ");
                Console.WriteLine("   ***************   ");
                Console.WriteLine("    ***_*****_***    ");
                Console.WriteLine("     ****<+>****     ");
                Console.WriteLine(" **  *****=*****  ** ");
                Console.WriteLine("****  *********  ****");
                Console.WriteLine("****   *******   ****");
            }
            else 
            {
                Console.WriteLine("    ***       ***    ");
                Console.WriteLine("   ***************   ");
                Console.WriteLine("   ***************   ");
                Console.WriteLine("    ***O*****O***    ");
                Console.WriteLine("     ****<+>****     ");
                Console.WriteLine(" **  *****U*****  ** ");
                Console.WriteLine("****  *********  ****");
                Console.WriteLine("****   *******   ****");
            }
            
        }
    }
}


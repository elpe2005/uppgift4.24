using System;
namespace uppgift424
{   
    class program
    {
        static void Main(string[]args)
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0 && i % 5 != 0)
                {
                    Console.WriteLine("buzz");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

using System.Diagnostics;
using System;
namespace fizzbuzz
{
    public class fizzyElse
    {
        public static void Else(int count)
        {
            for (int i = 0; i < count; i++)
            {
                if ((i % 15) == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if ((i % 3) == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if ((i % 5) == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);

                }
            }
        }
    }
}
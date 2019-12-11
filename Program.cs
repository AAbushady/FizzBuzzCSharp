using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            const int LoopAmount = 100;

            for (int counter = 1; counter <= LoopAmount; counter++)
            {
                FizzBuzzer(counter);
            }
        }

        public static void FizzBuzzer(int counter)
        {
            if (counter % 3 == 0 && counter % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (counter % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (counter % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(counter);
            }
        }
    }
}

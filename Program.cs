using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            const int LoopAmount = 100;

            for (int cnt = 1; cnt <= LoopAmount; cnt++)
            {
                FizzBuzzer(cnt);
            }
        }

        public static void FizzBuzzer(int cnt)
        {
            if (cnt % 3 == 0 && cnt % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (cnt % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (cnt % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(cnt);
            }
        }
    }
}

using System;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, i, ctr, strtno, endno;

            Console.Write("Find the prime numbers within a range 1 to 1000 :\n");
            Console.Write("Input starting number of range: ");
            strtno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input ending number of range : ");
            endno = Convert.ToInt32(Console.ReadLine());
            Console.Write("The prime numbers between {0} and {1} are : \n", strtno, endno);

            for (num = strtno; num <= endno; num++)
            {
                ctr = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && num != 1)
                    Console.Write("{0} ", num);
            }
            Console.Write("\n");
        }
    }
}

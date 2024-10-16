using System;

namespace PrimeFactorCalculator
{
    public class Program
    {
        public static void Main(String[] args)
        {
            int num;

            //Validates the number if prime or not and loop repeats until the number is valid.
            do
            {
                Console.Write("Enter a positive integer: ");
                num = int.Parse(Console.ReadLine());
                Console.Clear();

                if (num <= 0) //Checks if it is a positive integer.
                {
                    Console.WriteLine("Please try again.");
                }
                else if (num == 1) // Checks if the number is 1.
                {
                    Console.WriteLine("Please try again.");
                    Console.WriteLine("1 has no prime factors.");
                }
                else if (primeNum(num)) //Check if its a prime number.
                {
                    Console.WriteLine("Please try again.");
                    Console.WriteLine($"{num} is a prime number. It has no prime factors.");
                }

            } while (num <= 0 || num == 1 || primeNum(num));

                Console.WriteLine($"The smallest prime factors of {num} are: ");
                PrimeFactors(num);

            //Method which validates if the number is prime or not.
            static bool primeNum(int checknum)
            {
                if (checknum == 1)
                    return false;
                if (checknum == 2)
                    return true;
                if (checknum % 2 == 0)
                    return false;

                for (int i = 3; i <= Math.Sqrt(checknum); i += 2)
                {
                    if (checknum % i == 0)
                        return false;
                }
                return true;
            }

            //Find and prints the prime factors of a number.
            static void PrimeFactors(int checknum)
            {
                for (int i = 2; i <= checknum; i++)
                {
                    while (checknum % i == 0)
                    {
                        Console.Write(i + " ");
                        checknum /= i;
                    }
                }
            }
        }
    }
}
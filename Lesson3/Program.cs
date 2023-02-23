using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class Program
    {


        static void Main()
        {
            try
            {
                Console.Write("Enter a number to check for parity: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number % 2 == 0)
                    Console.WriteLine("The number " + number + " is even");
                else
                    Console.WriteLine("The number " + number + " is odd");
            }
            catch
            {
                Console.WriteLine("I asked you to enter a number");
            }
            Console.ReadKey();
            TwentyOne();
            PrimeNumber();
            SmallestNumber();
            Game();
        }
        static void TwentyOne()
        {
            try
            {
                int sumCard = 0;
                Console.Write("Hi, enter the number of cards you have on hand: ");
                int numberCards = Convert.ToInt32(Console.ReadLine());
                for (int j = 0; j < numberCards; j++)
                {
                    Console.Write("Enter the card value: ");
                    var number = Console.ReadLine();
                    switch (number)
                    {
                        case "J": sumCard = sumCard + 10; break;
                        case "Q": sumCard = sumCard + 10; break;
                        case "K": sumCard = sumCard + 10; break;
                        case "T": sumCard = sumCard + 10; break;
                        case "2": sumCard = sumCard + 2; break;
                        case "3": sumCard = sumCard + 3; break;
                        case "4": sumCard = sumCard + 4; break;
                        case "5": sumCard = sumCard + 5; break;
                        case "6": sumCard = sumCard + 6; break;
                        case "7": sumCard = sumCard + 7; break;
                        case "8": sumCard = sumCard + 8; break;
                        case "9": sumCard = sumCard + 9; break;
                        case "10": sumCard = sumCard + 10; break;
                    }
                    Console.WriteLine(sumCard);
                }
            }
            catch
            {
                Console.WriteLine("Error: 404");
            }
            Console.ReadKey();

        }
        static void PrimeNumber()
        {


            Console.Write("Enter a number to check: ");
            int n = int.Parse(Console.ReadLine());
            bool prime = false;
            int i = 2;
            while (i <= n)
            {
                if (n % i == 0)
                    prime = true;
                else if (i > n)
                    break;
                i = i + i;
            }
            if (prime == false)
                Console.WriteLine("This is a prime number");
            else
                Console.WriteLine("This is a composite number");
            Console.ReadKey();
        }
        static void SmallestNumber()
        {
            int minNumber = int.MaxValue;
            Console.Write("Enter the length of the sequence: ");
            int length = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= length; i++)
            {
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (minNumber >= number)
                    minNumber = number;
                else continue;
                i++;
            }
            Console.Write("Minimum number is " + minNumber);
            Console.ReadKey();

        }
        static void Game()
        {
            Console.WriteLine("Enter a number:");
            int range = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int n = random.Next(0, range);

            Console.Write("Enter the guessed number: ");
            while (true)
            {
                try
                {
                    int result = int.Parse(Console.ReadLine());
                    if (result == n)
                    {
                        Console.Write("You guessed the number: " + n);
                        break;
                    }
                    else if (result > n) Console.Write("Your number is bigger: ");
                    else if (result < n) Console.Write("your number is less: ");
                }
                catch
                {
                    Console.WriteLine("Thanks for try");
                    Console.WriteLine("the hidden number" + n);
                    break;
                }


            }
            Console.ReadKey();
        }

    }
}

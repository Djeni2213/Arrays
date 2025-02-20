using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEvenElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter how many numbers you will enter: ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n]; 

            //input
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"number[{i}] = ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            //zadacha za otpechatvane na indeksite na chetnite chisla
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0 && i % 2 == 0)
                {
                    Console.WriteLine($"{numbers[i]} e na {i} poziciq");
                }
            }
        }
    }
}

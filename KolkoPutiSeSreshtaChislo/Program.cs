using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace KolkoPutiSeSreshtaChislo
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
                Console.Write($"Enter number[{i}]: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }


            //Zadacha
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentElement = numbers[i];
                byte counter = 0;
                for (int k = 0; k < numbers.Length; k++)
                {
                    if (currentElement == numbers[k])
                    {
                        counter++;
                    }
                }
                Console.WriteLine($"{currentElement} se sresta {counter} puti");
            }


            //output
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]}, ");
            }


        }
    }
}

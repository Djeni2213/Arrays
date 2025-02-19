using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaiChestoSreshtanElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            //input
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number[{i}]: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }


            //Zadacha
           
            byte maxCount = 0;
            int findMostRepetead = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentElement = numbers[i];
                byte counter = 1;
                for (int k = i + 1; k < numbers.Length; k++)
                {
                    if (currentElement == numbers[k])
                    {
                        counter++;
                    }
                }
                if (maxCount < counter)
                {
                    maxCount = counter;//novo maximalno
                    findMostRepetead = currentElement;
                }
            }
            Console.WriteLine($"Elementut {findMostRepetead} se sreshta {maxCount} puti");




            //output
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]}, ");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi n: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];//int[8];


            //input
            for (int i = 0; i < numbers.Length; i++)// i se dviji po indeksa na elementite
            {
                Console.Write($"numbers[{i}] = ");
                numbers[i] = int.Parse( Console.ReadLine() );
            }


            //3.OBRABOTKA
            long sum = 0;
            long sumEven = 0;
            for(int i = 0; i < numbers.Length;i++)
            {
                sum = sum + numbers[i];
                if ( numbers[i] % 2 == 0)
                {
                   sumEven = sumEven + numbers[i];
                }
                else
                {
                    Console.Write($"{numbers[i]}, ");
                }
            }
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Avrage = {(double)sum/numbers.Length}");
            Console.WriteLine($"Sum of EVEN numbers = {sumEven} ");

            //2. output
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]}, ");
            }

        }
    }
}

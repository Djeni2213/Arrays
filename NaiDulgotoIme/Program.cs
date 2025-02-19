using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaiDulgotoIme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // da se vuvedat imena da se otpechata dali masive e simetrichen
            Console.Write("How many names will you enter: ");
            int n = int.Parse(Console.ReadLine());

            string[] names = new string[n];


            //input
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Enter name[{i}]: ");
                names[i] = Console.ReadLine();
            }


            //Zadacha
            names[0] = "Tonya Belezireva";
            names[names.Length-1] = "Djeni Pukova";

            //sreden element 
            int avgIndeks = names.Length / 2;
            names[avgIndeks] = "Georgi Genov";


            for (int i = 0; i < avgIndeks; i++)
            {
                if (names[i] != names[names.Length - i])
                {
                    Console.WriteLine("Ne e simetrichno");
                }
            }



            //int maxNameLenght = -1000000000;
            //string naiDulgotoIme = null;
            //for (int i = 0 ; i < names.Length; i++)
            //{
            //    if (names[i].Length > maxNameLenght)
            //    {
            //        maxNameLenght = names[i].Length;
            //        naiDulgotoIme = names[i];
            //    }
            //}



            //output
            Console.WriteLine("-------------------------");
            for (int i = names.Length - 1; i >= 0; i--)
            {
                Console.Write($"{names[i]}, ");
            }
            //Console.WriteLine($"Nai-dulgoto ime e {naiDulgotoIme}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurseneNaElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Da se vuvedat n na broi IMENA ot klaviaturata
            //Da se vuvede ime za tursene
            //Proramata da proverqvq dali to e v masiva (ako e v masiva da se otpechati INDEKSA mu)(ako ne e v masiva da se otpechati Name Not Found 

            //input
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            string[] names = new string[n];

            for (int i = 0; i <= names.Length-1; i++)
            {
                Console.Write($"Enter name[{i}]: ");
                names[i] = Console.ReadLine();
            }
            

            //ZADACHA
            Console.Write("Enter the searched name: ");
            string searchName = Console.ReadLine();
            bool isFound = false;
            int counter = 0;
            for (int i = 0; i <= names.Length-1; i++)
            {
                if (searchName == names[i])
                {
                    Console.WriteLine($"{searchName} e na {i} pozisiq");
                    isFound = true;
                    counter++;
                    //break;
                }
            }
            if (isFound != true)
            {
                Console.WriteLine($"{searchName} not found");
            }
            else
            {
                Console.WriteLine($"{searchName} is found {counter} puti");
            }




            //output 
            Console.WriteLine("----------------------------------");
            for (int i = 0; i <= names.Length-1; i++) // i -> indeks
            {
                Console.WriteLine($"names[{i}] = {names[i]}");
            }

            // kolko puti se sreshta turseniq

        }
    }
}

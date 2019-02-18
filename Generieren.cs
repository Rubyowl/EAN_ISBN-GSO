using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
 
namespace ISBNGen
{
    class Generator
    {
        public static void Start()
        {

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Gray;


            int[] ISBNTemp = new int[13];
            Random rnd = new Random();
            int checkSum = 0;

            ISBNTemp[0] = 9;
            ISBNTemp[1] = 7;
            ISBNTemp[2] = rnd.Next(8, 10);
            ISBNTemp[3] = 3;
 
            Console.WriteLine("Press enter to generate an ISBN-number");
            Console.ReadLine();
           

            for (var i = 4; i < ISBNTemp.Length - 2; i++)
            {
                ISBNTemp[i] = rnd.Next(0, 10);

                if (i % 2 != 0)
                {
                    checkSum += ISBNTemp[i];
                }
                else
                {
                    checkSum += ISBNTemp[i] * 3;
                }
            }
          
            var ISBN = string.Join("", ISBNTemp);

            Console.WriteLine("The generated ISBN-number is: " + ISBN);
            Console.ReadLine();
 
            int lastNumber = (checkSum % 10);
            int Prüfziffer = 10 - lastNumber;
 
            if (Prüfziffer == 10)
            {
                Prüfziffer = 0;
            }
 
            Console.WriteLine("Your validation number is: " + checkSum);
            Console.WriteLine("Your Prüfziffer is: " + Prüfziffer);
            Console.WriteLine("Your final ISBN number is: " + ISBN + Prüfziffer);
            Console.ReadLine();
        }
    }
}
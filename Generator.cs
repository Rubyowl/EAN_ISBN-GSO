using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Generator
    {

        public static void Isbn(int anzahl)
        {

            StringBuilder sb = new StringBuilder();
            string joinedISBN;
            string[] isbnChar = new string[13];
            Random rnd = new Random();

            for (int i = 0; i < anzahl; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    isbnChar[j] = rnd.Next(0, 10).ToString();
                }

                joinedISBN = String.Join("", isbnChar);
                Console.WriteLine(joinedISBN);
                Console.WriteLine(Check.CheckISBN(joinedISBN));
            }
        }
    }
}

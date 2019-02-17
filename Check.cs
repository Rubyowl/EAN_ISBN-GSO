using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Check
    {
       public static bool CheckEAN(string ean)
        {

            char[] eanChars = ean.ToCharArray();
            var eanSumme = 0;
            if (eanChars.Length >= 13)
            {
                for (int i = 0; i < eanChars.Length - 2; i++)
                {

                    var eanStelle = (int)eanChars[i];


                    if (i > 0)
                    {

                        if (i % 1 == 0)
                        {
                            eanStelle *= 3;
                        }

                    }

                    eanStelle += eanSumme;
                }

                char[] eanSummeChars = eanSumme.ToString().ToCharArray();

                if (10 - eanSummeChars[eanSummeChars.Length - 1] == eanChars[eanChars.Length - 1])
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        
        public static bool CheckISBN(string isbn) {
            char[] isbnChars = isbn.ToCharArray();
            var isbnSumme = 0;
            var pruefziffer = 0;
            
            for (int i = 0; i <= isbnChars.Length - 2;i++ )
            {
                isbnSumme += (Int32.Parse(isbnChars[i].ToString()) * (i + 1));
            }

            char[] isbnSummeChar = isbnSumme.ToString().ToCharArray();

            if(isbnChars[isbnChars.Length-1].ToString().Equals("X")){
                pruefziffer = 10;
            }

            else
            {
               pruefziffer = Int32.Parse(isbnSummeChar[(isbnSummeChar.Length-1)].ToString());
            }

            if (isbnSumme % 11 == pruefziffer) { 
                return true; 
            }
            return false;   
        }


    }
}

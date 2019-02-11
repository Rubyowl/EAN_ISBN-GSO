using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISBN
{
    class EANCheck
    {
        static bool checkEAN(string ean)
        {

            char[] eanChars = ean.ToCharArray();
            var eanSumme = 0;

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

            string eanSummeString = eanSumme.ToString();
            char[] eanSummeChars = eanSummeString.ToCharArray();

            if (10 - eanSummeChars[eanSummeChars.Length - 1] == eanChars[eanChars.Length - 1])
            {
                return true;

            }
            else
            {
                return false;

            }


        }
    }
}

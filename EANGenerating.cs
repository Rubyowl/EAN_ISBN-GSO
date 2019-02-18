using System;

namespace ConsoleApp1
{
    class EANGenerating
    {
        public static string Start(string land)
        {
            int[] EAN = new int[13];
            int checkSum = 0, checkMod;
            Random rndInt = new Random();

            switch (land)
            {
                case "DE":
                    EAN[0] = 4;
                    EAN[1] = 0;
                    break;

                case "CH":
                    EAN[0] = 7;
                    EAN[1] = 6;
                    break;

                case "AU":
                    EAN[0] = 9;
                    EAN[1] = 0;
                    break;

                default:
                    EAN[0] = 4;
                    EAN[1] = 0;
                    break;
            }

            for (var i = 3; i < EAN.Length - 2; i++)
            {
                var x = rndInt.Next(0, 10);
                EAN[i] = x;
            }

            for (var i = 0; i < EAN.Length - 1; i++)
            {
                if (!(EAN[i] % 2 == 0))
                {
                    checkSum += EAN[i] * 3;
                }
                else
                {
                    checkSum += EAN[i];
                }
            }

            checkMod = checkSum % 10;
            EAN[12] = checkMod;

            var EANString = string.Join("", EAN);

            return EANString;
        }
    }
}

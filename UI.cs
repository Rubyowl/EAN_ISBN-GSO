using System;

namespace ConsoleApp1
{
    public class UI
    {
        public static void Banner()
        {
            Console.WriteLine("##############################");
            Console.WriteLine("#                            #");
            Console.WriteLine("#      ISBN/EAN CHECKER      #");
            Console.WriteLine("#                            #");
            Console.WriteLine("##############################"); 
        }

        public static void Menue()
        {
            Console.WriteLine("###########################################");
            Console.WriteLine("# 1. ISBN auf Korrektheit prüfen          #");
            Console.WriteLine("# 2. EAN auf Korrektheit prüfen           #");
            Console.WriteLine("# 3. ISBN generieren und in CSV schreiben #");
            Console.WriteLine("# 4. EAN generieren und in CSV schreiben  #");
            Console.WriteLine("###########################################");
        }
    }
}
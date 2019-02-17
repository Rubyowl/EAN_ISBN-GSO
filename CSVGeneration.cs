using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CSVGeneration
    {
        public static bool Start(string ISBN = "", string EAN = "")
        {
            if (ISBN == "" && EAN == "")
            {
                return false;
            }
            else
            {
                File.Delete("./output.csv");

                if (ISBN != "")
                {
                    var output = "ISBN:" + ISBN + ";";
                    File.AppendAllText("./output.csv", output);
                }

                if (EAN != "")
                {
                    var output = "EAN:" + EAN + ";";
                    File.AppendAllText("./output.csv", output);
                }

                return true;
            }
        }
    }
}

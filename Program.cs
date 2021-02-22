using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            while (true) {
                try
                {
                    Console.WriteLine("Please enter ticket number:");
                    string impData = Console.ReadLine();
                    if (impData.Length % 2 != 0) {
                        impData = '0' + impData; 
                            }

                    string leftString = impData.Substring(0, impData.Length / 2);
                    string rightString = impData.Substring(impData.Length / 2);

                    var chL = 0;
                    var chR = 0;

                    for (int i = 0; i < leftString.Length; i++)
                    {
                        chL = chL + leftString[i];
                        chR = chR + rightString[i];
                    }

                    if (chL == chR)
                    {

                        Console.WriteLine("Lucky one");
                    }
                    else { Console.WriteLine("Not lucky one"); 
                    }
                }
                catch  (IOException e)
                {
                    if (e.Source != null)
                        Console.WriteLine("IOException source: {0}", e.Source);
                    throw;

                }
            }
        }
    }
}

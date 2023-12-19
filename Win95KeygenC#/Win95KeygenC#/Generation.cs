using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Win95KeygenC_
{
    internal class Generation
    {
        const int STARTING_DAY = 1;
        const int TOTAL_DAYS_IN_YEAR = 365;
        const int MIN_N_VALUE = 0;
        const int MAX_N_VALUE = 100000;
        const int REMAINDER_DIVISOR = 7;
        const int RANDOMNUMBER_MIN = 10000;
        const int RANDOMNUMBER_MAX = 100000;


        static List<string> GeneratedKeys = new List<string>();
        static string[] PossibleYears = { "95", "96", "97", "98", "99", "00", "01", "02", "03" };
        static Random rnd = new Random();
        
        
        
        public static void GenerateKeys(int n)
        {
            for (int i = 0; i < n; i++)
            {
                string dayOfYear = rnd.Next(STARTING_DAY, TOTAL_DAYS_IN_YEAR).ToString("000");
                //Console.WriteLine(dayOfYear);

                string year = PossibleYears[rnd.Next(PossibleYears.Length)];
                //Console.WriteLine(year);

                int N = rnd.Next(MIN_N_VALUE, MAX_N_VALUE);
                int remainder = N % REMAINDER_DIVISOR;
                if (remainder != 0)
                {
                    N += REMAINDER_DIVISOR - remainder;
                };
                //Console.WriteLine(N);

                string n_segment = "00" + N.ToString("00000");
                //Console.WriteLine(n_segment);

                int randomNumber = rnd.Next(RANDOMNUMBER_MIN, RANDOMNUMBER_MAX);
                //Console.WriteLine(randomNumber);

                string generatedString = $"{dayOfYear}{year}-OEM-{n_segment}-{randomNumber}";
                GeneratedKeys.Add(generatedString);
            }
        }

        public static void PrintToConsole()
        {
            GeneratedKeys.ForEach(x => Console.WriteLine(x));
        }

        public static void WriteToFile(string fileName)
        {
            File.WriteAllLines(fileName, GeneratedKeys);
        }
            
    }
}

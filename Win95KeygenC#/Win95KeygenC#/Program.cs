using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Win95KeygenC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount of keys you want: ");
            int n = Convert.ToInt32(Console.ReadLine());

            List<string> strings = new List<string>();
            string[] years = { "95", "96", "97", "98", "99", "00", "01", "02", "03" };
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                string dayOfYear = rnd.Next(1, 366).ToString("000");
                //Console.WriteLine(dayOfYear);

                string year = years[rnd.Next(years.Length)];
                //Console.WriteLine(year);

                int N = rnd.Next(0, 100000);
                string formattedNumber = N.ToString("00000");
                int remainder = Convert.ToInt32(formattedNumber) % 7;
                if (remainder != 0)
                {
                    N += 7 - remainder;
                    formattedNumber = N.ToString("00000");
                };
                //Console.WriteLine(N);

                string n_segment = "00" + formattedNumber;
                //Console.WriteLine(n_segment);

                int randomNumber = rnd.Next(10000, 99999);
                //Console.WriteLine(randomNumber);

                string generatedString = $"{dayOfYear}{year}-OEM-{n_segment}-{randomNumber}";
                strings.Add(generatedString);
            }

            strings.ForEach(x => Console.WriteLine(x));
            File.WriteAllLines("Keys.txt", strings);


            Console.ReadKey();
        }
    }
}

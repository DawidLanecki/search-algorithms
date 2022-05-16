using SearchAlgorithms.Core.Algorithms;
using System;
using System.Collections.Generic;
using SearchAlgorithms.Core.Utils;
using SearchAlgorithms.Core.Testing.Validators;
using System.Security.Cryptography;
using SearchAlgorithms.Core.Testing.Timers;

namespace SearchAlgorithms.Core
{
    public class Program
    {
        static void Main(string[] args)
        {
            Action findingPrimeNumberAction = () => {
                PrimeNumberUtils.FindNthPrimeNumber(4500);
            };

            Action hashSearchAction = () =>
            {
                new HashSearch().Search("njkfbasbhja abbabbab", "a");
            };


            Console.WriteLine($"{new PrimeNumbersTimeMeasure(findingPrimeNumberAction).Measure()} jedn. referencyjnych");
            Console.WriteLine($"{new PrimeNumbersTimeMeasure(hashSearchAction).Measure()} jedn. referencyjnych");
            Console.ReadKey();
        }

        static string GetRandomString(int string_length)
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                var bit_count = (string_length * 6);
                var byte_count = ((bit_count + 7) / 8);
                var bytes = new byte[byte_count];
                rng.GetBytes(bytes);
                return Convert.ToBase64String(bytes);
            }
        }
    }
}

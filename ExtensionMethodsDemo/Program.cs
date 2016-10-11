using System;
using System.Collections.Generic;

namespace Treehouse.ExtensionMethodsDemo
{
    class Program
    {
        public static void Main()
        {
            var synonymsForBest = new List<string>
            {
                "best",
                "finest",
                "greatest",
                "top",
                "foremost",
                "leading",
                "most excellent",
                "preeminent",
                "premier",
                "chief",
                "supreme",
                "unrivaled",
                "ultimate",
                "perfect",
                "incomparable",
                "ideal"
            };

            Console.WriteLine($"My dog Jojo is the {GetRandomItem(synonymsForBest)} dog!");
            Console.ReadLine();
        }

        private static string GetRandomItem(List<string> list)
        {
            var random = new Random();
            return list[random.Next(0, list.Count)];
        }
    }
}

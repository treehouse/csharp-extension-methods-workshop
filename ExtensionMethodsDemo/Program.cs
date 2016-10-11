using System;
using System.Collections.Generic;
using Treehouse.Collections.Generic;
using Treehouse.Common;

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

            var best = synonymsForBest.FirstOr(s => s.Length.IsEven(), synonymsForBest.RandomItem);

            Console.WriteLine($"My dog Jojo is the {best} dog!");
            Console.ReadLine();
        }
    }
}

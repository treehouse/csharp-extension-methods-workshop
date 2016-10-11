﻿using System;
using System.Collections.Generic;
using Treehouse.Collections.Generic;

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

            Console.WriteLine($"My dog Jojo is the {synonymsForBest.RandomItem()} dog!");
            Console.ReadLine();
        }
    }
}

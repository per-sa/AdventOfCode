using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System;

namespace AdventOfCode.solutions.day01
{

    internal sealed class Solution
    {

        static void Main()
        {

            List<int> calories = new() { 0 };
            using StreamReader reader = new(@"C:\Users\persa\Desktop\AdventOfCode\solutions\day01\input.txt", Encoding.UTF8);

            while (!reader.EndOfStream)
            {
                string? line = reader.ReadLine();
                if (string.IsNullOrWhiteSpace(line))
                {
                    calories.Add(0);
                    continue;
                }

                _ = int.TryParse(line, out int calorie);
                calories[^1] += calorie;

            }

            // Part 1
            Console.WriteLine(calories.Max());

            // Part 2
            Console.WriteLine(calories.OrderByDescending(x => x).Take(3).Sum());

        }

    }

}
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System;

namespace AdventOfCode.solutions.day01
{

    internal sealed class Solution02
    {


        static void day02(string[] args)
        {

            string file = @"input.txt";

            string[] readFile = File.ReadAllLines(file);

            int score1 = 0;
            int score2 = 0;


            foreach (string line in readFile)
            {
                Console.WriteLine(line.Substring(0, 1) + " - " + line.Substring(2, 1));

                char opponentChoice = line.Substring(0, 1)[0];
                char myChoice = line.Substring(2, 1)[0];

                // PART 1

                switch (myChoice)
                {
                    case 'X': score1 += 1; break;
                    case 'Y': score1 += 2; break;
                    case 'Z': score1 += 3; break;
                }

                if ((myChoice == 'X' && opponentChoice == 'A') || (myChoice == 'Y' && opponentChoice == 'B') || (myChoice == 'Z' && opponentChoice == 'C'))
                {

                    score1 += 3;

                }
                else if ((myChoice == 'X' && opponentChoice == 'C') || (myChoice == 'Y' && opponentChoice == 'A') || (myChoice == 'Z' && opponentChoice == 'B'))
                {

                    score1 += 6;

                }
                else if ((myChoice == 'X' && opponentChoice == 'B') || (myChoice == 'Y' && opponentChoice == 'C') || (myChoice == 'Z' && opponentChoice == 'A'))
                {

                    score1 += 0;

                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Score: " + score1);
                Console.ResetColor();

                switch (myChoice)
                {

                    case 'X':

                        switch (opponentChoice)
                        {

                            case 'A': score2 += 3; break;
                            case 'B': score2 += 1; break;
                            case 'C': score2 += 2; break;

                        }

                        break;

                    case 'Y':

                        score2 += 3;

                        switch (opponentChoice)
                        {

                            case 'A': score2 += 1; break;
                            case 'B': score2 += 2; break;
                            case 'C': score2 += 3; break;

                        }

                        break;

                    case 'Z':

                        score2 += 6;

                        switch (opponentChoice)
                        {

                            case 'A': score2 += 2; break;
                            case 'B': score2 += 3; break;
                            case 'C': score2 += 1; break;

                        }

                        break;

                }

            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nPart 1 score: {score1}");
            Console.WriteLine($"Part 2 score: {score2}");
            Console.ResetColor();

        }


    }

}
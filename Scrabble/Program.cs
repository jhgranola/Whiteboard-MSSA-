using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Scrabble
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter your word: ");
                string input = Console.ReadLine();
                Console.WriteLine(WordScore(input));
            }
        }
        private static readonly Dictionary<char, int> ScrabbleScore = new Dictionary<char, int>
        {
            {'A',1},{'E',1},{'I',1},{'O',1},{'U',1},{'L',1},{'N',1},{'R',1},{'S',1},{'T',1},

            {'D',2},{'G',2},

            {'B',3},{'C',3},{'M',3},{'P',3},

            {'F',4},{'H',4},{'V',4},{'W',4},{'Y',4},

            {'K',5},

            {'J',8},{'X',8},

            {'Q',10},{'Z',10}
        };
        public static int WordScore(string input)
        {
            input = input.ToUpper();
            int totalScore = 0;
            foreach (char letter in input)
            {
                if (Char.IsLetter(letter))
                {
                    totalScore += ScrabbleScore[letter];
                }
            }
            return totalScore;
        }
    }
}
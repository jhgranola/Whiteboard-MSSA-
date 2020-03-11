using System;

// Given a string, count the number of words excluding the words that contain special characters. Punctuation is included as special characters.

namespace WordCountNoSpec
{
    class Program
    {
        public static int GetWordCount(string input)
        {
            bool isWord = true;
            int wordCount = 0;
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }
            if (input.Length > 999)
            {
                return -1;
            }
            input = input.ToLower();
            string[] words = input.Split(" "); // Avoid using split. Use space as a token to separate words. Possible to use an if loop in order to determine if a space
            // Creating an array and iterating through it is far more costly and intense
            foreach (string word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if ((word[i] >= 'a' && word[i] <= 'z'))
                    {
                        continue;
                    }
                    isWord = false;
                }
                if (isWord)
                {
                    wordCount++;
                }
                isWord = true;
            }

            return wordCount;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetWordCount("Hello my name is bob")); // Should return 5
            Console.WriteLine(GetWordCount("D@nny is my b3$t frien&")); // Should return 2
            Console.WriteLine(GetWordCount("Joshua isn't my favorite brother")); // Should return 4
        }
    }
}

using System;

// Create a method that counts the number of words in a string containing spaces.

namespace CountWords
{
    public class Class1
    {
        public static int GetWordCount(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }
            if (input.Length > 200)
            {
                return -1;
            }
            bool isWord = false;
            int wordCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Equals(" "))
                {
                    if (isWord)
                    {
                        wordCount++;
                        isWord = false;
                    }
                }
                else
                {
                    isWord = true;
                }
            }
            if (isWord)
            {
                wordCount++;
            }
            return wordCount;
        }
    }
}

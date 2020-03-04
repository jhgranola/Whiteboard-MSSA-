using System;

//     Given a string, return all characters in alphabetical order, ignoring case, punctuation and spaces.
//      Example: Given "Hello World!" - Return: "dehlorw"

namespace ReturnStringAlphabetical
{
    class Program
    {
        public static string Alpbabetize(string input)
        {
            input = input.ToLower();
            string result = "";
            for (int i = 'a'; i <= 'z'; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == i)
                    {
                        result += (char)i;      // I used a cast here however, to ensure you are returning characters, you can also write - result += input[j];
                        break;
                    }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ReturnStringAlphabetical.Program.Main");
            Console.WriteLine(Alpbabetize("Hello World!"));
        }
    }
}

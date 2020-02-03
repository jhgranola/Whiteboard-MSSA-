using System;

namespace WhiteboardPractice1
{
    public class Program
    {
        public static string GetReverse(string input)
        {
            string output = "";
            for (int i = 1; i <= input.Length; i++)
            {
                output += input[input.Length - i];
            }
            return output;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("WhiteboardInClass.Program.Main()");
            string testString = "I like dogs";
            Console.WriteLine(GetReverse(testString));
        }

    }
}

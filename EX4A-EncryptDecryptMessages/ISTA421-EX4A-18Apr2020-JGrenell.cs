using System;

namespace EX4A_EncryptDecryptMessages
{
    class Program
    {
        static void Main(string[] args)
        {

            string plaintext = Util.PlainText();
            string singlekey = Util.SingleKey();
            string multikey = Util.MultiKey();
            Console.WriteLine();

            Console.WriteLine($"[{plaintext}] was your plaintext");
            Console.WriteLine($"[{singlekey}] was your singlekey");
            Console.WriteLine($"[{multikey}] was your multikey");
            Console.WriteLine();

            int[] cleantext = Util.Clean(plaintext);
            int[] cleanskey = Util.Clean(singlekey);
            int[] cleanmkey = Util.Clean(multikey);

            string encSingle = Util.SingleCharEncryption(cleantext, cleanskey);
            string encMulti = Util.MultiCharEncryption(cleantext, cleanmkey);
            string encConti = Util.ContinuousEncryption(cleantext, cleanmkey);

            Console.WriteLine($"Encrypted message with singlekey: [{encSingle}]");
            Console.WriteLine($"Encrypted message with multikey: [{encMulti}]");
            Console.WriteLine($"Encrypted message with continuous: [{encConti}]");
            Console.WriteLine();

            string decSingle = Util.SingleCharDecryption(encSingle, cleanskey);
            string decMulti = Util.MultiCharDecryption(encMulti, cleanmkey);
            string decConti = Util.ContinuousDecryption(encConti, cleanmkey);

            Console.WriteLine($"Decrypted message with singlekey: [{decSingle}]");
            Console.WriteLine($"Decrypted message with multikey: [{decMulti}]");
            Console.WriteLine($"Decrypted message with continuous key: [{decConti}]");
            Console.WriteLine();
        }
    }
    public class Util
    {
        public static int GetPosition(int character) => character - 'A' + 1;
        public static void GetInRange(ref int character)
        {
            while (character < 'A')
            {
                character += 26;
            }
            while (character > 'Z')
            {
                character -= 26;
            }
        }
        public static string PlainText()
        {
            Console.Write("Enter plain text: ");
            string input = Console.ReadLine();
            return input;
        }
        public static string SingleKey()
        {
            string userInput;
            do
            {
                Console.Write("Enter your single key as an alpha character: ");
                userInput = Console.ReadLine();
                string input = userInput.ToUpper();
                if (input[0] < 'A' || input[0] > 'Z' || input.Length > 1)
                {
                    Console.WriteLine("Your input was invalid. Please enter a single character from A to Z.");
                    userInput = "-1";
                }
            } while (userInput.Equals("-1"));
            return userInput;
        }
        public static string MultiKey()
        {
            Console.Write("Enter your multi key characters: ");
            string input = Console.ReadLine();
            return input;
        }

        public static int[] Clean(string input)
        {
            input = input.ToUpper();
            string cleanedString = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 'A' && input[i] <= 'Z')
                {
                    cleanedString += input[i];
                }
            }
            int[] result = new int[cleanedString.Length];

            for (int i = 0; i < cleanedString.Length; i++)
            {
                result[i] = cleanedString[i];
            }
            return result;
        }
        public static string SingleCharEncryption(int[] inputText, int[] singlekey)
        {
            int character;                      
            string result = "";                 

            for (int i = 0; i < inputText.Length; i++)
            {
                character = inputText[i] + GetPosition(singlekey[0]);
                GetInRange(ref character);
                result += (char)character;
            }
            return result;
        }
        public static string SingleCharDecryption(string inputText, int[] singlekey)
        {
            int characterTemp;
            string result = "";

            for (int i = 0; i < inputText.Length; i++)
            {
                characterTemp = inputText[i] + GetPosition(singlekey[0]) * -1;
                GetInRange(ref characterTemp);
                result += (char)(characterTemp);
            }
            return result;
        }
        public static string MultiCharEncryption(int[] inputText, int[] multikey)
        {
            int characterTemp;
            string result = "";

            for (int i = 0; i < inputText.Length; i++)
            {
                characterTemp = inputText[i] + GetPosition(multikey[i % multikey.Length]);
                GetInRange(ref characterTemp);
                result += (char)characterTemp;
            }
            return result;
        }
        public static string MultiCharDecryption(string inputText, int[] multikey)
        {
            int characterTemp;     
            string result = "";                

            for (int i = 0; i < inputText.Length; i++)
            {
                characterTemp = inputText[i] + GetPosition(multikey[i % multikey.Length]) * -1;
                GetInRange(ref characterTemp);
                result += (char)(characterTemp);
            }
            return result;
        }
        public static string ContinuousEncryption(int[] inputText, int[] multikey)
        {
            int characterTemp;                    
            string result = "";

            for (int i = 0; i < inputText.Length; i++)
            {
                if (i < multikey.Length)
                {
                    characterTemp = inputText[i] + GetPosition(multikey[i]);
                }
                else
                {
                    characterTemp = inputText[i] + GetPosition(inputText[i - multikey.Length]);
                }
                GetInRange(ref characterTemp);
                result += (char)(characterTemp);
            }
            return result;
        }
        public static string ContinuousDecryption(string inputText, int[] multikey)
        {
            int characterTemp;                      
            string result = "";                 

            for (int i = 0; i < inputText.Length; i++)
            {
                if (i < multikey.Length)
                {
                    characterTemp = inputText[i] + GetPosition(multikey[i]) * -1;
                }
                else
                {
                    characterTemp = inputText[i] + GetPosition(result[i - multikey.Length]) * -1;
                }
                GetInRange(ref characterTemp);
                result += (char)characterTemp;
            }
            return result;
        }
    } 
}
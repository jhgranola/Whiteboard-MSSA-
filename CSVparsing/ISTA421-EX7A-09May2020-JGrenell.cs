using System;
using System.Collections.Generic;

namespace CSVparsing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment code snip
            /*********************
             * read CSV with embedded commas
             * parse CSV into separate fields and
             * ignore commas within quoted string
             * *******************/
            Console.WriteLine("Reading CSV with embedded commas");
            List<string> myList = new List<string>();
            string input1 = "\"a,b\",c";
            myList.Add(input1);
            string input2 = "\"Obama, Barack\",\"August, 4 1961\",\"Washington, D.C.\"";
            myList.Add(input2);
            string input3= "\"Ft. Benning, Georgia\",32.3632N,84.9493W," +
                "\"Ft. Stewart, Georgia\",31.8691N,81.6090W," +
                "\"Ft. Gordon, Georgia\",33.4302N,82.1267W";
            myList.Add(input3);

            foreach (string inputString in myList)
            {
                Console.WriteLine($"Current input is {inputString}");
                List<string> output = getCSV(inputString);
                int fieldLength = output.Count;
                Console.WriteLine($"This line has {fieldLength} fields. They are:");
                foreach (string s1 in output)
                {
                    Console.WriteLine(s1);
                }
            }
            // End of Assignment code snip
            static List<string> getCSV(string inputString)
            {
                var output = new List<string>();
                string tempString = "";
                for (int i = 0; i < inputString.Length; i++)
                {
                    if (inputString[i] == '\"')
                        while (inputString[++i] != '\"')
                            tempString += inputString[i];
                    else if (inputString[i] != ',') tempString += inputString[i];
                    if (inputString[i] == ',')
                    {
                        output.Add(tempString);
                        tempString = "";
                    }
                }
                output.Add(tempString);
                return output;
            }
        }
    }
}
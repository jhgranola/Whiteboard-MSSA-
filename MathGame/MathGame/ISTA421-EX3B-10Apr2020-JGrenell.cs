using System;

namespace MathGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many problems would you like to practice?");
            int numberOfProblems = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Which math operation would you like to practice?\nPress <1> for addition." +
                "\nPress <2> for subtraction.\nPress <3> for multiplication." +
                "\nPress <4> for division.");
            int input1 = Convert.ToInt32(Console.ReadLine());
            int score = numberOfProblems;
            switch (input1)
            {
                case 1:
                    for (int i = 0; i < numberOfProblems; i++)
                    {
                        AddPractice();
                    }
                    Console.WriteLine($"You got {score} out of {numberOfProblems} correct.");
                    break;
                case 2:
                    for (int i = 0; i < numberOfProblems; i++)
                    {
                        SubtractPractice();
                    }
                    Console.WriteLine($"You got {score} out of {numberOfProblems} correct.");
                    break;
                case 3:
                    for (int i = 0; i < numberOfProblems; i++)
                    {
                        MultiplyPractice();
                    }
                    Console.WriteLine($"You got {score} out of {numberOfProblems} correct.");
                    break;
                case 4:
                    for (int i = 0; i < numberOfProblems; i++)
                    {
                        DividePractice();
                    }
                    Console.WriteLine($"You got {score} out of {numberOfProblems} correct.");
                    break;
            }
        }
        public static string AddPractice()
        {
            int score = 0;
            int userAnswer;
            int answer;
                Random random = new Random();
                int num1 = random.Next(1, 100);
                int num2 = random.Next(1, 100);
                Console.WriteLine($"{num1} + {num2} = x\nWhat is X?");
                answer = num1 + num2;
                userAnswer = Convert.ToInt32(Console.ReadLine());
            if (answer == userAnswer)
            {
                score++;
            }
                return answer == userAnswer ? "Correct!" : "Incorrect...";
        }
        public static string SubtractPractice()
        {
            int score = 0;
            int userAnswer;
            int answer;
            Random random = new Random();
            int num1 = random.Next(1, 100);
            int num2 = random.Next(1, 100);
            Console.WriteLine($"{num1} - {num2} = x\nWhat is X?");
            answer = num1 - num2;
            userAnswer = Convert.ToInt32(Console.ReadLine());
            if (answer == userAnswer)
            {
                score++;
            }
            return answer == userAnswer ? "Correct!" : "Incorrect...";
        }
        public static string MultiplyPractice()
        {
            int score = 0;
            int userAnswer;
            int answer;
            Random random = new Random();
            int num2 = random.Next(1, 100);
            int num1 = random.Next(1, 100);
            Console.WriteLine($"{num1} * {num2} = x\nWhat is X?");
            answer = num1 * num2;
            userAnswer = Convert.ToInt32(Console.ReadLine());
            if (answer == userAnswer)
            {
                score++;
            }
            return answer == userAnswer ? "Correct!" : "Incorrect...";
        }
        public static string DividePractice()
        {
            int score = 0;
            int userAnswer;
            int answer;
            Random random = new Random();
            int num1 = random.Next(1, 100);
            int num2 = random.Next(1, 100);
            Console.WriteLine($"{num1} / {num2} = x\nWhat is X?");
            answer = num1 / num2;
            userAnswer = Convert.ToInt32(Console.ReadLine());
            if (answer == userAnswer)
            {
                score++;
            }
            return answer == userAnswer ? "Correct!" : "Incorrect...";
        }
    }
}

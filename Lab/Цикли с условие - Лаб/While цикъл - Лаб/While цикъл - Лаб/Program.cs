using System;

namespace While_цикъл___Лаб
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            zad1
            string text = Console.ReadLine();
            while (text!="Stop")
            {
                Console.WriteLine(text);
                text = Console.ReadLine();
            }
            
            zad2
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            string passInput = Console.ReadLine();
            while (passInput!=password)
            {
                passInput = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {username}!");
            
            zad3
            int firstSum = int.Parse(Console.ReadLine());
            int numberSum = 0;
            while (numberSum<firstSum)
            {
                int numbers = int.Parse(Console.ReadLine());
                numberSum += numbers;
            }
            Console.WriteLine(numberSum);
            
            zad4
            int n = int.Parse(Console.ReadLine());
            int currentNum = 1;
            while (currentNum<=n)
            {
                Console.WriteLine(currentNum);
                currentNum = currentNum * 2 + 1;
            }
            
            zad5
            string input;
            double accBalance = 0;
            while ((input=Console.ReadLine())!="NoMoreMoney")
            {
                double sumPutIn = double.Parse(input);
                if (sumPutIn<0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                accBalance += sumPutIn;
                Console.WriteLine($"Increase: {sumPutIn:f2}");
            }
            Console.WriteLine($"Total: {accBalance:f2}");
            
            zad6
            string input;
            int max = int.MinValue;
            while ((input = Console.ReadLine())!="Stop")
            {
                int n = int.Parse(input);
                if (n>max)
                {
                    max = n;
                }
            }
            Console.WriteLine(max);
            
            zad7
            string input;
            int min = int.MaxValue;
            while ((input = Console.ReadLine()) != "Stop")
            {
                int n = int.Parse(input);
                if (n < min)
                {
                    min = n;
                }
            }
            Console.WriteLine(min);
            */
            string name = Console.ReadLine();
            int grade = 1;
            double markSum = 0;
            int classRepetition = 0;
            while (grade<=12)
            {
                double currentMark = double.Parse(Console.ReadLine());
                if (currentMark<4)
                {
                    classRepetition++;
                    if (classRepetition>1)
                    {
                        break;
                    }
                    continue;
                }
                markSum += currentMark;
                grade++;
            }
            if (classRepetition>1)
            {
                Console.WriteLine($"{name} has been excluded at {grade} grade");
            }
            else
            {
                double averageMark = markSum / (grade - 1);
                Console.WriteLine($"{name} graduated. Average grade: {averageMark:f2}");
            }
        }
    }
}

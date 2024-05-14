using System;
using System.Linq;
using System.Collections.Generic;

namespace While_loop___Упражнение
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            zad1
            string favoriteBook = Console.ReadLine();
            int count = 0;
            bool isBookFound = false;
            string nextBookName = Console.ReadLine();
            while (nextBookName!= "No More Books")
            {
                if (nextBookName==favoriteBook)
                {
                    isBookFound = true;
                    break;
                }
                count++;
                nextBookName = Console.ReadLine();
            }
            if (isBookFound)
            {
                Console.WriteLine($"You checked {count} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }
            
            zad2
            double badGrades = int.Parse(Console.ReadLine());
            double badGradeCount = 0;
            double problemsNum = 0;
            double gradeSum = 0;
            double average = 0;
            string lastProblemName = null;
            while (true)
            {
                string name = Console.ReadLine();
                if (name!="Enough")
                {
                    lastProblemName = name;
                }
                if (name == "Enough")
                {
                    average = (gradeSum / problemsNum);
                    Console.WriteLine($"Average score: {average:f2}");
                    Console.WriteLine($"Number of problems: {problemsNum}");
                    Console.WriteLine($"Last problem: {lastProblemName}");
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade<=4)
                {
                    badGradeCount++;
                }
                if (badGradeCount>=badGrades)
                {
                    Console.WriteLine($"You need a break, {badGradeCount} poor grades.");
                    break;
                }
                problemsNum++;
                gradeSum += grade;
            }
            
            zad3
            double neededMoney = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());
            int daysCounter = 0;
            int spendCounter = 0;

            while (ownedMoney < neededMoney && spendCounter < 5)
            {
                string command = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                daysCounter++;
                if (command == "spend")
                {
                    spendCounter++;

                    if (ownedMoney - money < 0)
                    {
                        ownedMoney = 0;
                    }
                    else
                    {
                        ownedMoney -= money;
                    }
                }
                else if (command == "save")
                {
                    ownedMoney += money;
                    spendCounter = 0;
                }
            }

            if (spendCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCounter);
            }

            if (ownedMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
            
            zad4
            string input;
            int stepsDone = 0;
            while (stepsDone<10000)
            {
                input = Console.ReadLine();
                if (input=="Going home")
                {
                    stepsDone += int.Parse(Console.ReadLine());
                    break;
                }
                else
                {
                    int steps = int.Parse(input);
                    stepsDone += steps;
                }
            }
            if (stepsDone>=10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepsDone-10000} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{10000-stepsDone} more steps to reach goal.");
            }
            zad5
            double change = double.Parse(Console.ReadLine());
            change = change * 100;
            int coins = 0;
            while (change>0)
            {
                if (change >= 200)
                {
                    change -= 200;
                }
                else if (change >= 100)
                {
                    change -= 100;
                }
                else if (change >= 50)
                {
                    change -= 50;
                }
                else if (change >= 20)
                {
                    change -= 20;
                }
                else if (change >= 10)
                {
                    change -= 10;
                }
                else if (change >= 5)
                {
                    change -= 5;
                }
                else if (change >= 2)
                {
                    change -= 2;
                }
                else if (change >= 1)
                {
                    change -= 1;
                }
                else
                {
                    change = 0;
                    break;
                }
                coins++;
            }
            Console.WriteLine(coins);
            zad6
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int countPieces = length * width;

            string pieces;
            while (countPieces >= 0 && (pieces = Console.ReadLine()) != "STOP")
            {
                countPieces -= int.Parse(pieces);
            }

            if (countPieces >= 0)
            {
                Console.WriteLine($"{countPieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {-countPieces} pieces more.");
            }
            */
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int volume = height * width * lenght;
            string boxes;
            while (volume>=0 && (boxes=Console.ReadLine())!="Done")
            {
                volume -= int.Parse(boxes);
                int boxVolume = ;

            }
        }
    }
}

using System;

namespace Вложени_цикли___Лаб
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             zad1
            for (int hours = 0; hours <= 23; hours++)
            {
                for (int min = 0; min <= 59; min++)
                {
                    Console.WriteLine($"{hours}:{min}");
                }
            }
            zad2
            for (int first = 1; first <= 10; first++)
            {
                for (int second = 1; second <= 10; second++)
                {
                    int result = first * second;
                    Console.WriteLine($"{first} * {second} = {result}");
                }
            }
            zad 3
            int num = int.Parse(Console.ReadLine());
            int result=0;
            int count=0;
            for (int first = 0; first <= num; first++)
            {
                for (int second = 0; second <= num; second++)
                {
                    for (int third = 0; third <=num; third++)
                    {
                        result = first + second + third;
                        if (result == num)
                        {
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count);
            
            zad4
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int combination = 0;
            int sum = 0;
            bool flag = false;
            for (int x1 = start; x1 <=end ; x1++)
            {
                for (int x2 = start; x2 <= end; x2++)
                {
                    combination++;
                    sum = x1 + x2;
                    if (sum==magicNum)
                    {
                        Console.WriteLine($"Combination N:{combination} ({x1} + {x2} = {magicNum})");
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
            if (sum!=magicNum)
            {
                Console.WriteLine($"{combination} combinations - neither equals {magicNum}");
            }
            
            zad5
            string input=Console.ReadLine();
            string destination=null;
            double neededMoney=0;
            double sum = 0;
            while (input!="End")
            {
                destination = input;
                neededMoney = double.Parse(Console.ReadLine());
                sum = 0;
                while (sum < neededMoney)
                {
                    double money = double.Parse(Console.ReadLine());
                    sum += money;
                }
                Console.WriteLine($"Going to {destination}!");
                input = Console.ReadLine();
            }
            */
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            for (int f = floors; f >= 1; f--)
            {
                for (int r = 0; r < rooms; r++)
                {
                    if (f == floors)
                    {
                        Console.Write($"L{f}{r} ");
                    }
                    if (f % 2 == 0 && f!=floors)
                    {
                        Console.Write($"O{f}{r} ");
                    }
                    else if (f%2==1 && f!=floors)
                    {
                        Console.Write($"A{f}{r} ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}

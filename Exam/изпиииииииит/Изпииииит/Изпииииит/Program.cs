using System;

namespace Изпииииит
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = null;
            string otherPlayer = null;
            string nameOfPlayer = null;
            int goals = 0;
            int currentGoals = 0;
            while (true)
            {
                command = Console.ReadLine();
                if (command != "END")
                {
                    currentGoals = int.Parse(Console.ReadLine());
                    if (currentGoals > goals)
                    {
                        otherPlayer = command;
                        nameOfPlayer = command;
                    }
                    else
                    {
                        nameOfPlayer = otherPlayer;
                    }
                }
                else
                {
                    break;
                }
                if (currentGoals >= goals)
                {
                    goals = currentGoals;
                }
                if (goals >= 10)
                {
                    break;
                }
            }
            Console.WriteLine($"{nameOfPlayer} is the best player!");
            if (goals >= 3)
            {
                Console.WriteLine($"He has scored {goals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {goals} goals.");
            }
        }
    }
}

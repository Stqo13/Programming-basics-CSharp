using System;

namespace Вложени_цикли___Упражнение
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            zad1
            int n = int.Parse(Console.ReadLine());
            int current = 1;
            bool flag = false;
            for (int rows = 1; rows <=n; rows++)
            {
                for (int cols = 1; cols <=rows; cols++)
                {
                    if (current>n)
                    {
                        flag = true;
                        break;
                    }
                    Console.Write(current + " ");
                    current++;
                }
                if (flag)
                {
                    break;
                }
                Console.WriteLine();
            }
            */
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            for (int i = num1; i <= num1; i++)
            {
                string currentNum = i.ToString();
                int evenSum = 0;
                int oddSum = 0;
                for (int j = 0; j <= currentNum.Length; j++)
                {
                    int currentDiggit = int.Parse(currentNum[j].ToString());
                    if (j%2==0)
                    {
                        evenSum += currentDiggit ;
                    }
                    else
                    {
                        oddSum += currentDiggit ; 
                    }
                }
            }
        }
    }
}

using System;

namespace Повторения_с_цикли___Лаб
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             zad1
             for (int i = 1; i <= 100; i++)
             {
                 Console.WriteLine(i);
             }

             zad2
             int n = int.Parse(Console.ReadLine());
             for (int i = n; i>=1; i--)
             {
                 Console.WriteLine(i);
             }
              zad 3
             int n = int.Parse(Console.ReadLine());
             for (int i = 1; i <=n; i+=3)
             {
                 Console.WriteLine(i);
             }
            zad4
             int n = int.Parse(Console.ReadLine());
             for (int pow = 0; pow <=n; pow+=2)
             {
                 Console.WriteLine(Math.Pow(2, pow));
             }

             zad 5
             string text = Console.ReadLine();
             for (int i = 0; i < text.Length; i++)
             {
                 char letter = text[i];
                 Console.WriteLine(letter);
             }
             
            zad6
            string text = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char character = text[i];
                switch (character)
                {
                    case 'a':
                        sum += 1;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                }
            }
            Console.WriteLine(sum);
            
            zad7
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                sum = sum + numbers;
                
            }
            Console.WriteLine(sum);

            zad 8
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (numbers>max)
                {
                    max = numbers;
                }
                if (numbers<min)
                {
                    min = numbers;
                }
            }
            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
            
            zad9
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            for (int i = 1; i <= n; i++)
            {
                
                sum1 = sum1 + int.Parse(Console.ReadLine());
            }
            int sum2 = 0;
            for (int i = 1; i <= n; i++)
            {
                sum2 = sum2 + int.Parse(Console.ReadLine());
            }
            if (sum1 == sum2)
            {
                Console.WriteLine("Yes, sum = " + sum1);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(sum2 - sum1));
            }
            */
            //zad10
            int n = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    int num = int.Parse(Console.ReadLine());
                    evenSum += num;
                }
                else
                {
                    int num = int.Parse(Console.ReadLine());
                    oddSum += num;
                }
            }
            if (evenSum==oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = "+evenSum);
            }
            else if (evenSum!=oddSum)
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(oddSum-evenSum));
            }
        }
    }
}


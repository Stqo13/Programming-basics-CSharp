using System;

namespace Проверки___Лаб
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             zad 1
             double grade = double.Parse(Console.ReadLine());
             if (grade >= 5.50)
             {
                 Console.WriteLine("Excellent!");
             }
             
            zad2
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            if (num1>num2)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(num2);
            }
           
            zad3
            int num = int.Parse(Console.ReadLine());
            if (num%2==0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
            
            zad4
            string password = (Console.ReadLine());
            string realPassword= "s3cr3t!P@ssw0rd";
            if (password== "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");

            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
            
            zad5
            int num=int.Parse(Console.ReadLine());
            if (num>=100 && num<=200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            if (num<100)
            {
                Console.WriteLine("Less than 100");
            }
            if (num>200)
            {
                Console.WriteLine("Greater than 200");
            }
            
            zad6
            double velocity = double.Parse(Console.ReadLine());
            if (velocity<=10)
            {
                Console.WriteLine("slow");
            }
            if (velocity>10 && velocity<=50)
            {
                Console.WriteLine("average");
            }
            if (velocity>50 && velocity<=150)
            {
                Console.WriteLine("fast");
            }
            if (velocity > 150 && velocity<=1000)
            {
                Console.WriteLine("ultra fast");
            }
            if (velocity>1000)
            {
                Console.WriteLine("extremely fast");
            }
            */
            string typeShape = (Console.ReadLine());
            string square = "square";
            string rectangle="rectangle";
            string circle = "circle";
            string triangle = "triangle";
            if (typeShape=="square")
            {
                double a = double.Parse(Console.ReadLine());
                double S = a * a;
                Console.WriteLine($"{S:f3}");
            }
            if (typeShape=="rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double S = a * b;
                Console.WriteLine($"{S:f3}");
            }
            if (typeShape=="circle")
            {
                double r = double.Parse(Console.ReadLine());
                double S = r * r * Math.PI;
                Console.WriteLine($"{S:f3}");
            }
            if (typeShape=="triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double S = (a * h) / 2;
                Console.WriteLine($"{S:f3}");
            }
        }
    }
}

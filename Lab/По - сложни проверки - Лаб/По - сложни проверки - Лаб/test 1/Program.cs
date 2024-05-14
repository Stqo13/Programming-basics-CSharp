using System;

namespace test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double n = double.Parse(Console.ReadLine());
            double price = 1.0;
            switch (city)
            {
                case "Sofia":
                    if (product=="cofee")
                    {
                        price = n * 0.50;
                    }
                    else if (product=="water")
                    {
                        price = n * 0.80;
                    }
                    else if (product=="beer")
                    {
                        price = n * 1.20;
                    }
                    else if (product=="sweets")
                    {
                        price = n * 1.45;
                    }
                    else if (product=="peanuts")
                    {
                        price = n * 1.60;
                    }
                    break;
                case "Plovdiv":
                    if (product == "cofee")
                    {
                        price = n * 0.40;
                    }
                    else if (product == "water")
                    {
                        price = n * 0.70;
                    }
                    else if (product == "beer")
                    {
                        price = n * 1.15;
                    }
                    else if (product == "sweets")
                    {
                        price = n * 1.30;
                    }
                    else if (product == "peanuts")
                    {
                        price = n * 1.50;
                    }
                    break;
                case "Varna":
                    if (product == "cofee")
                    {
                        price = n * 0.45;
                    }
                    else if (product == "water")
                    {
                        price = n * 0.70;
                    }
                    else if (product == "beer")
                    {
                        price = n * 1.10;
                    }
                    else if (product == "sweets")
                    {
                        price = n * 1.35;
                    }
                    else if (product == "peanuts")
                    {
                        price = n * 1.55;
                    }
                    break;
            }
            Console.WriteLine(price);
        }
    }
}

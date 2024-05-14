using System;

namespace По___сложни_проверки___Лаб
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             zad1
            int dayOfWeek = int.Parse(Console.ReadLine());
            switch (dayOfWeek)
            {
                case 1:
                Console.WriteLine("Monday");
                break;

                case 2:
                Console.WriteLine("Tuesday");
                break;

                case 3:
                Console.WriteLine("Wednesday");
                break;

                case 4:
                Console.WriteLine("Thursday");
                break;

                case 5:
                Console.WriteLine("Friday");
                break;

                case 6:
                Console.WriteLine("Saturday");
                break;

                case 7:
                Console.WriteLine("Sunday");
                break;

                default:
                Console.WriteLine("Error");
                break;
            }
            
            zad2
            string day = (Console.ReadLine());
            switch (day)
            {
                case "Monday":
                    Console.WriteLine("Working day");
                    break;
                case "Tuesday":
                    Console.WriteLine("Working day");
                    break;
                case "Wednesday":
                    Console.WriteLine("Working day");
                    break;
                case "Thursday":
                    Console.WriteLine("Working day");
                    break;
                case "Friday":
                    Console.WriteLine("Working day");
                    break;
                case "Saturday":
                    Console.WriteLine("Weekend");
                    break;
                case "Sunday":
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            
            zad3
            string animal = (Console.ReadLine());
            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
            
            zad4
            double age = double.Parse(Console.ReadLine());
            string gender = (Console.ReadLine());
            if (gender=="f")
            {
                if (age<16)
                {
                    Console.WriteLine("Miss");
                }
                else
                {
                    Console.WriteLine("Ms.");
                }
            }
            if (gender == "m")
            {
                if (age<16)
                {
                    Console.WriteLine("Master");
                }
                else
                {
                    Console.WriteLine("Mr.");
                }
            }
            
            zad 5
                string product = Console.ReadLine();
                string city = Console.ReadLine();
                double n = double.Parse(Console.ReadLine());
                double price = 1;
                switch (city)
                {
                    case "Sofia":
                        if (product == "coffee")
                        {
                            price = n * 0.50;
                        }
                        else if (product == "water")
                        {
                            price = n * 0.80;
                        }
                        else if (product == "beer")
                        {
                            price = n * 1.20;
                        }
                        else if (product == "sweets")
                        {
                            price = n * 1.45;
                        }
                        else if (product == "peanuts")
                        {
                            price = n * 1.60;
                        }
                        break;
                    case "Plovdiv":
                        if (product == "coffee")
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
                        if (product == "coffee")
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
            
            zad6
            int num = int.Parse(Console.ReadLine());
            if (num<=100 && num>=-100 && num!=0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            
            zad7
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            if (hour>=10 && hour<=18)
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                    case "Saturday":
                        Console.WriteLine("open");
                        break;
                    case "Sunday":
                        Console.WriteLine("closed");
                        break;
                }
            }
            else
            {
                Console.WriteLine("closed");
            }
            
            zad8
            string day = Console.ReadLine();
            switch (day)
            {
                case "Monday":
                    Console.WriteLine("12");
                    break;
                case "Tuesday":
                    Console.WriteLine("12");
                    break;
                case "Wednesday":
                    Console.WriteLine("14");
                    break;
                case "Thursday":
                    Console.WriteLine("14");
                    break;
                case "Friday":
                    Console.WriteLine("12");
                    break;
                case "Saturday":
                    Console.WriteLine("16");
                    break;
                case "Sunday":
                    Console.WriteLine("16");
                    break;
            }
            
            zad9
            string product = Console.ReadLine();
            switch (product)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "grapes":
                case "cherry":
                case "lemon":
                    Console.WriteLine("fruit");
                    break;
                case "tomato":
                case "cucumber":
                case "carrot":
                case "pepper":
                    Console.WriteLine("vegetable");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
            
            zad10
            int num = int.Parse(Console.ReadLine());
            if (num>=100 && num<=200 || num==0)
            {
                
            }
            else
            {
                Console.WriteLine("invalid");
            }
            
            zad11
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            double price = 0;
            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                switch (fruit)
                {
                    case "banana": price = amount * 2.5; break;
                    case "apple": price = amount * 1.2; break;
                    case "orange": price = amount * 0.85; break;
                    case "grapefruit": price = amount * 1.45; break;
                    case "kiwi": price = amount * 2.7; break;
                    case "pineapple": price = amount * 5.5; break;
                    case "grapes": price = amount * 3.85; break;

                }
            }

            else if (day == "Saturday" || day == "Sunday")
            {
                switch (fruit)
                {
                    case "banana": price = amount * 2.70; break;
                    case "apple": price = amount * 1.25; break;
                    case "orange": price = amount * 0.90; break;
                    case "grapefruit": price = amount * 1.60; break;
                    case "kiwi": price = amount * 3.00; break;
                    case "pineapple": price = amount * 5.60; break;
                    case "grapes": price = amount * 4.20; break;
                }
            }
            if ((fruit == "banana" || fruit == "apple" || fruit == "orange" || fruit == "grapefruit" || fruit == "kiwi" || fruit == "pineapple" || fruit == "grapes") && (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday" || day == "Saturday" || day == "Sunday"))
            {
                Console.WriteLine($"{price:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
            */
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commissions=0;
            if (city=="Sofia")
            {
                if (sales>=0 && sales<=500)
                {
                    commissions = sales * 0.05;
                }
                if (sales>500 && sales <=1000)
                {
                    commissions = sales * 0.07;
                }
                if (sales>1000 && sales<=10000)
                {
                    commissions = sales * 0.08;
                }
                if (sales>10000)
                {
                    commissions = sales * 0.12;
                }
            }
            if (city == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commissions = sales * 0.045;
                }
                if (sales > 500 && sales <= 1000)
                {
                    commissions = sales * 0.075;
                }
                if (sales > 1000 && sales <= 10000)
                {
                    commissions = sales * 0.10;
                }
                if (sales > 10000)
                {
                    commissions = sales * 0.13;
                }
            }
            if (city == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commissions = sales * 0.055;
                }
                if (sales > 500 && sales <= 1000)
                {
                    commissions = sales * 0.08;
                }
                if (sales > 1000 && sales <= 10000)
                {
                    commissions = sales * 0.12;
                }
                if (sales > 10000)
                {
                    commissions = sales * 0.145;
                }
            }
            if (city == "Sofia" || city == "Varna" || city == "Plovdiv" && sales >= 0)
            {
                Console.WriteLine($"{commissions:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}


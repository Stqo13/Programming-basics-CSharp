using System;

namespace По___сложни_проверки___Упраажнение
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             zad1
             string type = Console.ReadLine();
             int row = int.Parse(Console.ReadLine());
             int colum = int.Parse(Console.ReadLine());
             double income = 0.0;
             if (type=="Premiere")
             {
                 income = row * colum * 12;

             }
             if (type=="Normal")
             {
                 income = row * colum * 7.5;

             }
             if (type=="Discount")
             {
                 income = row * colum * 5;
             }
             Console.WriteLine($"{income:f2} leva");
            
            zad2
            int degrees = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            if (time=="Morning"  && degrees>=10 && degrees<=18)
            {
                Console.WriteLine($"It's {degrees} degrees, get your Sweatshirt and Sneakers.");
            }
            if (time == "Morning" && degrees>18  && degrees<=24 )
            {
                Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
            }
            if (time == "Morning" && degrees >=25)
            {
                Console.WriteLine($"It's {degrees} degrees, get your T-Shirt and Sandals.");
            }
            if (time=="Afternoon" && degrees >= 10 && degrees <= 18)
            {
                Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
            }
            if (time == "Afternoon" && degrees > 18 && degrees <= 24)
            {
                Console.WriteLine($"It's {degrees} degrees, get your T-Shirt and Sandals.");
            }
            if (time == "Afternoon" && degrees >= 25)
            {
                Console.WriteLine($"It's {degrees} degrees, get your Swim Suit and Barefoot.");
            }
            if (time=="Evening" && degrees >= 10 && degrees <= 18)
            {
                Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
            }
            if (time == "Evening" && degrees > 18 && degrees <= 24)
            {
                Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
            }
            if (time == "Evening" && degrees >= 25)
            {
                Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
            }
            
            zad3
            string typeFlowers = Console.ReadLine();
            int numOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double cost=0;
            if (typeFlowers=="Roses")
            {
                if (numOfFlowers > 80)
                {
                    cost = numOfFlowers * 5;
                    cost = cost - (cost * 0.1);
                }
                else
                {
                    cost = numOfFlowers * 5;
                }
            }
            if (typeFlowers == "Dahlias")
            {
                if (numOfFlowers>90)
                {
                    cost = numOfFlowers * 3.8;
                    cost = cost - cost * 0.15;
                }
                else
                {
                    cost = numOfFlowers * 3.8;
                }
            }
            if (typeFlowers== "Tulips")
            {
                if (numOfFlowers>80)
                {
                    cost = numOfFlowers * 2.8;
                    cost = cost - cost * 0.15;
                }
                else
                {
                    cost = numOfFlowers * 2.8;
                }
            }
            if (typeFlowers== "Narcissus")
            {
                if (numOfFlowers<120)
                {
                    cost = numOfFlowers * 3;
                    cost = cost + cost * 0.15;
                }
                else
                {
                    cost = numOfFlowers * 3;
                }
            }
            if (typeFlowers== "Gladiolus")
            {
                if (numOfFlowers<80)
                {
                    cost = numOfFlowers * 2.5;
                    cost = cost + cost * 0.2;
                }
                else
                {
                    cost = numOfFlowers * 2.5;
                }
            }
            if (budget>=cost)
            {
                Console.WriteLine($"Hey, you have a great garden with {numOfFlowers} {typeFlowers} and {budget-cost:f2} leva left.");  
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {cost-budget:f2} leva more.");
            }
            
            zad4
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int group = int.Parse(Console.ReadLine());
            double cost = 0;
            switch (season)
            {
                case "Spring":
                    cost = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    cost = 4200;
                    break;
                case "Winter":
                    cost = 2600;
                    break;
            }
            if (group<=6)
            {
                cost = cost - cost * 0.1;
            }
            else if (group<=11)
            {
                cost = cost - cost * 0.15;
            }
            else
            {
                cost = cost - cost * 0.25;
            }
            if (group%2==0 && season!="Autumn")
            {
                cost = cost - cost * 0.05;
            }
            if (budget>=cost)
            {
                Console.WriteLine($"Yes! You have {budget-cost:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {cost-budget:f2} leva.");
            }
            
            zad5
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double sum = 0;
            if (season=="summer")
            {
                if (budget<=100)
                {
                    sum = budget * 0.30;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {sum:f2}");
                }
                else if (budget<=1000)
                {
                    sum = budget * 0.40;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {sum:f2}");
                }
            }
            if (season == "winter")
            {
                if (budget <= 100)
                {
                    sum = budget * 0.70;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {sum:f2}");
                }
                else if (budget <= 1000)
                {
                    sum = budget * 0.80;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {sum:f2}");
                }
            }
            if (budget > 1000)
            {
                sum = budget * 0.90;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {sum:f2}");
            }
            
            zad6
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            char op =char.Parse(Console.ReadLine());
            double result = 0;
            if (op=='+')
            {
                result = N1 + N2;
                if (result%2==0)
                {
                    Console.WriteLine($"{N1} {op} {N2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} {op} {N2} = {result} - odd");
                }
            }
            if (op=='-')
            {
                result = N1 - N2;
                if (result%2==0)
                {
                    Console.WriteLine($"{N1} {op} {N2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} {op} {N2} = {result} - odd");
                }
            }
            if (op == '*')
            {
                result = N1 * N2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{N1} {op} {N2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} {op} {N2} = {result} - odd");
                }
            }
            if (N2==0)
            {
                Console.WriteLine($"Cannot divide {N1} by zero");
            }
            else if (op=='/')
            {
                result = (double)N1 / N2;
                Console.WriteLine($"{N1} {op} {N2} = {result:f2}");
            }
            else if (op=='%')
            {
                result = N1 % N2;
                Console.WriteLine($"{N1} {op} {N2} = {result}");
            }
            */
            
            string month = Console.ReadLine();
            int stays = int.Parse(Console.ReadLine());
            double priceSt = 0;
            double priceAp = 0;
            switch (month)
            {
                case "May":
                case "October":
                    priceAp = stays * 65;
                    priceSt = stays * 50;
                    if (stays > 14)
                    {
                        priceSt -= (priceSt * 0.30);
                    }
                    else if (stays > 7)
                    {
                        priceSt = priceSt - (priceSt * 0.05);
                    }
                    break;
                case "June":
                case "September":
                    priceAp = stays * 68.7;
                    priceSt = stays * 75.2;
                    if (stays > 14)
                    {
                        priceSt = priceSt - (priceSt * 0.20);
                    }
                    break;
                case "July":
                case "August":
                    priceAp = stays * 77;
                    priceSt = stays * 76;
                    break;
            }
            if (stays>14)
            {
                priceAp = priceAp - (priceAp * 0.10);
            }
            Console.WriteLine($"Apartment: {priceAp:f2} lv.");
            Console.WriteLine($"Studio: {priceSt:f2} lv.");
            /*
            zad8
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            examMin = examMin + examHour * 60;
            int arrivalH=int.Parse(Console.ReadLine());
            int arrivalM = int.Parse(Console.ReadLine());
            arrivalM = arrivalH * 60 + arrivalM;
            int difference = examMin - arrivalM;
            if (difference<0)
            {
                Console.WriteLine("Late");
                if (difference>-60)
                {
                    Console.WriteLine($"{Math.Abs(difference)}minutes after the start");
                }
                else
                {
                    Console.WriteLine($"{Math.Abs(difference/60)}:{Math.Abs(difference%60):D2}hours after the start");    
                }
            }
            if (difference>30)
            {
                Console.WriteLine("Early");
                if (difference<60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    Console.WriteLine($"{Math.Abs(difference / 60)}:{Math.Abs(difference % 60):D2} hours before the start");
                }
            }
            if (difference>=0 && difference<=30)
            {
                Console.WriteLine("On time");
                if (difference>0)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
            }
            zad9
            int days=int.Parse(Console.ReadLine());
            string typeRoom = Console.ReadLine();
            string opinion = Console.ReadLine();
            double price = 0;
            switch (typeRoom)
            {
                case "room for one person":
                    price = (days-1) * 18;
                    break;
 
                case "apartment":
                    price = (days-1) * 25;
                    if (days<10)
                    {
                        price = price - price * 0.3;
                    }
                    else if (days>=10 && days<=15)
                    {
                        price = price - price * 0.35;
                    }
                    else
                    {
                        price = price - price * 0.5;
                    }
                    break;
                case "president apartment":
                    price = (days-1) * 35;
                    if (days < 10)
                    {
                        price = price - price * 0.1;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        price = price - price * 0.15;
                    }
                    else
                    {
                        price = price - price * 0.2;
                    }
                    break;
            }
            if (opinion=="positive")
            {
                price = price + price * 0.25;
            }
            else if(opinion=="negative")
            {
                price = price - price * 0.1;
            }
            Console.WriteLine($"{price:f2}");
            */
        }
    }
}
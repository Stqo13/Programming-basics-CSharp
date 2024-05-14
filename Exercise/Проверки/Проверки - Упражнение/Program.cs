using System;

namespace Проверки___Упражнение
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             zad1
            int secondsFirst = int.Parse(Console.ReadLine());
            int secondsSecond = int.Parse(Console.ReadLine());
            int secondsThird = int.Parse(Console.ReadLine());
            int timeSum = secondsFirst + secondsSecond + secondsThird;
            int minutes = timeSum / 60;
            int seconds = timeSum % 60;
            if (seconds<10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
            
            zad2
            int num = int.Parse(Console.ReadLine());
            double bonus= 0;
            if (num<=100)
            {
                bonus = 5;
            }
            if (num>100)
            {
                bonus = num * 0.2;
            }
            if (num>1000)
            {
               bonus=num*0.1;
            }
            if (num%2==0)
            {
                bonus += 1;  

            }
            else if(num%10==5)
            {
                bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(num+bonus);
            
            zad3
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += hours * 60;
            minutes += 15;
            hours = minutes / 60;
            minutes = minutes % 60;
            if (hours==24)
            {
                hours = 0;
            }
            Console.WriteLine($"{hours}:{minutes:D2}");
            
            zad4
            double priceForVacation = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int talkingDolls = int.Parse(Console.ReadLine());
            int stuffedBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            int numOfToys = puzzles + talkingDolls + stuffedBears + minions + trucks;
            double orderPrice = puzzles * 2.60 + talkingDolls * 3 + stuffedBears * 4.10 + minions * 8.20 + trucks * 2;
            if (numOfToys>=50)
            {
                orderPrice = orderPrice - orderPrice * 0.25;
            }
            orderPrice = orderPrice-orderPrice * 0.10;
            if (orderPrice >= priceForVacation)
            {
                orderPrice -= priceForVacation;
                Console.WriteLine($"Yes! {orderPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {priceForVacation -= orderPrice:f2} lv needed.");
            }
            
            zad5
            double budget = double.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            double pricePerWorker = double.Parse(Console.ReadLine());
            double decoration = budget * 0.10;
            if (workers>150)
            {
                pricePerWorker = pricePerWorker - pricePerWorker * 0.10;
            }
            double moneyneeded = pricePerWorker*workers + decoration;
            if (moneyneeded<=budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget-moneyneeded:f2} leva left.");
            }
            if (moneyneeded > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyneeded - budget:f2} leva more.");
            }
            
            zad6
            double recordInSeconds = double.Parse(Console.ReadLine());
            double meaters = double.Parse(Console.ReadLine());
            double secPerMeter = double.Parse(Console.ReadLine());
            double slowdown = Math.Floor(meaters / 15)*12.5;
            double finalTime = meaters * secPerMeter + slowdown;
            if (finalTime<recordInSeconds)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {finalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(recordInSeconds-finalTime):f2} seconds slower.");
            }
            
            zad7
            double budget = double.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int P = int.Parse(Console.ReadLine());
            double GPU = N * 250;
            double CPU = M * (0.35 * GPU);
            double RAM = P*(0.10 * GPU);
            double price = GPU + CPU + RAM;
            if (N>M)
            {
                price = price - (0.15*price);
            }
            if (budget>=price)
            {
                Console.WriteLine($"You have {budget-price:f2} leva left!");
            }
            else if(budget<price)
            {
                Console.WriteLine($"Not enough money! You need {price-budget:f2} leva more!");
            }
            */
            string serailName = (Console.ReadLine());
            int episodeLenght = int.Parse(Console.ReadLine());
            int breakLenght = int.Parse(Console.ReadLine());
            double lunchTime = breakLenght * 0.125;
            double relaxTime = breakLenght * 0.25;
            double timeLeft =breakLenght - (lunchTime + relaxTime);
            if (timeLeft>=episodeLenght)
            {
                Console.WriteLine($"You have enough time to watch {serailName} and left with {Math.Ceiling(timeLeft-episodeLenght)} minutes free time.");
            }
            else if (timeLeft<episodeLenght)
            {
                Console.WriteLine($"You don't have enough time to watch {serailName}, you need {Math.Ceiling(episodeLenght-timeLeft)} more minutes.");
            }
        }
    }
}

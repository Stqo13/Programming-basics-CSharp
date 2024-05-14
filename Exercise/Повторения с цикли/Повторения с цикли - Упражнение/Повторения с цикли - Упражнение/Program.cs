using System;

namespace Повторения_с_цикли___Упражнение
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            zad1
            for (int i = 7; i <= 997; i++)
            {
                if (i%10==7)
                {
                    Console.WriteLine(i);
                }
            }
            
            zad2
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                sum += numbers;
                if (max<numbers)
                {
                    max = numbers;
                }
            }
            int sumWithoutMax = sum - max;
            if (max==sumWithoutMax)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = "+ max);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(max-sumWithoutMax));
            }
            
            zad3
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            int quantity = int.Parse(Console.ReadLine());
            int n = 0;
            for (int i = 1; i <=quantity; i++)
            {
                n = int.Parse(Console.ReadLine());
                if (n<200)
                {
                    p1++;
                    
                }
                else if (n>=200 && n<=399)
                {
                    p2++;
                    
                }
                else if (n>=400 && n<=599)
                {
                    p3++;
                    
                }
                else if (n>=600 && n<=799)
                {
                    p4++;
                    
                }
                else if (n>=800)
                {
                    p5++;
                    
                }
            }
            p1 = p1 / quantity * 100;
            p2 = p2 / quantity * 100;
            p3 = p3 / quantity * 100;
            p4 = p4 / quantity * 100;
            p5 = p5 / quantity * 100;
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
            
            zad4
            int age = int.Parse(Console.ReadLine());
            double washerPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int savedMoney = 0;
            int toyCount = 0;
            int finalToyPrice = 0;
            int totalSavings = 0;
            for (int i = 1; i <=age; i++)
            {
                if (i%2==0)
                {
                    savedMoney = savedMoney+((i *5) - 1);
                }
                else
                {
                    toyCount++;
                }
            }
            finalToyPrice = toyCount * toyPrice;
            totalSavings = savedMoney + finalToyPrice;
            if (totalSavings>=washerPrice)
            {
                Console.WriteLine($"Yes! {totalSavings-washerPrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washerPrice-totalSavings:f2}");
            }
            
            zad5
            int tabsOpen = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            for (int i = 0; i <=tabsOpen; i++)
            {
                string webName = Console.ReadLine();
                if (webName=="Facebook")
                {
                    salary -= 150;
                }
                else if (webName=="Instagram")
                {
                    salary -= 100;
                }
                else if (webName=="Reddit")
                {
                    salary -= 50;
                }
                else
                {
                    salary -= 0;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if (salary>0)
            {
                Console.WriteLine(salary);
            } 
            
            zad6
            string actorName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            double result = 0;
            int jury = int.Parse(Console.ReadLine());
            for (int i = 1; i <=jury ; i++)
            {
                string juryName = Console.ReadLine();
                int pointBonus = juryName.Length;        
                double juryPoints = double.Parse(Console.ReadLine());
                double finalJuryPoints = academyPoints+((pointBonus * juryPoints) / 2);
                result = finalJuryPoints;
                academyPoints = finalJuryPoints;
                if (result>1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {result:f1}!");
                    break;
                }
            }
            if (result<1250.5)
            {
                Console.WriteLine($"Sorry, {actorName} you need {(1250.5-result):f1} more!");
            }
            else if(result==1250.5)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {result:f1}!");
            }
            
            zad7
            int numOfGroups = int.Parse(Console.ReadLine());
            double musala = 0;
            double monblan = 0;
            double kilimanjaro = 0;
            double k2 = 0;
            double everest = 0;
            double allPeople = 0;
            for (int i = 1; i <=numOfGroups; i++)
            {
                int people = int.Parse(Console.ReadLine());
                if (people<=5)
                {
                    musala += people;
                }
                if (people>=6 && people <=12)
                {
                    monblan += people;
                }
                if (people >=13 && people <=25)
                {
                    kilimanjaro += people;
                }
                if (people >=26 && people <=40)
                {
                    k2 += people;
                }
                if(people>=41)
                {
                    everest += people; 
                }
                allPeople += people;
            }
            double p1= (musala / allPeople) * 100;
            double p2= (monblan / allPeople) * 100;
            double p3= (kilimanjaro / allPeople) * 100;
            double p4= (k2 / allPeople) * 100;
            double p5= (everest / allPeople) * 100;
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
            */
            int tournaments = int.Parse(Console.ReadLine());
            int starterPoints = int.Parse(Console.ReadLine());
            double W = 0;
            int F = 0;
            int SF = 0;
            int points = 0;
            for (int i = 0; i < tournaments; i++)
            {
                string situation = Console.ReadLine();
                if (situation=="W")
                {
                    starterPoints += 2000;
                    W++;
                }
                else if(situation=="F")
                {
                    starterPoints += 1200;
                    F++;
                }
                else if (situation=="SF")
                {
                    starterPoints += 720;
                    SF++;
                }
                points = starterPoints;
            }
            Console.WriteLine($"Final points: {points}");
            double Average = ((double)(W*2000 + F*1200 + SF*720) / tournaments);
            Console.WriteLine($"Average points: {Math.Floor(Average)}");
            double percentW = (W / tournaments) * 100;
            Console.WriteLine($"{percentW:f2}%");
        }
    }
}

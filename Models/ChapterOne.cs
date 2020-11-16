using System;
using System.Threading;

namespace AlgorithmChallengesCSharp.Models
{
    public class ChapterOne
    {
        public void SettingAndSwapping()
        {
            string myNumber = "42";
            string myName = "Bill";
            Console.WriteLine("Number: " + myNumber + " Name: " + myName);
            string temp = myNumber;
            myNumber = myName;
            myName = temp;
            Console.WriteLine("Number: " + myNumber + " Name: " + myName);
        }
        public void PrintNumbers()
        {
            for (int i = -52; i < 1067; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void BeCheerful()
        {
            for (int i = 0; i < 98; i++)
            {
                Console.WriteLine("Good Morning!");
            }
        }
        public void MultThrees()
        {
            for (int i = -300; i < -6; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        public void IntWhile()
        {
            int i = 2000;
            while (1999 < i && i < 5281)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        public void SayBirthday(int x, int y)
        {
            if (x == 6)
            {
                if (y == 23)
                {
                    Console.WriteLine("Thats my birthday! How did you know??");
                }
                else
                {
                    Console.WriteLine("Just another day...");
                }
            }
            else if (x == 23)
            {
                if (y == 6)
                {
                    Console.WriteLine("Thats my birthday! How did you know??");
                }
                else
                {
                    Console.WriteLine("Just another day...");
                }
            }
            else
            {
                Console.WriteLine("Just another day...");
            }
        }
        public void LeapYearCheck(int year)
        {
            if (year % 4 == 0)
            {
                if(year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine("" + year + " is a Leap Year");
                    }
                    else
                    {
                        Console.WriteLine("" + year + " is not a Leap Year");
                    }
                }
                else
                {
                    Console.WriteLine("" + year + " is not a Leap Year");
                }
            }
            else
            {
                Console.WriteLine("" + year + " is not a Leap Year");
            }
        }
        public void MultFives()
        {
            int count = 0;
            for (int i = 515; i < 4097; i += 5)
            {
                Console.WriteLine(i);
                count ++;
            }
            Console.WriteLine("Count: " + count);
        }
        public void MultSix()
        {
            int i = 6;
            while (i < 60001)
            {
                Console.WriteLine(i);
                i += 6;
            }
        }
        public void CountingDojo()
        {
            for (int i = 1; i < 41; i++)
            {
                if (i % 5 == 0)
                {
                    if (i % 10 == 0)
                    {
                        Console.WriteLine("Coding Dojo!");
                        Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.WriteLine("Coding");
                        Thread.Sleep(1000);
                    }
                }
                else
                {
                    Console.WriteLine(i);
                    Thread.Sleep(500);
                }
            }
        }
        public void KnowWhat(string incoming)
        {
            Console.WriteLine("" + incoming + ", do you know \"Counting Dojo\"?");
            Console.WriteLine();
            Thread.Sleep(1500);
            Console.WriteLine("What??");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("---Press Enter to start---");
            Console.ReadLine();
            Console.WriteLine("Let's start!");
            Thread.Sleep(1000);
            this.CountingDojo();
            Console.WriteLine();
            Console.WriteLine("And thats how you count Dojo, " + incoming + ". Hooray!!");
        }
        public void HugeNumberMaybe()
        {
            int sum = 0;
            for (int i = -299999; i < 300000; i += 2)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
        public void FoursCountdown()
        {
            int i = 2016;
            while (i > 0)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
                i -= 4;
            }
        }
        public void FlexibleCountdown(int low, int high, int mult)
        {
            for (int i = high; i >= low; i -= mult)
            {
                Console.WriteLine(i);
                Thread.Sleep(250);
            }
            Console.WriteLine();
            Console.WriteLine("Finish!!");
        }
        public void TheFinalCountdown(int mult, int start, int end, int skip)
        {
            int i = mult;
            while (mult < end)
            {
                if (mult > start)
                {
                    if (mult == skip)
                    {
                        Console.WriteLine("skip");
                    }
                    else 
                    {
                        Console.WriteLine(mult);
                    }
                }
                mult += i;
            }
        }
    }
}
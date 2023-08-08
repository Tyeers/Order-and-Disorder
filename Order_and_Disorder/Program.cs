using Order_and_Disorder;
using System;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Order_and_Disorder;

class Order_and_Disorder
{
    static void Main()
    {
        int count = 0;
        var Mathematic = new Random();

        static bool ExecuteWithTimeLimit(TimeSpan timeSpan, Action codeBlock)
        {
            try
            {
                Task task = Task.Factory.StartNew(() => codeBlock());
                task.Wait(timeSpan);
                return task.IsCompleted;
            }
            catch (AggregateException ae)
            {
                throw ae.InnerExceptions[0];
            }
        }

        Console.WriteLine();
        Console.WriteLine("                 -------------------------------------ATTENTION-------------------------------------");
        Console.WriteLine("                 |                                                                                 |");
        Console.WriteLine("                 |   1.    10 Maths Questions and 5 Moral Questions                                |");
        Console.WriteLine("                 |   2.    There would be 10 seconds to type your answer for each Maths problem    |");
        Console.WriteLine("                 |   3.    Hence you may think and type quickly                                    |");
        Console.WriteLine("                 |   4.    We'll gladly reveal the correct answer (for us) for each question       |");
        Console.WriteLine("                 |   5.    After every each question, we'll give you 3 seconds break               |");
        Console.WriteLine("                 |                                                                                 |");
        Console.WriteLine("                 -----------------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("Dare To Start?");
        Console.WriteLine("Y/N");
        string Red = Console.ReadLine();

        if ((Red == "N") || (Red == "n"))
        {
            Console.WriteLine("You're not too precipitant I see");
            Thread.Sleep(1500);
            Console.WriteLine("That's a good behaviour young man");
            Thread.Sleep(1500);
            Console.WriteLine("You may proceed to leave");
            Thread.Sleep(1500);
            Environment.ExitCode = 1;
        }
        else if ((Red == "Y") || (Red == "y"))
        {
            Console.WriteLine("You may proceed to clear out our test");
            Thread.Sleep(1500);
            Console.WriteLine("Don't be too precipitant young man");
            Thread.Sleep(1500);
            Console.WriteLine("Advice from us O young man, Think Twice and Be Wise");
            Console.WriteLine();

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine();
            Console.Write("Please input your name: ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Please input your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Choose: ");
            Console.WriteLine();
            Console.WriteLine("  1. Plus");
            Console.WriteLine("  2. Minus");
            int Mode = int.Parse(Console.ReadLine());

            Maths a = new Maths();
            Preparation k = new Preparation();

            for (int i = 0; i < 1; i++)

                if (Mode < 1)
                {
                    Console.WriteLine("     What are you doing?");
                    Environment.Exit(0);
                }

                else if (Mode == 1)
                {
                    k.R();

                    bool Completed = ExecuteWithTimeLimit(TimeSpan.FromMilliseconds(10000), () =>
                    {
                        Console.Write(value: a.x = Mathematic.Next(10, 100));
                        Console.Write(" + ");
                        Console.WriteLine(value: a.y = Mathematic.Next(10, 100));
                        int ANS = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        if (ANS != a.x + a.y)
                        {
                            Console.WriteLine(a.x + a.y);
                            Console.WriteLine();
                            Thread.Sleep(3000);
                        }
                        else if (ANS == a.x + a.y)
                        {
                            Console.WriteLine(a.x + a.y);
                            Console.WriteLine();
                            Thread.Sleep(3000);
                            ++count;
                        }
                    });
                }
                else if (Mode == 2)
                {

                    k.R();

                    bool Completed = ExecuteWithTimeLimit(TimeSpan.FromMilliseconds(10000), () =>
                    {
                        Console.Write(value: a.x = Mathematic.Next(10, 100));
                        Console.Write(" - ");
                        Console.WriteLine(value: a.y = Mathematic.Next(10, 100));
                        int ANS2 = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        if (ANS2 != a.x - a.y)
                        {
                            Console.WriteLine(a.x - a.y);
                            Console.WriteLine();
                            Thread.Sleep(3000);
                        }
                        else if (ANS2 == a.x - a.y)
                        {
                            Console.WriteLine(a.x - a.y);
                            Console.WriteLine();
                            Thread.Sleep(3000);
                            ++count;
                        }
                    });
                }
                else if ((Mode == 3) || (Mode > 3))
                {
                    Console.WriteLine("     What are you doing?");
                    Environment.Exit(0);
                }

            Console.WriteLine();

            if (count == 0)
            {
                Console.WriteLine("     I Cannot Say Anything For This...");
                Console.WriteLine("     Your Grade: " + count);
            }
            else if ((count > 0) && (count <= 5))
            {
                Console.WriteLine("     Better Than 0");
                Console.WriteLine("     Your Grade: " + count);
            }
            else if ((count > 5) && (count < 10))
            {
                Console.WriteLine("     Well Done");
                Console.WriteLine("     Your Grade: " + count);
            }
            else if (count == 10)
            {
                Console.WriteLine("     What An Immaculate Performance!");
                Console.WriteLine("     Your Grade: " + count);
            }
            else if (count > 10)
            {
                Console.WriteLine("     ...");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("     Just...");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("     Just How???");
                Console.WriteLine("     Your Grade: " + count);
            }

            //Moral Question

            Moral b = new Moral();

            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            Console.WriteLine("     Here's 5 Moral Questions");
            Console.WriteLine();
            Console.WriteLine("---------------------------------");

            b.Q1();
            b.Q2();
            b.Q3();
            b.Q4();
            b.Q5();

            if (b.KC == 1)
            {
                Thread.Sleep(1000);
                Console.WriteLine("That one was inevitable, but you really are a good person");
                Console.WriteLine();
            }
            else if ((b.KC > 1) && (b.KC <= 6))
            {
                Thread.Sleep(1000);
                Console.WriteLine("Dear " + name + ", why are you not just keep up your Kill Count?");
                Console.WriteLine();
            }
            else if ((b.KC > 6) && (b.KC <= 10))
            {
                Thread.Sleep(1000);
                Console.WriteLine("Dear " + name + ", really had the opportunity but you're not having it, pretty good...");
                Console.WriteLine();
                if ((age > 0) || (age <= 20))
                {
                    Console.WriteLine("By the age of " + age + ", You have a deadly thought");
                    Console.WriteLine("We recommend you to go to Psychiatrist");
                    Thread.Sleep(3000);
                    Console.WriteLine();
                    Console.WriteLine("Have a good time!");
                    Console.WriteLine();
                }
                else if ((age > 20) || (age <= 50))
                {
                    Console.WriteLine("By the age of " + age + ", You have a realistic thought");
                    Console.WriteLine("We recommend you to be more humble and generous");
                    Thread.Sleep(3000);
                    Console.WriteLine();
                    Console.WriteLine("Have a good time!");
                    Console.WriteLine();
                }
                else if ((age > 50 ) || (age <= 100))
                {
                    Console.WriteLine("By the age of " + age + ", You have a realistic thought");
                    Console.WriteLine("We recommend you to be more humble and generous");
                    Thread.Sleep(3000);
                    Console.WriteLine();
                    Console.WriteLine("Have a good time!");
                    Console.WriteLine();
                }
                else if (age > 100)
                {
                    Console.WriteLine("By the age of " + age + ", I cannot imagine how in the actual world you, " + name + " still breathing");
                    Console.WriteLine("By the way, I hope you pray more often");
                    Thread.Sleep(3000);
                    Console.WriteLine();
                    Console.WriteLine("Have a good time!");
                    Console.WriteLine();
                }
            }
            else if (b.KC == 11)
            {
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("Dear " + name + ", I like the way you think");
                Console.WriteLine();
                if ((age > 0) || (age <= 20))
                {
                    Console.WriteLine("By the age of " + age + ", You really have a deadly thought");
                    Console.WriteLine("We recommend you to go to Psychiatrist");
                    Thread.Sleep(3000);
                    Console.WriteLine();
                    Console.WriteLine("Have a good time!");
                    Console.WriteLine();
                }
                else if ((age > 20) || (age <= 50))
                {
                    Console.WriteLine("By the age of " + age + ", You have a deadly thought");
                    Console.WriteLine("We recommend you to go to Psychiatrist");
                    Thread.Sleep(3000);
                    Console.WriteLine();
                    Console.WriteLine("Have a good time!");
                    Console.WriteLine();
                }
                else if ((age > 50) || (age <= 100))
                {
                    Console.WriteLine("By the age of " + age + ", You have a deadly thought");
                    Console.WriteLine("We recommend you to go to Psychiatrist");
                    Thread.Sleep(3000);
                    Console.WriteLine();
                    Console.WriteLine("Have a good time!");
                    Console.WriteLine();
                }
                else if (age > 100)
                {
                    Console.WriteLine("By the age of " + age + ", I cannot imagine how in the actual world you, " + name + " still breathing");
                    Console.WriteLine("By the way, I hope you pray more often");
                    Thread.Sleep(3000);
                    Console.WriteLine();
                    Console.WriteLine("Have a good time!");
                    Console.WriteLine();
                }
            }
        }
    }
}
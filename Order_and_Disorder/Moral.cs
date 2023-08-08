using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_and_Disorder
{
    internal class Moral : Order_and_Disorder
    {
        internal int KC = 0;
        internal int kind= 0;

        public virtual void Q1()
        {
            Console.WriteLine();
            Console.WriteLine("1. If you saw a kid and an elderly person on the road and you're going so fast with your car, ");
            Console.WriteLine("   what you hit?");
            Console.WriteLine();
            Console.WriteLine("     1. Brake");
            Console.WriteLine("     2. Kid");
            Console.WriteLine("     3. Elderly Person");
            Console.WriteLine("     4. Drift");
            Console.WriteLine();
            int A1 = int.Parse(Console.ReadLine());

            if (A1 == 1)
            {
                Thread.Sleep(1000);
                Console.WriteLine("     You are right");
                ++kind;
            }
            else if (A1 == 2)
            {
                Thread.Sleep(1000);
                Console.WriteLine("     Brake, you hit the brake...");
                ++KC;
            }
            else if (A1 == 3)
            {
                Thread.Sleep(1000);
                Console.WriteLine("     Brake, you hit the brake...");
                ++KC;
            }
            else if (A1 == 4)
            {
                Thread.Sleep(1000);
                Console.WriteLine("     Bro, fr... You got 2 Kill Count");
                ++KC;
                ++KC;
            }
        }
        
        public virtual void Q2()
        {
            Console.WriteLine();
            Console.WriteLine("2. You saw a person on track 1 and 5 person on track 2, there's ongoing train that's going to ");
            Console.WriteLine("   one of the tracks. Which one you would save?");
            Console.WriteLine();
            Console.WriteLine("     1. 1 Person");
            Console.WriteLine("     2. 5 Person");
            Console.WriteLine();
            int A2 = int.Parse(Console.ReadLine());

            if (A2 == 1)
            {
                Thread.Sleep(1000);
                Console.WriteLine("     What?");
                for (int i = 0; i < 5; i++)
                {
                    ++KC;
                }
            }
            else if (A2 == 2)
            {
                Thread.Sleep(1000);
                Console.WriteLine("     5 is higher than 1 right?");
                ++KC;
            }
        }

        public virtual void Q3()
        {
            Console.WriteLine();
            Console.WriteLine("3. Help a homeless person or help a Trillionaire to kill someone for 1 Billion");
            Console.WriteLine();
            Console.WriteLine("     1. Help the homeless person");
            Console.WriteLine("     2. Help the Trillionaire");
            Console.WriteLine();
            int A3 = int.Parse(Console.ReadLine());

            if (A3 == 1)
            {
                Thread.Sleep(1000);
                Console.WriteLine("     What a generous and naive person you are...");
                ++kind;
            }
            else if (A3 == 2)
            {
                Thread.Sleep(1000);
                Console.WriteLine("     What a realistic person you are...");
                ++KC;
            }
        }

        public virtual void Q4()
        {
            Console.WriteLine();
            Console.WriteLine("4. Kill a Serial Killer or kill a killer?");
            Console.WriteLine();
            Console.WriteLine("     1. Serial Killer");
            Console.WriteLine("     2. Killer");
            Console.WriteLine("     3. Both");
            Console.WriteLine("     4. None");
            Console.WriteLine();
            int A4 = int.Parse(Console.ReadLine());

            if (A4 == 1)
            {
                Thread.Sleep(1000);
                Console.WriteLine("     You made yourself a killer, what a beautiful answer");
                ++KC;
            }
            else if (A4 == 2)
            {
                Thread.Sleep(1000);
                Console.WriteLine("     You made yourself a killer, what a beautiful answer");
                ++KC;
            }
            else if (A4 == 3)
            {
                Thread.Sleep(1000);
                Console.WriteLine("     I'm... glad you're 'not' recorded");
                ++KC;
                ++KC;
            }
            else if (A4 == 4)
            {
                Thread.Sleep(1000);
                Console.WriteLine("     You made a correct choice, let the authority handle them. Killer is a dangerous person.");
                ++kind;
            }
        }

        public virtual void Q5()
        {
            Console.WriteLine();
            Console.WriteLine("5. Use a dull knife to kill a person or use a 9mm Pistol to kill a person on their head");
            Console.WriteLine();
            Console.WriteLine("     1. Dull Knife");
            Console.WriteLine("     2. 9mm Pistol");
            Console.WriteLine("     3. Both (Knife First then Shoot)");
            Console.WriteLine("     4. Not Killing Anyone");
            Console.WriteLine();
            int A5 = int.Parse(Console.ReadLine());

            if (A5 == 1)
            {
                Thread.Sleep(1000);
                Console.WriteLine("     You want to see them suffer from the pain right?");
                ++KC;
                Console.WriteLine();
                Console.WriteLine("     Anyway, here's your Kill Count: " + KC);
                Console.WriteLine();
                Console.WriteLine("     Here's your correct answer: " + kind);
            }
            else if (A5 == 2)
            {
                Thread.Sleep(1000);
                Console.WriteLine("     A clean and fast method to kill");
                ++KC;
                Console.WriteLine();
                Console.WriteLine("     Anyway, here's your Kill Count: " + KC);
                Console.WriteLine();
                Console.WriteLine("     Here's your correct answer: " + kind);
            }
            else if (A5 == 3)
            {
                Thread.Sleep(1000);
                Console.WriteLine("     You want to see them suffer, when you saw it enough, you kill them with a Pistol");
                ++KC;
                Console.WriteLine();
                Console.WriteLine("     Anyway, here's your Kill Count: " + KC);
                Console.WriteLine();
                Console.WriteLine("     Here's your correct answer: " + kind);
            }
            else if (A5 == 4)
            {
                Thread.Sleep(1000);
                Console.WriteLine("     This is the correct answer");
                ++kind;
                Console.WriteLine();
                Console.WriteLine("     Anyway, here's your Kill Count: " + KC);
                Console.WriteLine();
                Console.WriteLine("     Here's your correct answer: " + kind);
            }
        }
    }
}

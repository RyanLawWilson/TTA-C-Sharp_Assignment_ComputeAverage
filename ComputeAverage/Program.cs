using System;

namespace ComputeAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program finds the average of two numbers!");
            System.Threading.Thread.Sleep(1000);

            Operations ops = new Operations();

            bool loop = true;
            while (loop)
            {
                int num1 = 0;
                // Get number 1
                bool badNumber1 = true;
                while (badNumber1)
                {
                    Console.Write("Enter integer 1:  ");
                    try
                    {
                        num1 = Convert.ToInt32(Console.ReadLine());
                        badNumber1 = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter an INTEGER, please...\n");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Unknown exception: {0}", e.GetType());
                    }
                }

                System.Threading.Thread.Sleep(150);

                // Get number 2
                Console.Write("Enter integer 2 (optional):  ");
                int num2 = 0;
                try
                {
                    num2 = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Using default value...\n");
                    num2 = ops.defaultNum;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unknown exception: {0}", e.GetType());
                }

                Console.WriteLine("The average of {0} and {1} is {2}\n", num1, num2, ops.Average(num1, num2));

                // Go again?
                Console.Write("Do you want to enter new numbers? (y or n) ");
                string loopChoice = Console.ReadLine();
                if (loopChoice != "y")
                {
                    loop = false;
                }
            }

            Console.WriteLine("See ya later!");
            Console.ReadLine();
        }
    }
}

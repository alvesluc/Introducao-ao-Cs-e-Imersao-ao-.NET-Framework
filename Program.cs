using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name = "Lucas";
            int age = 19;
            bool isLearning = true;

            Console.WriteLine(name + " is " + age + " years old.");

            try
            {
                if (isLearning)
                    Console.WriteLine("Trying my best!");
                else
                    throw new Exception("Something went wrong.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
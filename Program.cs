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

            if (isLearning)
                Console.WriteLine("Trying my best!");
            
            Console.ReadLine();
        }
    }
}
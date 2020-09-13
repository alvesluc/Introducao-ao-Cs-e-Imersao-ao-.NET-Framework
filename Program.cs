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

            var numbers = new int[] {1,2,3,4};

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

            Console.WriteLine("for");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("while");
            int iterator = 0;
            while (iterator < numbers.Length)
            {
                iterator++;
                Console.WriteLine(iterator);
            }

            Console.WriteLine("foreach");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}
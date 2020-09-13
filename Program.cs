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

            var numbers = NumberCollection();

            Interable(numbers);

            Console.ReadLine();
        }

        private static int[] NumberCollection()
        {
            return new int[] { 1, 2, 3, 4 };
        }
        private static void Interable(int[] numbers)
        {
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}

// Console.WriteLine(name + " is " + age + " years old.");

// try
// {
//     if (isLearning)
//         Console.WriteLine("Trying my best!");
//     else
//         throw new Exception("Something went wrong.");
// }
// catch (Exception e)
// {
//     Console.WriteLine(e.Message);
// }

// Console.WriteLine("for");
// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.WriteLine(i);
// }

// Console.WriteLine("while");
// int iterator = 0;
// while (iterator < numbers.Length)
// {
//     iterator++;
//     Console.WriteLine(iterator);
// }

// Console.WriteLine("foreach");
// foreach (var number in numbers)
// {
//     Console.WriteLine(number);
// }
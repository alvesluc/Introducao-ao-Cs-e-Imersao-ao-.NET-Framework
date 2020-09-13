using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DateTime date = new DateTime(2001, 5, 23);

            Console.WriteLine(date.ToString("dd/MM/yyyy"));
            Console.WriteLine(date.ToLongDateString());
            Console.WriteLine((DateTime.Today - new DateTime(2015, 1, 1)).Days);
            Console.WriteLine(DateTime.Today - TimeSpan.FromDays(2));

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


// var numbers = NumberCollection();
// Interable(numbers);

// double doublePrecision = 1.123412341234d;
// float floatPrecision = 1.1234123412341234f;
// decimal decimalPrecision = 1.1234123412341234m;

// Console.WriteLine(doublePrecision);
// Console.WriteLine(floatPrecision);
// Console.WriteLine(decimalPrecision);

// string name = "Lucas";
// int age = 19;
// bool isLearning = true;


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
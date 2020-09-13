using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> capitals = new Dictionary<string, string>();

            capitals.Add("PE", "Recife");
            capitals.Add("PB", "João Pessoa");
            capitals.Add("SP", "São Paulo");
            capitals.Add("RJ", "Rio de Janeiro");

            Console.WriteLine(capitals["PB"]);

            var capitalWithStartingR = capitals.Values.Where(capital => capital.StartsWith("R"));

            foreach (var capital in capitalWithStartingR)
            {
                Console.WriteLine(capital);
            }

            Dictionary<string, List<string>> citiesFromState = new Dictionary<string, List<string>>();

            citiesFromState.Add("PE", new List<string> { "Recife", "Goiana", "Carpina", "Condado" });

            List<string> citiesFromPernambuco = citiesFromState["PE"];

            foreach (var city in citiesFromPernambuco)
            {
                Console.WriteLine(city);
            }

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

// var names = new string[]
//             {
//                 "Lucas",
//                 "Luan",
//                 "Bonfim",
//                 "Sérgio"
//             };

// foreach (var name in names)
// {
//     Console.WriteLine(name);
// }

// var cities = new List<string>
//             {
//                 "Goiana",
//                 "Recife",
//                 "João Pessoa"
//             };

// cities.Add("São Paulo");
// cities.Add("Rosa Nova");
// cities.Add("São José");

// foreach (var city in cities)
// {
//     Console.WriteLine(city);
// }

// var filteredWithStartingR = from city in cities
//                             where city.StartsWith("R")
//                             select city;

// foreach (var city in filteredWithStartingR)
// {
//     Console.WriteLine(city);
// };

// var filteredWithStartingS = cities.Where(city => city.StartsWith("S"));

// foreach (var city in filteredWithStartingS)
// {
//     Console.WriteLine(city);
// };

// object[] parameters = { "Paraíba", 2020, 3944000, 56585 };

// string formatted = String.Format("{0} em {1}: população {2}, área {3:N2} m2", parameters);
// Console.WriteLine(formatted);

// DateTime date = new DateTime(2001, 5, 23);

// Console.WriteLine(date.ToString("dd/MM/yyyy"));
// Console.WriteLine(date.ToLongDateString());
// Console.WriteLine((DateTime.Today - new DateTime(2015, 1, 1)).Days);
// Console.WriteLine(DateTime.Today - TimeSpan.FromDays(2));

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
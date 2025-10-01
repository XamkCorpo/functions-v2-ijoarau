using System.Xml.Linq;

namespace FunctionAssigmentV1
{
    internal class Program
    {
        /// <summary>
        /// Ask for name and ensure it is not empty
        /// </summary>
        /// <returns> Returns name as string with excess white space removed </returns>
        static string AskName() 
        {
            while (true)
            {
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(name))
                    return name.Trim();

                Console.WriteLine("Name cannot be empty.");
            }
        }

        /// <summary>
        /// Ask for age and ensure it is a positive integer
        /// </summary>
        /// <returns> Returns age as an integer </returns>
        static int AskAge()
        {
            while (true)
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int age) && age > 0)
                    return age;

                Console.WriteLine("Please enter a positive integer.");
            }
        }

        /// <summary>
        /// Print name and age
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        static void PrintNameAndAge(string name, int age)
        {
            Console.WriteLine($"Your name is {name} and your age is {age}.");
        }

        /// <summary>
        /// Check if the user is an adult
        /// </summary>
        /// <param name="age"></param>
        /// <returns> Returns age over 18 </returns>
        static bool CheckAdult(int age)
        {
            return age >= 18;
        }

        /// <summary>
        /// Compare the name to another string (e.g., "Matti")
        /// </summary>
        /// <param name="name"></param>
        /// <param name="compareTo"></param>
        static void CompareName(string name, string compareTo)
        {
            // Comparison ignoring case
            if (name.Equals(compareTo, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine($"Your name matches {compareTo} (case-insensitive).");

            // Exact match comparison (case-sensitive)
            if (name.Equals(compareTo))
                Console.WriteLine($"Your name is exactly {compareTo} (case-sensitive).");
        }

        static void Main(string[] args)
        {
            string name = AskName();
            int age = AskAge();

            PrintNameAndAge(name, age);
            bool isFullAge = CheckAdult(age);

            if (isFullAge)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are not an adult.");
            }

            CompareName(name, "Matti");
        }
    }
}
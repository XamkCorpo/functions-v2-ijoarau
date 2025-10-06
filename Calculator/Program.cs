namespace Calculator
{
    internal class Program
    {
        /// <summary>
        /// Asks for a number which corresponds to an operation.
        /// </summary>
        /// <returns>--  Type of operation  --</returns>
        static int ChooseOperation()
        {
            Console.WriteLine("Choose mathematical operation (1: Addition, 2: Substraction, 3: Multiplication, 4: Division");
            while (true)
            {
                string operationAsString = Console.ReadLine();
                int.TryParse(operationAsString, out int operation);
                if (operation == 1 || operation == 2 || operation == 3 || operation == 4)
                    return operation;
                else
                    Console.WriteLine("Incorrect input. Please type a number between 1 and 4.");
                    continue;
            }
            
        }

        /// <summary>
        /// Asks for a number and checks its validity.
        /// </summary>
        /// <returns>--  Number to operate with  --</returns>
        static double AskNumber()
        {
            while (true)
            {
                string numberAsString = Console.ReadLine();
                if (double.TryParse(numberAsString, out double number))
                    return number;
                Console.WriteLine("Invalid input. Try again using arabic numerals.");
            }
        }

        /// <summary>
        /// Adds number one to number two.
        /// </summary>
        /// <param name="numberOne"></param>
        /// <param name="numberTwo"></param>
        /// <returns>--  Result  --/returns>
        static double Addition(double numberOne, double numberTwo)
        {
            double result = numberOne + numberTwo;
            return result;
        }

        /// <summary>
        /// Substracts number one with number two.
        /// </summary>
        /// <param name="numberOne"></param>
        /// <param name="numberTwo"></param>
        /// <returns>--  Result  --/returns>
        static double Substraction(double numberOne, double numberTwo)
        {
            double result = numberOne - numberTwo;
            return result;
        }

        /// <summary>
        /// Multiplies number one with number two.
        /// </summary>
        /// <param name="numberOne"></param>
        /// <param name="numberTwo"></param>
        /// <returns>--  Result  --/returns>
        static double Multiplication(double numberOne, double numberTwo)
        {
            double result = numberOne * numberTwo;
            return result;
        }

        /// <summary>
        /// Divides number one with number two.
        /// </summary>
        /// <param name="numberOne"></param>
        /// <param name="numberTwo"></param>
        /// <returns>--  Result  --/returns>
        static double Division(double numberOne, double numberTwo)
        {
            double result = numberOne / numberTwo;
            return result;
        }

        /// <summary>
        /// Prints out the entire calculation.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="numberOne"></param>
        /// <param name="numberTwo"></param>
        /// <param name="operation"></param>
        static void PrintResult(double result, double numberOne, double numberTwo, int operation)
        {
            string symbol; // Sets the appropriate symbol to print
            if (operation == 1)
            {
                symbol = "+";
            }
            else if (operation == 2)
            {
                symbol = "-";
            }
            else if (operation == 3)
            {
                symbol = "*";
            }
            else 
            {
                symbol = "/";
            }
            Console.WriteLine($"Result: {numberOne} {symbol} {numberTwo} = {result}");
        }

        static void Main(string[] args)
        {
            double result = 0;
            int operation = ChooseOperation();
            Console.Write("Input a number: ");
            double numberOne = AskNumber();
            Console.Write("Input a second number: ");
            double numberTwo = AskNumber();

            if (operation == 1)
                result = Addition(numberOne, numberTwo);
            else if (operation == 2)
                result = Substraction(numberOne, numberTwo);
            else if (operation == 3)
                result = Multiplication(numberOne, numberTwo);
            else
                result = Division(numberOne, numberTwo);

            PrintResult(result, numberOne, numberTwo, operation);
        }
    }
}

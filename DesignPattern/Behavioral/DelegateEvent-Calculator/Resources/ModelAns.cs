using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace DesignPattern.DelegateEvent_Calculator.Resources

{

    public delegate void MathOperationHandler(double result);

    public class MathOperations

    {

        public event MathOperationHandler AdditionPerformed;

        public event MathOperationHandler SubtractionPerformed;

        public event MathOperationHandler MultiplicationPerformed;

        public event MathOperationHandler DivisionPerformed;

        public void Add(double num1, double num2)

        {

            double result = num1 + num2;

            AdditionPerformed?.Invoke(result);

        }

        public void Subtract(double num1, double num2)

        {

            double result = num1 - num2;

            SubtractionPerformed?.Invoke(result);

        }

        public void Multiply(double num1, double num2)

        {

            double result = num1 * num2;

            MultiplicationPerformed?.Invoke(result);

        }

        public void Divide(double num1, double num2)

        {

            if (num2 != 0)

            {

                double result = num1 / num2;

                DivisionPerformed?.Invoke(result);

            }

            else

            {

                Console.WriteLine("Error: Division by zero is not allowed.");

            }

        }

    }

    public class ResultDisplay

    {

        public void AdditionHandler(double result)

        {

            Console.WriteLine($"Addition Result: {result}");

        }

        public void SubtractionHandler(double result)

        {

            Console.WriteLine($"Subtraction Result: {result}");

        }

        public void MultiplicationHandler(double result)

        {

            Console.WriteLine($"Multiplication Result: {result}");

        }

        public void DivisionHandler(double result)

        {

            Console.WriteLine($"Division Result: {result}");

        }

    }

    class Program1

    {

        static void Main()

        {

            MathOperations mathOperations = new MathOperations();

            ResultDisplay resultDisplay = new ResultDisplay();

            mathOperations.AdditionPerformed += resultDisplay.AdditionHandler;

            mathOperations.SubtractionPerformed += resultDisplay.SubtractionHandler;

            mathOperations.MultiplicationPerformed += resultDisplay.MultiplicationHandler;

            mathOperations.DivisionPerformed += resultDisplay.DivisionHandler;

            while (true)

            {

                Console.WriteLine("\nEnter the first number:");

                if (!double.TryParse(Console.ReadLine(), out double num1))

                {

                    Console.WriteLine("Invalid input. Please enter a valid number.");

                    continue;

                }

                Console.WriteLine("Enter the second number:");

                if (!double.TryParse(Console.ReadLine(), out double num2))

                {

                    Console.WriteLine("Invalid input. Please enter a valid number.");

                    continue;

                }

                Console.WriteLine("Select the operation (+, -, *, /) or 'exit' to end:");

                string operation = Console.ReadLine().ToLower();

                if (operation == "exit")

                    break;

                switch (operation)

                {

                    case "+":

                        mathOperations.Add(num1, num2);

                        break;

                    case "-":

                        mathOperations.Subtract(num1, num2);

                        break;

                    case "*":

                        mathOperations.Multiply(num1, num2);

                        break;

                    case "/":

                        mathOperations.Divide(num1, num2);

                        break;

                    default:

                        Console.WriteLine("Invalid operation. Please enter +, -, *, /, or exit.");

                        break;

                }

            }

        }

    }

}
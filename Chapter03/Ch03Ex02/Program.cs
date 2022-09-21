using System;

namespace Ch03Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber, secondNumber;
            string userName;
            Console.WriteLine("Enter your name:");
            userName = Console.ReadLine();
            Console.WriteLine("Now give me a number:");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now give me a second number:");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(
                $"The sum of {firstNumber} and {secondNumber} is: " +
                $"{firstNumber + secondNumber} \r\n" +
                $"The sum of subtracting {firstNumber} and {secondNumber} is: " +
                $"{firstNumber - secondNumber} \r\n" +
                $"The sum of multyplying {firstNumber} and {secondNumber} is: " +
                $"{firstNumber * secondNumber} \r\n" +
                $"The sum of dividing {firstNumber} and {secondNumber} is: " +
                $"{firstNumber / secondNumber}"
                );
            Console.WriteLine("Press ENTER to exit");
        }
    }
}

using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("첫번째 숫자를 입력하세요.");
            string userInput1 = Console.ReadLine();
            double num1 = double.Parse(userInput1);

            Console.WriteLine("두번째 숫자를 입력하세요.");
            string userInput2 = Console.ReadLine();
            double num2 = double.Parse(userInput2);

            Console.Write(num1);
            Console.Write(" + ");
            Console.Write(num2);
            Console.Write(" = ");
            Console.WriteLine(num1 + num2);
        }
    }
}

using System;

namespace DoorLock
{
    class Program
    {
        static void Main(string[] args)
        {
            int passCode1 = 6;
            int passCode2 = 2;

            Console.WriteLine("첫 번째 숫자를 넣어주세요.");
            int userInput1 = int.Parse(Console.ReadLine());
            Console.WriteLine("두 번째 숫자를 넣어주세요.");
            int userInput2 = int.Parse(Console.ReadLine());

            if (userInput1 == passCode1 && userInput2 == passCode2)
            {
                Console.WriteLine("문이 열렸습니다.");
            }

            // 기초문제 p.162
            // 6-3. 10등 미만이거나 90점을 초과하면 "A입니다."를 출력하는 프로그램 작성하기
            Console.WriteLine("등수를 입력하세요.");
            int rank = int.Parse(Console.ReadLine());
            Console.WriteLine("점수를 입력하세요");
            int score = int.Parse(Console.ReadLine());

            if (rank < 10 || score > 90) {
              Console.WriteLine("A입니다.");
            }

            // 심화문제 p.164
            // 6-1. [코드 6-3(p.136)]을 else if를 사용하도록 수정하고 나머지 연산 추가하기
            Console.WriteLine("첫 번째 숫자를 입력하세요.");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("두 번째 숫자를 입력하세요.");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("연산자를 입력하세요.");
            string oper = Console.ReadLine();

            if (oper == "+") {
              Console.WriteLine(num1 + num2);
            } else if (oper == "-") {
              Console.WriteLine(num1 - num2);
            } else if (oper == "*") {
              Console.WriteLine(num1 * num2);
            } else if (oper == "/") {
              Console.WriteLine(num1 / num2);
            } else if (oper == "%") {
              Console.WriteLine(num1 % num2);
            }

            // 6-2. 정수형 변수 userInput에 사용자의 입력을 받아서 userInput이 20보다 크고 3의 배수이면
            //      "20보다 큰 3의 배수입니다."를 출력하는 프로그램을 작성하세요.
            Console.WriteLine("숫자를 입력하세요.");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput > 20 && userInput % 3 == 0) {
              Console.WriteLine("20보다 큰 3의 배수입니다.");
            }
        }
    }
}

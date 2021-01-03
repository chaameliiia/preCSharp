using System;

namespace DoorLock_6Num
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] passCode = { 6, 2, 1, 9, 4, 7 };
            int[] userInput = new int[6];

            Console.WriteLine("첫 번째 숫자를 넣어주세요.");
            userInput[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("두 번째 숫자를 넣어주세요.");
            userInput[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("세 번째 숫자를 넣어주세요.");
            userInput[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("네 번째 숫자를 넣어주세요.");
            userInput[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("다섯 번째 숫자를 넣어주세요.");
            userInput[4] = int.Parse(Console.ReadLine());
            Console.WriteLine("여섯 번째 숫자를 넣어주세요.");
            userInput[5] = int.Parse(Console.ReadLine());

            if (userInput[0]== passCode[0] && userInput[1] == passCode[1] && userInput[2] == passCode[2]  
                && userInput[3] == passCode[3] && userInput[4] == passCode[4] && userInput[5] == passCode[5])
            {
                Console.WriteLine("문이 열렸습니다.");
            } else {
                Console.WriteLine("비밀번호가 틀렸습니다.");
            }
        }
    }
}

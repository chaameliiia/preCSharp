using System;

namespace DoorLock_6Num_Random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int passCodeLength = 6;
            int[] passCodeNum = new int[passCodeLength];

            Console.WriteLine("비밀번호: ");
            for (int i = 0; i < passCodeLength; i++)
            {
                passCodeNum[i] = random.Next(0, 10);
                Console.Write(passCodeNum[i]);
                Console.Write(" ");
            }
            Console.WriteLine();

            int[] userInput = new int[passCodeLength];
            while (true)
            {
                for (int passCodeIdx = 0; passCodeIdx < passCodeLength; passCodeIdx++)
                {
                    Console.Write(passCodeIdx + 1);
                    Console.WriteLine("번째 비밀번호를 넣어주세요.");
                    userInput[passCodeIdx] = int.Parse(Console.ReadLine());
                }
                bool isPassCodeCorrect = true;
                for (int passCodeIdx = 0; passCodeIdx < passCodeLength; passCodeIdx++)
                {
                    if (userInput[passCodeIdx] != passCodeNum[passCodeIdx])
                    {
                        isPassCodeCorrect = false;
                        Console.WriteLine("비밀번호가 틀렸습니다.");
                        break;
                    }
                }
                if (isPassCodeCorrect)
                {
                    Console.WriteLine("문이 열렸습니다.");
                    break;
                }
            }
        }
    }
}

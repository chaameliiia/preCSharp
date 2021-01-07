using System;

namespace DoorLock_6Num_For
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] passCode = { 6, 2, 1, 9, 4, 7 };
            int passCodeLength = 6;
            int[] userInput = new int[passCodeLength];

            for(int i = 0; i < 5; i++)
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
                    if (userInput[passCodeIdx] != passCode[passCodeIdx])
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
            */

            
            // 심화문제
            // 9-1. 비밀번호를 다섯 번만 입력할 수 있게 바꾸세요.

            // 9-2. 3학년에 5개의 반이 있고 한 반의 학생은 10명입니다. 각 반 학생들의 성적을 입력받아서
            //      반 별로 평균을 구하세요.
            int classesNum = 5;
            int[] classes = new int[classesNum];
            int studentsNum = 10;
            int[] score = new int [studentsNum];
            int total = 0;
            int average;

            for(int i = 0; i < classesNum; i++)
            {
                Console.Write(i + 1);
                Console.WriteLine("반");
                for (int j = 0; j < studentsNum; j++)
                {
                    Console.Write(j + 1);
                    Console.WriteLine("번째 학생의 성적을 입력하세요.");
                    score[j] = int.Parse(Console.ReadLine());
                    total += score[j];
                }
                Console.Write(i + 1);
                Console.Write("반의 평균 점수는 ");
                Console.Write(total / studentsNum);
                Console.WriteLine("입니다.");
                Console.WriteLine();
                Console.WriteLine();
                total = 0;
            }

        }
    }
}

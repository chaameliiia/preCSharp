using System;

namespace DoorRock_6Num_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] passCode = { 6, 2, 1, 9, 4, 7 };
            int[] userInput = new int[6];

            while (true)
            {
                int idx2 = 0;
                while (idx2 < 6)
                {
                    Console.Write(idx2 + 1);
                    Console.WriteLine("번째 비밀번호를 넣어주세요.");
                    userInput[idx2] = int.Parse(Console.ReadLine());
                    idx2 += 1;
                }

                if (userInput[0] == passCode[0] && userInput[1] == passCode[1] && userInput[2] == passCode[2]  
                    && userInput[3] == passCode[3] && userInput[4] == passCode[4] && userInput[5] == passCode[5])
                {
                    Console.WriteLine("문이 열렸습니다.");
                    break;
                }
                else
                {
                    Console.WriteLine("비밀번호가 틀렸습니다.");
                }
            }


            // 기초문제 p.232
            // 8-1. while문 사용하는 코드 작성
            int[] scores = new int[5];
            int subjCount = 0;
            int total = 0;

            while (subjCount < 5)
            {
                Console.Write(subjCount);
                Console.WriteLine("번째 과목의 성적을 입력하세요.");
                scores[subjCount] = int.Parse(Console.ReadLine());
                total += scores[subjCount];
                subjCount += 1;
            }
            Console.Write("총점은 ");
            Console.Write(total);
            Console.WriteLine("점입니다.");


            // 8-2. 코드 작성
            Console.WriteLine("수업을 몇 과목 들었습니까?");
            int subjectsCount = int.Parse(Console.ReadLine());

            int[] score = new int[subjectsCount];
            int idx = 0;
            int total1 = 0;

            while (idx < subjectsCount)
            {
                Console.Write(idx);
                Console.WriteLine("번째 과목의 성적을 입력하세요.");
                score[idx] = int.Parse(Console.ReadLine());
                total1 += score[idx];
                idx += 1;
            }

            Console.Write("평균은 ");
            Console.Write(total1 / subjectsCount);
            Console.WriteLine("점입니다.");


            // 8-3. 버그 수정
            Console.WriteLine("몇 명의 친구들에게 사과를 나눠줄까요?");
            int friendsCount = int.Parse(Console.ReadLine());
            
            int[] appleNum = new int[friendsCount];
            int index = 0;
            int total2 = 0;

            while (index < friendsCount)
            {
                Console.Write(index);
                Console.WriteLine("번째 친구가 가져갈 사과는 몇 개인가요?");
                appleNum[index] = int.Parse(Console.ReadLine());
                total2 += appleNum[index];
                index += 1;
            }

            Console.Write("친구들에게 ");
            Console.Write(total2);
            Console.WriteLine("개의 사과를 나눠줬습니다.");


            // 8-4. 다음 코드의 11번 줄을 while(userInput != "끝") 대신 while(true)를 사용하게 바꾸세요.
            string userInput1 = "";

            while(true)
            {
                Console.WriteLine("아무 글자나 입력하세요. 끝내려면 '끝'을 입력하세요.");
                userInput1 = Console.ReadLine();
                Console.WriteLine(userInput1);

                if(userInput1 == "끝")
                {
                  break;
                }
            }

            
            // 심화문제 p.236
            // 8-1. [코드 8-5(p.221)]에서 비밀번호 입력하는 부분을 while문을 사용하도록 수정하세요.
        }
    }
}
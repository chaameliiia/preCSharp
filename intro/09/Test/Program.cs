using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // 기초문제 p.273
            // 9-1. while문을 for문으로 바꾸기
            Console.WriteLine("몇 명의 친구들에게 사과를 나눠줄까요?");
            int friendCount = int.Parse(Console.ReadLine());
            int[] appleNum = new int[friendCount];

            for (int i = 0; i < friendCount; i++)
            {
                Console.Write(i + 1);
                Console.WriteLine("번째 친구가 가져갈 사과는 몇 개인가요?");
                appleNum[i] = int.Parse(Console.ReadLine());

                Console.Write(i + 1);
                Console.Write("번째 친구가 가져간 사과의 개수는 ");
                Console.Write(appleNum[i]);
                Console.WriteLine("입니다.");
                Console.WriteLine();
            }


            // 9-2. 다음 코드에서 반복되는 코드를 for문을 사용해서 수정
            int[] scores = new int[5];
            
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + 1);
                Console.WriteLine("번째 과목의 성적을 입력하세요.");
                scores[i] = int.Parse(Console.ReadLine());
            }

            int total = 0;
            Console.Write("총점은 ");
            for (int i = 0; i < 5; i++)
            {
                total += scores[i];
            }
            Console.Write(total);
            Console.WriteLine("점입니다.");


            // 9-3. 구구단 짝수단만 출력하세요.
            for (int i= 2; i < 9; i += 2)
            {
                Console.Write(i);
                Console.WriteLine("단");
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write(i);
                    Console.Write("x");
                    Console.Write(j);
                    Console.Write("=");
                    Console.WriteLine(i * j);
                }
                Console.WriteLine();
            }
        }
    }
}

using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // 기초문제 p.307
            // 10-1. 다음 랜덤에서 나올 수 있는 숫자를 전부 열거하세요.
            // 1) random.Next(3, 10): 3, 4, 5, 6, 7, 8, 9
            // 2) random.Next(-2, 4): -2, -1, 0, 1, 2, 3

            
            // 10-2. 5이상 60미만의 숫자를 생성하도록 로또번호 생성기 프로그램을 수정하세요.


            // 10-3. 8이상 50미만의 숫자를 무작위로 골라서 출력하는 코드 만들기
            /*
            Random random = new Random();

            int randomNum = random.Next(8, 50);

            Console.Write("고른 숫자: ");
            Console.WriteLine(randomNum);
            */


            // 심화문제
            // 10-1. 숫자 맞추기 게임을 만드세요. 규칙은 다으모가 같습니다.
            // 1) 수비수가 1이상 100이하의 숫자를 무작위로 고릅니다.
            // 2) 공격수가 숫자를 입력합니다.
            // 3) 만약 입력한 숫자가 수비수가 고른 숫자보다 크면 "더 작은 숫자입니다."를 출력.
            // 4) 만약 입력한 숫자가 수비수가 고른 숫자보다 작으면 "더 큰 숫자입니다."를 출력.
            // 5) 만약 입력한 숫자가 수비수가 고른 숫자와 같다면 "정답입니다"를 출력하고 종료
            // 6) 맞출 때까지 2)~5) 반복
            /*
            Random random = new Random();
            int answer = random.Next(1, 101);

            
            // Console.Write("정답: ");
            // Console.WriteLine(answer);
            // Console.WriteLine();
            

            Console.WriteLine("숫자 맞추기 게임을 시작합니다.");
            
            while(true)
            {
                Console.WriteLine("정답을 입력해주세요.");
                int userInput = int.Parse(Console.ReadLine());

                if (answer < userInput)
                {
                    Console.WriteLine("더 작은 숫자입니다.");
                }
                else if (answer > userInput)
                {
                    Console.WriteLine("더 큰 숫자입니다.");
                }
                else if (answer == userInput)
                {
                    Console.WriteLine("정답입니다.");
                    break;
                }
            }
            */


            // 10-2. 가위바위보 게임을 만드세요. 규칙은 다음과 같습니다.
            // 1) 1은 가위, 2는 바위, 3은 보입니다.
            // 2) 프로그램에서 1이상 3이하인 숫자를 무작위로 고릅니다.
            // 3) 사용자가 1, 2, 3 중에 하나의 숫자를 고릅니다
            // 4) 사용자가 지면 "졌습니다."를 출력
            // 5) 사용자가 이기면 "이겼습니다."를 출력
            // 6) 비기면 "비겼습니다."를 출력
            // 7) 비기면 2) ~ 6)을 반복

            while (true)
            {
                Random random = new Random();
                int defence = random.Next(1, 4);
                string[] kor = { "가위", "바위", "보" };
                Console.Write("수비수: ");
                Console.WriteLine(kor[defence - 1]);

                Console.WriteLine("공격할 숫자를 고르세요.(1: 가위, 2: 바위, 3: 보)");
                int attack = int.Parse(Console.ReadLine());
                while (true)
                {
                    if (attack > 3 && attack < 1)
                    {
                        Console.WriteLine("1~3사이의 숫자를 입력하세요.");
                        continue;
                    }
                }
                
                if (defence == attack) // 1 - 1 = 0
                {
                    Console.WriteLine("비겼습니다.");
                    continue;
                }

                if (defence == 1)
                {
                    if (defence - attack < 0) // 1 - 2 = -1
                    {
                        Console.WriteLine("이겼습니다.");
                        continue;
                    }
                    else // 1 - 3 = -2
                    {
                        Console.WriteLine("졌습니다.");
                        continue;
                    }
                }

                if (defence == 2)
                {
                    if (defence - attack == 1) // 2 - 1 = 1
                    {
                        Console.WriteLine("졌습니다.");
                        continue;
                    }
                    else // 2 - 3 = -1
                    {
                        Console.WriteLine("이겼습니다.");
                        continue;
                    }
                }

                if (defence == 3)
                {
                    if (defence - attack == 2) // 3 - 1 = 2
                    {
                        Console.WriteLine("졌습니다.");
                        continue;
                    }
                    else // 3 - 2 = -1
                    {
                        Console.WriteLine("이겼습니다.");
                        continue;
                    }
                }
            }
        }
    }
}
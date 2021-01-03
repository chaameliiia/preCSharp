using System;

namespace UltimateBaseball
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+-----------------------------------------------------+");
            Console.WriteLine("|                궁극의 숫자야구 게임                 |");
            Console.WriteLine("+-----------------------------------------------------+");
            Console.WriteLine("| 컴퓨터가 수비수가 되어 세 자릿수를 하나 골랐습니다. |");
            Console.WriteLine("| 각 숫자는 0~9 중에 하나며 중복되는 숫자는 없습니다. |");
            Console.WriteLine("| 모든 숫자와 위치를 맞히면 승리합니다.               |");
            Console.WriteLine("| 숫자와 순서가 둘 다 맞으면 스트라이크입니다.        |");
            Console.WriteLine("| 숫자만 맞고 순서가 틀리면 볼입니다.                 |");
            Console.WriteLine("| 숫자가 틀리면 아웃입니다.                           |");
            Console.WriteLine("+-----------------------------------------------------+");

            Console.WriteLine("> 수비수가 고른 숫자");
            int[] num = { 3, 1, 9 };
            Console.WriteLine(num[0]);
            Console.WriteLine(num[1]);
            Console.WriteLine(num[2]);

            int[] guess = new int[3];

            Console.WriteLine("> 첫번째 숫자를 입력하세요.");
            guess[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("> 두번째 숫자를 입력하세요.");
            guess[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("> 세번째 숫자를 입력하세요.");
            guess[2] = int.Parse(Console.ReadLine());

            Console.WriteLine("> 공격수가 고른 숫자");
            Console.WriteLine(guess[0]);
            Console.WriteLine(guess[1]);
            Console.WriteLine(guess[2]);

            if (guess[0] == guess[1] || guess[0] == guess[2] || guess[2] == guess[1]) {
              Console.WriteLine("같은 숫자를 입력하면 안 됩니다.");
            } else {
                int countStrike = 0;
                int countBall = 0;

                if (guess[0] == num[0]) {
                  countStrike = countStrike + 1;
                } else if (guess[0] == num[1] || guess[0] == num[2]) {
                  countBall = countBall + 1;
                }

                if (guess[1] == num[1]) {
                  countStrike = countStrike + 1;
                } else if (guess[1] == num[0] || guess[1] == num[2]) {
                  countBall = countBall + 1;
                }

                if (guess[2] == num[2]) {
                  countStrike = countStrike + 1;
                } else if (guess[2] == num[0] || guess[2] == num[1]) {
                  countBall = countBall + 1;
                }

                Console.Write("스트라이크: ");
                Console.WriteLine(countStrike);
                Console.Write("볼: ");
                Console.WriteLine(countBall);
                Console.Write("아웃: ");
                Console.WriteLine(3 - countStrike - countBall);
            }
        }
    }
}
using System;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string appleCountDescription = "바구니 안에 담긴 사과의 갯수: ";
            Console.Write(appleCountDescription);
            int appleCount = 12;
            Console.WriteLine(appleCount);

            appleCount = appleCount - 2;
            appleCountDescription = "내가 먹고 난 뒤에 " + appleCountDescription;

            Console.Write(appleCountDescription);
            Console.WriteLine(appleCount);

            // 기초문제 p.98
            // 4-1. 다음 사칙연산의 결과를 출력하는 코드를 작성하세요.(결과만 출력)
            // 1. 10 + 5
            // 2. 20 - 10
            // 3. 4 x 7
            // 4. 20 / 7의 몫과 나머지

            int num = 10 + 5;
            Console.WriteLine(num);

            num = 20 - 10;
            Console.WriteLine(num);

            num = 4 * 7;
            Console.WriteLine(num);

            num = 20 / 7;
            Console.WriteLine(num);

            num = 20 % 7;
            Console.WriteLine(num);


            // 4-2. "안녕" + "하세요"의 결과를 출력하는 코드를 작성하세요.
            string str1 = "안녕" + "하세요";
            Console.WriteLine(str1);


            // 4-3. 다음 코드의 결과 예상
            // 25 16 1 12 4
            int num1 = 20;
            int num2 = 5;
            int num3 = 3;
            int num4 = 13;
            int num5;

            num1 = num1 + num2;
            num2 = num3 + num4;
            num4 = num1 - num4;
            num3 = num2 / num4;
            num5 = num2 % num4;

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.WriteLine(num5);

            // 4-4. (4 - 2) * 16 + 2를 구하기 위한 코드 작성
            int num6 = 4 - 2;
            num6 = num6 * 16;
            num6 = num6 + 2;

            Console.WriteLine("(4 - 2) * 16 + 2");
            Console.WriteLine(num6);


            // 심화문제
            // 4-1. 중단점과 자동 창, 로컬 창, 조사식 창을 이용해서
            //      아래 코드에서 변수 num7의 값이 어떻게 변하는지 확인해보세요.(총 4번 변함)
            int num7 = 2;
            num7 = num7 * 3;
            num7 = num7 - 4;
            num7 = num7 % 2;

            Console.WriteLine(num7);

            // 4-2. 주머니에 동전이 10개 들어있습니다 아람이에게 원하는 만큼 동전을 가져가라고 하니
            //      손을 넣어 절반을 가져가더니 죄책감을 느꼈는지 1개를 도로 넣습니다. 그 다음에는
            //      우람이가 남은 동전의 절반을 꺼내더니 충분치 못했다 생각했던지 2개를 더 꺼내 갑니다.
            //      아람이가 가져간 동전과 우람이가 가져간 동전, 그리고 주머니에 남은 동전이 몇 개인지
            //      출력하는 프로그램을 작성하세요.
            int coinPocket = 10;
            int coinAram = coinPocket / 2;
            coinAram = coinAram - 1;
            Console.Write("아람이가 가져간 동전: ");
            Console.WriteLine(coinAram);

            coinPocket = coinPocket - coinAram;

            int coinWooram = coinPocket / 2;
            coinWooram = coinWooram  + 2 ;
            Console.Write("우람이가 가져간 동전: ");
            Console.WriteLine(coinWooram);

            coinPocket = coinPocket - coinWooram;
            Console.Write("주머니에 남은 동전: ");
            Console.WriteLine(coinPocket);

        }
    }
}

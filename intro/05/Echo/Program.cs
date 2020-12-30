using System;

namespace Echo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("글자를 입력하고 엔터 키를 누르세요.");
            string userInput = Console.ReadLine();

            Console.Write("입력한 글은 ");
            Console.Write(userInput);
            Console.WriteLine("입니다.");

            // 기초문제 p.122
            // 5-1. 코드 완성시키기
            Console.WriteLine("첫번째 숫자를 입력하세요.");
            string userInput1 = Console.ReadLine();
            int num1 = int.Parse(userInput1);
            Console.WriteLine("두번째 숫자를 입력하세요.");
            string userInput2 = Console.ReadLine();
            int num2 = int.Parse(userInput2);

            Console.Write(num1);
            Console.Write(" + ");
            Console.Write(num2);
            Console.Write(" = ");
            Console.WriteLine(num1 + num2);


            // 5-2. 버그 고치기
            Console.WriteLine("첫번째 숫자를 입력하세요.");
            string userInput3 = Console.ReadLine();
            Console.WriteLine("두번째 숫자를 입력하세요.");
            string userInput4 = Console.ReadLine();
            int num3 = int.Parse(userInput3);
            int num4 = int.Parse(userInput4);

            Console.WriteLine(num3 - num4);


            // 5-3. 문자열형 변수 userInput 없애기
            Console.WriteLine("첫번째 숫자를 입력하세요.");
            double num = int.Parse(Console.ReadLine());
            Console.Write("입력한 숫자는 ");
            Console.WriteLine(num);


            // 심화문제 p.124
            // 5-1. 문자열 userInput5와 userInput6을 키보드 입력으로 받아 실수 num5와 num6으로 변환한 다음,
            //      사칙연산(+, -, *, /)의 결과를 각각 화면에 출력하는 프로그램을 작성하세요.
            Console.WriteLine("첫번째 숫자를 입력하세요");
            string userInput5 = Console.ReadLine();
            double num5 = int.Parse(userInput5);
            Console.WriteLine("두번째 숫자를 입력하세요");
            string userInput6 = Console.ReadLine();
            double num6 = int.Parse(userInput6);

            Console.Write("더하기: ");
            Console.WriteLine(num5 + num6);
            Console.Write("빼기: ");
            Console.WriteLine(num5 - num6);
            Console.Write("곱하기: ");
            Console.WriteLine(num5 * num6);
            Console.Write("나누기: ");
            Console.WriteLine(num5 / num6);


            // 5-2. 위의 나누기 분모에 0을 넣을 때 결과는? 0
            

            // 5-3. 동전이 10개 들어있는 주머니가 있습니다. 어머니께서 주머니에 동전을 몇 개 더 넣고
            //      아람이와 우람이에게 원하는 만큼 동전을 가져가라고 할 겁니다. 이것을 프로그램으로 작성하세요.
            //      프로그램이 실행되면 우선 주머니에 들어있는 동전의 갯수를 출력하고 어머니께서 넣을
            //      동전의 갯수와 아람이, 우람이가 꺼낼 동전의 객ㄱ수를 키보드 입력으로 받습니다.
            //      그 다음, 주머니에 남아있는 동전의 객수를 계산해서 화면에 출력하면 됩니다.
            Console.WriteLine("주머니에는 동전이 10개 들어있습니다.");
            int coinPocket = 10;
            Console.WriteLine("어머니는 몇 개의 동전을 주머니에 넣었나요?");
            int coinMom = int.Parse(Console.ReadLine());
            Console.WriteLine("아람이는 몇 개의 동전을 꺼냈나요?");
            int coinAr = int.Parse(Console.ReadLine());
            Console.WriteLine("우람이는 몇 개의 동전을 꺼냈나요?");
            int coinWr = int.Parse(Console.ReadLine());

            Console.Write("주머니에 남아있는 동전의 갯수는 ");
            Console.Write(coinPocket + coinMom - coinAr - coinWr);
            Console.WriteLine("개입니다.");
        }
    }
}
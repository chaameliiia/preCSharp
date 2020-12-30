using System;

namespace ConsoleWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WriteLine을 쓰면");
            Console.WriteLine("한 줄 씩 나옵니다.");
            Console.Write("Write는 아닙니다.");
            Console.Write("이어져서 나오죠?");
            Console.WriteLine("Write 뒤에 WriteLine을 썼습니다.");

            Console.Write("바구니 안에 담긴 사과의 갯수: ");
            Console.WriteLine(12);

            Console.Write("사과 바구니의 무게: ");
            Console.WriteLine(1.32);

            Console.WriteLine("!!?%$&");

            Console.WriteLine("큰따옴표\" 출력"); // 큰따옴표 출력
            Console.WriteLine("\\\'\"");

            // 기초문제 p.44
            // 2-1. 함수를 다섯 번 호출해서 다음 실행 화면처럼 콘솔 창에 네 줄을 출력하세요.
            //      함수는 꼭 다섯 번 호출해야 합니다.
            Console.WriteLine("Hello C#");
            Console.Write("10+10 =");
            Console.WriteLine(20);
            Console.WriteLine("C#의 세계에 오신 것을 환영합니다.");
            Console.WriteLine("감사합니다.");

            // 2-2. 다음 코드를 실행하면 어떤 결과가 나올까요? 실행화면에 예상 내용을 적어보세요.
            Console.WriteLine("출력문");
            Console.Write("abcde");
            Console.Write("가나다라마");
            Console.WriteLine("qwerty");
            // 출력문
            // abcde가나다라마qwerty
            // 계속하려면 ...

            // 2-3. 다음 문장을 출력하려고 합니다. '출력문" 기초문제'
            // 어떤 코드를 넣어야 할까요?
            Console.Write("출력");
            Console.Write("문");
            Console.Write("\" ");
            Console.Write("기초");
            Console.WriteLine("문제");


            // 심화문제 p.46
            // 2-1. 코드의 오류를 고치세요.
            Console.Write("무엇이 무엇이");
            Console.WriteLine("문제일까?");
            Console.Write("\" ");

            // 2-2. 다음 결과를 출력하세요.
            // ?!"
            // """"""
            Console.WriteLine("?!\"");
            Console.WriteLine("\"\"\"\"\"\"");
        }
    }
}

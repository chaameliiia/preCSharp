using System;

namespace Constant
{
    class Program
    {
        static void Main(string[] args)
        {
            string appleCountDescription = "바구니 안에 담긴 사과의 갯수: ";
            Console.Write(appleCountDescription);
            int appleCount = 12;
            Console.WriteLine(appleCount);

            Console.WriteLine(-2);

            string basketWeightDescription = "사과 바구니의 무게: ";
            Console.Write(basketWeightDescription);
            double basketWeight = 1.32;
            Console.WriteLine(basketWeight);

            
            // 기초문제
            // 3-2. 다음 코드를 실행하면 어떤 결과가 나올까?
            // 이름: 홍길동
            // 나이 23

            string name = "홍길동";
            Console.Write("이름: ");
            Console.WriteLine(name);

            int age = 23;
            Console.Write("나이: ");
            Console.WriteLine(age);

            // 3-3. 다음 실행 화면처럼 출력하는 코드
            // 문자열 출력
            // 23.31
            // 출력 성공

            string stringOut = "문자열 출력";
            Console.WriteLine(stringOut);

            double num1 = 23.31;
            Console.WriteLine(num1);

            string success = "출력 성공";
            Console.WriteLine(success);

            // 심화문제
            // 3-1. 상수에 이름을 붙이고 그 이름을 사용하기
            int num2 = 286;
            double num3 = 3.141592;
            string strExist = "문자열도 있음";

            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(strExist);

            // 3-2. 오류 수정
            double num4 = 22.7;
            Console.WriteLine(num4);

            int num5 = -13;
            Console.WriteLine(num5);
        }
    }
}
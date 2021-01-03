using System;

namespace StudentsList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("학생 숫자를 입력하세요");
            int studentsCount = int.Parse(Console.ReadLine());

            int[] ages = new int[studentsCount];
            string[] names = new string[studentsCount];
            double[] heights = new double[studentsCount];
            double[] weights = new double[studentsCount];

            Console.WriteLine("몇 번째 학생의 정보를 추가할까요?");
            int studentsNum = int.Parse(Console.ReadLine());

            if (studentsNum >= 0 && studentsNum <= studentsCount - 1)
            {
                Console.WriteLine("나이를 입력하세요.");
                ages[studentsNum] = int.Parse(Console.ReadLine());

                Console.WriteLine("이름을 입력하세요.");
                names[studentsNum] = Console.ReadLine();

                Console.WriteLine("키를 입력하세요.");
                heights[studentsNum] = double.Parse(Console.ReadLine());

                Console.WriteLine("몸무게를 입력하세요.");
                weights[studentsNum] = double.Parse(Console.ReadLine());

                Console.Write(studentsNum);
                Console.WriteLine("번째 학생");
                Console.Write("이름: ");
                Console.WriteLine(names[studentsNum]);
                Console.Write("나이: ");
                Console.WriteLine(ages[studentsNum]);
                Console.Write("키: ");
                Console.WriteLine(heights[studentsNum]);
                Console.Write("몸무게: ");
                Console.WriteLine(weights[studentsNum]);
            }
            else
            {
                Console.Write("0에서 ");
                Console.Write(studentsCount - 1);
                Console.WriteLine("사이의 숫자를 입력하세요.");
            }


            // 기초문제 p.191
            // 7-1. 배열을 사용해서 코드 작성하기
            double[] weight = new double[3];
            weight[0] = double.Parse(Console.ReadLine());
            weight[1] = double.Parse(Console.ReadLine());
            weight[2] = double.Parse(Console.ReadLine());

            Console.Write("첫 번째 무게: ");
            Console.WriteLine(weight[0]);
            Console.Write("두 번째 무게: ");
            Console.WriteLine(weight[1]);
            Console.Write("세 번째 무게: ");
            Console.WriteLine(weight[2]);


            // 7-2. 배열 사용해서 코드 작성하기
            string[] studentsName = { "홍길동", "김철수", "이영희" };
            
            Console.WriteLine(studentsName[0]);
            Console.WriteLine(studentsName[1]);
            Console.WriteLine(studentsName[2]);


            // 7-3. 버그 수정하기
            // int[] scores = { 90, 85, 73, 100 };
            
            // Console.WriteLine(scores[0]);
            // Console.WriteLine(scores[1]);
            // Console.WriteLine(scores[2]);
            // Console.WriteLine(scores[3]);


            // 7-4. 코드 작성하기
            // string[] subjects = { "국어", "영어", "수학" };
            // int[] score = new int[3];

            // Console.Write(subjects[0]);
            // Console.WriteLine(" 점수를 입력하세요.");
            // score[0] = int.Parse(Console.ReadLine());

            // Console.Write(subjects[1]);
            // Console.WriteLine(" 점수를 입력하세요.");
            // score[1] = int.Parse(Console.ReadLine());

            // Console.Write(subjects[2]);
            // Console.WriteLine(" 점수를 입력하세요.");
            // score[2] = int.Parse(Console.ReadLine());

            // Console.Write(subjects[0]);
            // Console.Write(" 점수: ");
            // Console.WriteLine(score[0]);

            // Console.Write(subjects[1]);
            // Console.Write(" 점수: ");
            // Console.WriteLine(score[1]);

            // Console.Write(subjects[2]);
            // Console.Write(" 점수: ");
            // Console.WriteLine(score[2]);


            // 심화문제 p. 195
            // 7-2. 국어, 영어, 수학, 과학, 사회 점수를 입력받아서 총점과 평균을 구하는 프로그램 작성하기
            string[] subjects = { "국어", "영어", "수학", "과학", "사회" };
            int[] scores = new int[5];

            Console.Write(subjects[0]);
            Console.WriteLine(" 점수를 입력하세요.");
            scores[0] = int.Parse(Console.ReadLine());

            Console.Write(subjects[1]);
            Console.WriteLine(" 점수를 입력하세요.");
            scores[1] = int.Parse(Console.ReadLine());

            Console.Write(subjects[2]);
            Console.WriteLine(" 점수를 입력하세요.");
            scores[2] = int.Parse(Console.ReadLine());

            Console.Write(subjects[3]);
            Console.WriteLine(" 점수를 입력하세요.");
            scores[3] = int.Parse(Console.ReadLine());

            Console.Write(subjects[4]);
            Console.WriteLine(" 점수를 입력하세요.");
            scores[4] = int.Parse(Console.ReadLine());

            int total = scores[0] + scores[1] + scores[2] + scores[3] + scores[4];
            double average = total / 5;

            Console.Write(subjects[0]);
            Console.Write(" 점수: ");
            Console.WriteLine(scores[0]);

            Console.Write(subjects[1]);
            Console.Write(" 점수: ");
            Console.WriteLine(scores[1]);

            Console.Write(subjects[2]);
            Console.Write(" 점수: ");
            Console.WriteLine(scores[2]);

            Console.Write(subjects[3]);
            Console.Write(" 점수: ");
            Console.WriteLine(scores[3]);

            Console.Write(subjects[4]);
            Console.Write(" 점수: ");
            Console.WriteLine(scores[4]);

            Console.Write("총점: ");
            Console.WriteLine(total);
            Console.Write("평균: ");
            Console.WriteLine(average);
        }
    }
}
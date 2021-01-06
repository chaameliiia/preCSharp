using System;

namespace _8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("총 학생 수를 입력하세요.");
            int studentsNum = int.Parse(Console.ReadLine());
            string[] subjects = { "국어", "영어", "수학" };
            int[] students = new int[3];
            int total = 0;
            int studentsIdx = 0;
            int subjectsIdx = 0;

            while (studentsIdx < studentsNum)
            {
                double average;
                Console.Write(studentsIdx + 1);
                Console.Write("번째 학생의 ");

                while (subjectsIdx < 3)
                {
                    Console.Write(subjects[subjectsIdx]);
                    Console.WriteLine("과목의 점수를 입력해주세요.");
                    students[subjectsIdx] = int.Parse(Console.ReadLine());
                    total += students[subjectsIdx];
                    subjectsIdx++;
                }

                
                Console.Write(studentsIdx + 1);
                Console.Write("번째 학생의 총점은 ");
                Console.Write(total);
                Console.WriteLine("점입니다.");

                Console.Write(studentsIdx + 1);
                Console.Write("번째 학생의 평균은 ");
                average = total / studentsNum;
                Console.Write(average);
                Console.WriteLine("점입니다.");
                Console.WriteLine(" ");

                subjectsIdx = 0;
                total = 0;
                studentsIdx++;
            }
        }
    }
}

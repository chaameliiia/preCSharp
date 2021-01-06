using System;

namespace StudentsList_While
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

            int studentsNum = 0;
            while (studentsNum < studentsCount) 
            {
                Console.Write(studentsNum);
                Console.WriteLine(" 번째 학생의 정보를 입력하세요");

                Console.WriteLine("나이를 입력하세요.");
                ages[studentsNum] = int.Parse(Console.ReadLine());

                Console.WriteLine("이름을 입력하세요.");
                names[studentsNum] = Console.ReadLine();

                Console.WriteLine("키를 입력하세요.");
                heights[studentsNum] = double.Parse(Console.ReadLine());

                Console.WriteLine("몸무게를 입력하세요.");
                weights[studentsNum] = double.Parse(Console.ReadLine());

                studentsNum = studentsNum + 1;
            }
            
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("입력된 학생정보를 출력할 차례입니다.");
            
            studentsNum = 0;

            while (studentsNum < studentsCount)
            {
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

                studentsNum = studentsNum + 1;
            }
        }
    }
}

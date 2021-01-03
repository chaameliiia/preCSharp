using System;

namespace ComparisonOper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("10 > 10은 ");
            Console.WriteLine(10 > 10); // 거짓

            Console.Write("10 >= 10은 ");
            Console.WriteLine(10 >= 10); // 참

            Console.Write("5 < 10은 ");
            Console.WriteLine(5 < 10); // 참

            Console.Write("5 <= 10은 ");
            Console.WriteLine(5 <= 10); // 참

            Console.Write("5 == 4는 ");
            Console.WriteLine(5 == 4); // 거짓

            Console.Write("5 != 4는 ");
            Console.WriteLine(5 != 4); // 참

        }
    }
}

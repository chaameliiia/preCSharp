using System;

namespace LottoGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int lottoLength = 6;
            int[] lottoNum = new int[lottoLength];

            Random random = new Random();

            int lottoNumIdx = 0;
            
            while (lottoNumIdx < lottoLength)
            {
                lottoNum[lottoNumIdx] = random.Next(5, 60);

                bool hasDuplicate = false;

                for (int i = 0; i < lottoNumIdx; i++)
                {
                   if (lottoNum[lottoNumIdx] == lottoNum[i])
                    {
                        hasDuplicate = true;
                        break;
                    }
                }

                if (!hasDuplicate)
                {
                    lottoNumIdx++;
                }
            }

            Console.Write("로또 번호: ");
            for (int i = 0; i < lottoLength; i++)
            {
                Console.Write(lottoNum[i]);
                Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}

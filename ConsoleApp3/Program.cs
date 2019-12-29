using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int classcount = 0;classcount<5;classcount++)
            {
                Console.Write(classcount);
                Console.Write("반의 성적 관리표입니다.");

                int[] scores = new int[10];
                for(int student = 0; student<10; student++)
                {
                    Console.Write(student);
                    Console.WriteLine("번의 성적을 입력하세요.");
                    scores[student] = int.Parse(Console.ReadLine());
                }
                Console.Write(classcount);
                Console.Write("반의 평균은 ");
                Console.Write((scores[0] + scores[1] + scores[2] + scores[3] + scores[4] + scores[5] + scores[6] + scores[7] + scores[8] + scores[9]) / 10);
                Console.WriteLine("입니다.");
            }
           
        }
    }
}

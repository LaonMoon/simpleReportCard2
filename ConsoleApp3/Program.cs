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
                int total = 0;

                for(int student = 0; student<10; student++)
                {
                    Console.Write(student);
                    Console.WriteLine("번의 성적을 입력하세요.");
                    scores[student] = int.Parse(Console.ReadLine());
                    total = total + scores[student];
                }

                Console.Write(classcount);
                Console.Write("반의 평균은 ");
                Console.Write(total / 10);
                Console.WriteLine("입니다.");
            }
           
        }
    }
}

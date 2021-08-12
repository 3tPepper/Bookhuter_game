using System;

namespace TheBookHunter
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Tutorial tutorial = new Tutorial();
            tutorial.GuideStart(player);
            //TODO: 진행 시작
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t┌──────────────────────────────────────────────┐");
            Console.WriteLine("\t│                                              │");
            Console.WriteLine("\t│                                              │");
            Console.WriteLine("\t│    깊고, 춥고, 텅 빈 곳                      │");
            Console.WriteLine("\t│    그림자 위에 그림자들이 겹치는 곳          │");
            Console.WriteLine("\t│    오래된 책들이                             │");
            Console.WriteLine("\t│    아직 나무였던 시절을                      │");
            Console.WriteLine("\t│    석탄이 다이아몬드를 낳던 때를             │");
            Console.WriteLine("\t│    빛도 은총도 모르던 때를                   │");
            Console.WriteLine("\t│    꿈꾸는 곳                                 │");
            Console.WriteLine("\t│    그곳이 바로 그림자 제왕이라 불리는        │");
            Console.WriteLine("\t│    정령이 다스리는 곳이다.                   │");
            Console.WriteLine("\t│                                              │");
            Console.WriteLine("\t│    \t발터 뫼르스, <꿈꾸는 책들의 도시> 발췌.│");
            Console.WriteLine("\t│                                              │");
            Console.WriteLine("\t│                                              │");
            Console.WriteLine("\t└──────────────────────────────────────────────┘\n\n\n");
            Console.WriteLine();
        }
    }
}

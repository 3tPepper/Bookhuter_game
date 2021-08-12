using System;

namespace TheBookHunter
{
    class Program
    {
        static bool continued = true;
        static void Main(string[] args)
        {
            Player player = new Player();
            Tutorial tutorial = new Tutorial();
            Books books = new Books();
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
            Console.ReadLine();

            Program program = new Program();

            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("▶ 지하묘지. 여기서부터 이야기는 시작된다.");
            while (continued == true)
            {
                program.Catacom(player, books);  
            }

            if(continued == false)
            {
                //TODO: 종료 스크립트
            }
        }

        public void Catacom(Player player, Books books)
        {
            Console.WriteLine();
            Console.WriteLine("▶ 무엇을 할까.");
            Console.WriteLine("1: 앞으로 나아가자");
            Console.WriteLine("2: 도시로 돌아가자(게임 종료)");
            Console.WriteLine("3: 현재 상태 점검");
            string choose = Console.ReadLine();
            Console.WriteLine();

            if (choose == "1")
            {
                //TODO
            }
            else if(choose == "2")
            {
                //TODO
            }
            else if(choose == "3")
            {
                //TODO 현재 상태 점검
                Status(player, books);
            }
            else
            {
                //TODO 123중 하나를 고르도록 하자.
                Console.WriteLine("선택지에 없는 것을 고르는 당신은……. ENTP? 1, 2, 3 중 하나를 고르도록 하자.");
            }
        }

        public void Status(Player player, Books books)
        {
            Console.WriteLine("\t\t<정보창>");
            Console.WriteLine("\t이름: " + player.InfoName() + "  |  타이틀: ");//TODO: 타이틀 추가
            Console.WriteLine("\t체력: " + player.InfoHP() + "  |  공격력: " + player.InfoAttack());
            Console.WriteLine("\t┌──발견한 책 목록──┐");
            int[] check = books.ReturnCheck();
            for(int i= 0; i < books.ReturnCheck().Length; i++)
            {
                if(check[i] == 1)
                {
                    Console.WriteLine(books.ReturnBooks(i));
                }
            }
            Console.WriteLine("\t└──────────────────┘");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TheBookHunter
{
    public class Tutorial
    {
        public void GuideStart(Player player)
        {
            Console.WriteLine("\n[조작법: 스크립트를 넘기려면 Enter키를 누릅니다.\n선택지가 나오면, 해당하는 숫자를 입력 후 Enter키를 누릅니다.]");
            Console.WriteLine();
            Console.WriteLine("┌───────────────────────────────┐");
            Console.WriteLine("│                               │");
            Console.WriteLine("│                               │");
            Console.WriteLine("│    지하묘지 책 사냥꾼 가이드  │");
            Console.WriteLine("│                               │");
            Console.WriteLine("│                               │");
            Console.WriteLine("└───────────────────────────────┘\n\n\n");
            // 개발자, 3차 창작물 등 표시
            bool stop = true;
            while(stop == true)
            {
                Console.Write("▶ 쿨하고, 친절하며, 쩌는 베테랑 책 사냥꾼의 설명이 필요하다. [1: 예!    2: 어…. 아니요.]  ");
                string YOrN = Console.ReadLine();
                Console.Clear();
                if (YOrN == "1")
                {
                    stop = false;
                    //이름+설명
                    Yes(player);
                }
                else if (YOrN == "2")
                {
                    stop = false;
                    //이름+스킵
                    NO();
                }
                else
                {
                    Console.WriteLine("\"이보쇼! 날 곤란하게 하고 싶은게 아니라면 1이나 2, 둘 중 하나만 선택하라고!\"\n\n");
                }
            }
        }

        public void Yes(Player player)
        {
            Console.WriteLine("\n…….");
            Console.ReadLine();
            Console.WriteLine("\"…이봐!\"");
            Console.ReadLine();
            Console.WriteLine("\"여기요, 이쪽!\"");
            Console.ReadLine();
            Console.WriteLine("\"이리로 냉큼 오쇼!\"");
            Console.ReadLine();
            Console.WriteLine("▶ 골목 어귀에서 광대처럼 웃기게 생긴 고깔 복면을 쓴 자가 당신을 부르며 손을 까딱였다.");
            Console.ReadLine();
            Console.WriteLine("▶ 복면에 난 세 개의 구멍 안으로 보이는 눈들로 보건대 당신과 만나기로 한 자가 분명했다.");
            Console.ReadLine();
            Console.WriteLine("\"시간 맞춰 왔구만! 늦으면 엉덩이를 걷어차 주려고 했다오. 하하하.\"");
            Console.ReadLine();
            Console.WriteLine("\"음, 방금 전 말은 농담아니오. 정말 걷어차려고 했어.\"");
            Console.ReadLine();
            Console.WriteLine("▶ 그는 낮게 목소리를 깔았다가 이내 낄낄거렸다.");
            Console.ReadLine();
            Console.WriteLine("\"뭐, 이름은 이미 들어 알고 있겠지만…. 이쪽은 이안 악튜러스라 하오.\n보시다시피, 책 사냥꾼이지.\"");
            Console.ReadLine();
            Console.WriteLine("\"그쪽은. 그러니까, 이름이….\"");
            SayMyName(player);
            Console.ReadLine();
            NotMyName(player);
            //TODO: 이후 튜토리얼 스크립트
        }

        public void NO()
        {

        }

        public void SayMyName(Player player)
        {
            Console.Write("\n▶ 당신의 이름은….  ");
            string name = Console.ReadLine();
            //TODO: null인 경우, 등장인물과 동명이인인 경우 처리
            player.SetName(name);
            Console.WriteLine("\n▶ 그에게 당신의 이름은 " + player.InfoName() + "(이)라고 말했다.");
        }

        public void NotMyName(Player player)
        {
            bool ok = false;
            string miss;
            int count=0;

            

            while(ok == false)
            {
                if (player.InfoName().Length > 1)   //이름이 한 글자인경우 이름섞기 생략
                {
                    miss = player.MixName(player.InfoName());
                }
                else { miss = player.InfoName(); }

                if (count == 0)
                {
                    Console.Write("\"아! 그래, " + miss + ". 만나서 반갑소.\n자, 우선 악수부터 하고!\"" + "[1: 그 이름이 아니다.    2: 악수한다.]  ");
                    string YOrN = Console.ReadLine();
                    if(YOrN == "1")
                    {
                        count++;
                        Console.WriteLine("\n\"응? 그럼 이름이 뭐요?\"");
                        SayMyName(player);
                    }
                    else if(YOrN == "2")
                    {
                        ok = true;
                    }
                    else
                    {
                        Console.WriteLine("\"1 아니면 2. 둘 중 하날 누르는게 그리 어려운 일이었소? 나 원. 어쨌든, 이 이름이 맞다는 뜻으로 이해하지.\"");
                        ok = true;
                    }
                }
                else
                {
                    Console.Write("\n\"그래, 그래. "+ miss + ".\" [1: 그 이름이 아니다!    2: 고개를 끄덕인다….]  ");
                    string YOrN = Console.ReadLine();
                    if (YOrN == "1")
                    {
                        count++;
                        Console.WriteLine("\n\"응? 그럼 이름이 뭐요?\"");
                        SayMyName(player);
                    }
                    else if (YOrN == "2")
                    {
                        ok = true;
                    }
                    else
                    {
                        Console.WriteLine("\"1 아니면 2. 둘 중 하날 누르는게 그리 어려운 일이었소? 나 원. 어쨌든, 이 이름이 맞다는 뜻으로 이해하지.\"");
                    }
                }
            }
        }
    }
}

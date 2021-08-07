using System;
using System.Collections.Generic;
using System.Text;

namespace TheBookHunter
{
    public class Tutorial
    {
        public string YOrN;
        public string miss;
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
                YOrN = Console.ReadLine();
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
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("…….");
            Console.ReadLine();
            Console.WriteLine("\"…이봐.\"");
            Console.ReadLine();
            Console.WriteLine("\"여보쇼!\"");
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
            Console.WriteLine("\"뭐, 이름은 이미 들어 알고 있겠지만! 이쪽은 이안 악튜러스라 하오.\n보시다시피, 책 사냥꾼이지.\"");
            Console.ReadLine();
            Console.WriteLine("\"그쪽은. 그러니까, 이름이….\"");
            SayMyName(player);
            Console.ReadLine();
            NotMyName(player);
            Console.WriteLine();
            Console.WriteLine("\"좋소! 해줄 말이 많으니 좀 걷자고.\"");
            Console.ReadLine();
            Console.WriteLine("▶ 이안은 당신의 어깨를 두드려주고는 천천히 걷기 시작했다.");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\"어디서부터 설명을 해야 할까….\"");
            Console.ReadLine();
            Console.WriteLine("\"요새 지하묘지가 꽤나 뒤숭숭한 건 알고 있소? \n코흘리개건 베테랑이건 가리지 않고 목이 달아나는 빈도가 급격히 늘어났거든.\"");
            Console.ReadLine();
            Console.WriteLine("\"그 일 이후로 제왕이 사라진 탓인지도 모르겠소만… 아, 별것 아니니 신경쓰지 마시오!\"");
            Console.ReadLine();
            Console.WriteLine("\"아무튼 그 때문에 내 친우는 그쪽이 걱정된 모양이요.\"");
            Console.ReadLine();
            Console.WriteLine("▶ 골목 사이사이를 어지러이 돌아다니던 그는 그리운 한때를 떠올리는 듯 잠시 말없이 눈을 몇 번 끔뻑였다.");
            Console.ReadLine();
            Console.WriteLine("\"…그래서 내가 오늘 그쪽의 안내를 해주기로 한 것이고! 이제 알겠지?\"");
            Console.ReadLine();
            Console.WriteLine("\"책 사냥꾼이라면 마땅히 갖춰야 할 최소한의 상식들 정도만 일러주면 될 것이라 했으니까, 어디 보자….\"");
            Console.ReadLine();
            Console.WriteLine("▶ 말을 마친 그는 제 낡은 가방에서 무언가를 찾는 듯했다.");
            Console.ReadLine();
            Console.WriteLine("▶ 그리고 이내 만족스럽게 녹슨 웃음소리를 내며 반듯하게 잘 접힌 종이를 빼 들었다.");
            Console.ReadLine();

            Console.WriteLine("\"아하!\"");
            Console.ReadLine();
            Console.WriteLine("\"자, 이제부터 귀 활짝 열고 잘 듣도록 하시오!\"");
            Console.ReadLine();
            Console.WriteLine("\"내 설명은 재쇄 없는 한정판이니 말요!!\"");
            Console.ReadLine();
            Console.WriteLine("\"정말 중요한 내용이니, 어디 받아 적어 두도록 하쇼!!!\"");
            Console.ReadLine();
            Console.WriteLine("\"네모난 버튼을 마구 딸깍이다가 실수로 넘겨버리면 끝이란 말요!!!\"");
            Console.ReadLine();
            Console.WriteLine("\"준비 되었소? 그럼… 흠, 흠.\"");
            Console.ReadLine();
            Console.WriteLine("\"흠, 흠.\"");
            Console.ReadLine();
            Console.WriteLine("\"영수증.\"");
            Console.ReadLine();
            Console.WriteLine("\"꿀벌빵 세 개와 핫초코 두 잔.\"");
            Console.ReadLine();
            Console.WriteLine("\"말린 뒤쥐 고기 500g 포장.\"");
            Console.ReadLine();
            Console.WriteLine("\"…….\"");
            Console.ReadLine();
            Console.WriteLine("\"…….\"");
            Console.ReadLine();
            Console.WriteLine("\"…….\"");
            Console.ReadLine();
            Console.WriteLine("\"어, 종이를 잘못 가져왔구만.\"");
            Console.ReadLine();
            //TODO: 이후 튜토리얼 스크립트
        }

        public void NO()
        {
            Console.Clear();
        }

        public void SayMyName(Player player)
        {
            Console.Write("\n▶ 당신의 이름은….  ");
            string name = Console.ReadLine();
            //TODO:등장인물과 동명이인인 경우 처리
            if(name == "")  //이름이 공백인 경우
            {
                Console.Write("\n\"허, 이름을 알려주기 싫은거요? 그럼 내가 하나 지어주지.\n깜찍이, 어떻소?\"  [1: 싫어    2: 싫어]  ");
                YOrN = Console.ReadLine();  //선택지가 둘 다 같으므로 따로 처리x
                Console.Write("\n\"쯧. 그럼 이름이 뭐요? 암만 그래도 댁 이름이 '깜찍이' 보다 더 깜찍할 순 없을걸?\"\n");
                SayMyName(player);
                return;
            }
            player.SetName(name);
            Console.WriteLine("\n▶ 그에게 당신의 이름은 " + player.InfoName() + "(이)라고 말했다.");
        }

        public void NotMyName(Player player)
        {
            bool ok = false;
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
                    YOrN = Console.ReadLine();
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
                    YOrN = Console.ReadLine();
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

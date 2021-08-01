using System;
using System.Collections.Generic;
using System.Text;

namespace TheBookHunter
{
    class Trap
    {
        static string[] trapList =  //함정 출력 지문 5종
        {
            "잠깐, 조심해! 함정이다!",
            "발밑에서 무언가가 한순간 철컥 소리를 내며 닫혔다. 발목이 시큰거린다. 함정이군!",
            "황금 목록을 찾아냈다…! 잠시만, 이 시계 소리는…. 함정이다. 피해!",
            "바닥에 엎어져 있던 시신의 품을 뒤져보려 손을 뻗은 순간, 서걱.\n번뜩이는 칼날이 바닥에서 솟아올랐다.\n휘유, 하마터면 이 옆에 같이 누울 뻔했군!",
            "으윽, 책 무더기가 나를 노리고 쏟아진다!"
        };

        public void Trapped(Player player)   //함정에 걸릴 경우, 지문 랜덤 출력 및 주인공 hp 10 감소
        {
            Random rand = new Random();
            int randN = rand.Next(trapList.Length);
            Console.WriteLine(trapList[randN]+" (hp -10)");
            player.TrapHP();
        }
    }
}

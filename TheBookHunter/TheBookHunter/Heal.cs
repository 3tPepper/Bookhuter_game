using System;
using System.Collections.Generic;
using System.Text;

namespace TheBookHunter
{
    class Heal
    {
        public int healGage = 0;
        static string[] healList =  //회복 출력 지문 5종
        {
            "자세히 보지 않으면 발견하기 힘든 각도에 몸을 뉘기 좋은 공간이 있다.\n 편히 쉴 수 있겠는 걸….",
            "물이 흐르는 소리가 들린다.\n앗, 지하수다! 이런 곳에 물이 흐르고 있다니, 운이 좋은데!",
            "책장 틈에서 살찐 책벌레 몇 마리를 잡았다. 냠냠!",
            "잠시 멈춰서서 깨끗한 붕대로 상처를 새로 감아주었다. 아이 깨끗해! 어른도 깨끗해!",
            "책 사냥꾼의 시체에서 통조림 몇 개를 찾아냈다.\n호랑이는 죽어서 가죽을 남기고, 요놈은 통조림을 남겨주는군!"
        };


        public void Healed(Player player)   //회복에 걸릴 경우, 지문 랜덤 출력 및 주인공 hp 증가
        {
            Random rand = new Random();
            int randN = rand.Next(healList.Length);
            HealGage();
            Console.WriteLine(healList[randN] + " (hp +" + healGage + ")");
            player.HealHP(healGage);
        }

        public void HealGage()
        {
            Random rand = new Random();
            healGage = rand.Next(5, 15);    //회복량 5 ~ 15 랜덤
        }
    }
}

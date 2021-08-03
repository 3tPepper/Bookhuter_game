using System;
using System.Collections.Generic;
using System.Text;

namespace TheBookHunter
{
    static class Constants  //상수
    {
        public const int HP = 100;
    }
    public class Player    //주인공 이름, 체력, 공격력
    {
        protected string name = "NEMO";
        protected int hp = Constants.HP;
        protected int attack = 10;

        public void SetName(string name)
        {
            this.name = name;
        }

        public string MixName(string name)  //이안의 잘못된 호명
        {
            string mix = name;
            char[] mixTmp = mix.ToCharArray();//문자 배열 생성
            for(int a=0; a < mix.Length-1; a++)
            {
                int b=0;
                Random rand = new Random();
                while (a == b)
                {
                    b = rand.Next(name.Length);
                }
                mix = new string(Swap(a, b, mixTmp));
            }
            return mix;
        }

        public char[] Swap(int a, int b, char[] mixTmp)
        {
            char tmp = mixTmp[a];
            mixTmp[a] = mixTmp[b];
            mixTmp[b] = tmp;
            return mixTmp;
        }

        public void TrapHP()
        {
            hp -= 10;
            OverCheck();
        }
        public void HealHP(int healGage)
        {
            hp += healGage;
            OverCheck();
        }

        public void OverCheck() //hp 증감 이후 처리
        {
            if (hp > Constants.HP)
            {
                hp = Constants.HP;
            }
            else if(hp <= 0)
            {
                //GAMEOVER
            }
        }

        public string InfoName()    //수정 예정
        {
            return name;
        }
    }
}

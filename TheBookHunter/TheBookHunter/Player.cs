using System;
using System.Collections.Generic;
using System.Text;

namespace TheBookHunter
{
    class Player    //주인공 이름, 체력, 공격력
    {
        protected string name;
        protected int hp = 100;
        protected int attack = 10;

        public Player(string name)  //생성자
        {
            this.name = name;
        }

        public string MixName(string name)  //이안의 잘못된 호명
        {
            string mix = name;
            char[] mixTmp = mix.ToCharArray();//문자 배열 생성
            for(int a=0; a < mix.Length; a++)
            {
                int b = a;
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
    }
}

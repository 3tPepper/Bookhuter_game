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
    }
}

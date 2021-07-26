using System;
using System.Collections.Generic;
using System.Text;

namespace TheBookHunter
{
    class Books //책: 10권이나 추가될 가능성 있다. 책제목, 설명
    {
        public string[] bookList = {
            "<에코와 소름마법사>",      //0
            "<엔젤과 크레테>",         //1
            "<꿈꾸는 책들의 도시>",     //2
            "<목걸이의 제왕>",         //3
            "<셜 롹\' 집즈>",         //4
            "<책 먹는 늑대>",         //5
            "<엄청 쩌는 책>"          //6
        };
        private int[] check = {0, };    //0으로 초기화
        public void findText(int randNum)
        {
            check[randNum] = 1; //1로 값을 바꿔주어 획득한 책임을 표시
            
            switch (randNum) {
                case 0:
                    Console.WriteLine(  //<에코와 소름마법사>
                        "이건! " + bookList[randNum] + " 초회한정본이다! 출판사에서 재쇄를 찍지 않은지 오래인지라 이젠 절판되어 제법 희귀한 책이다. 부럽다..."
                        );
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }

    }
}

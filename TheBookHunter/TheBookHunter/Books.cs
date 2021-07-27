using System;
using System.Collections.Generic;
using System.Text;

namespace TheBookHunter
{
    class Books //책: 10권이나 추가될 가능성 있다. 책제목, 설명
    {
        static string[] bookList = 
        {
            "<에코와 소름마법사>",      //0
            "<엔젤과 크레테>",         //1
            "<꿈꾸는 책들의 도시>",     //2
            "<목걸이의 제왕>",         //3
            "<셜 롹\' 집즈>",         //4
            "<책 먹는 늑대>",         //5
            "<엄청 쩌는 책>"          //6
        };
        static string[] bookText = {
            "이건! " + bookList[0] + " 초회한정본이다!\n출판사에서 재쇄를 찍지 않은지 오래인지라 이젠 절판되어 제법 희귀한 책이다.\n부럽다...",
            bookList[1] + "다.\n그런데 이 향기는...각 페이지에서 다른 향이 느껴진다.\n책연금술사의 책향수가 유행하던 시절에 나온 책이군.",
            bookList[2] + " 1권이다!\n양장본은 총 2 권으로 정발되었는데, 요즘은 페이퍼백 합본으로 제작되어서 보기 힘든 구성이다.",
            bookList[3] + " 10주년 기념 금박 양장 세트다!\n절대 목걸이는 내 거야.",
            "이건 설마... " + bookList[4] + "의 작가 \'레일\'의 친필 서명본?\n" + bookList[4] + "는 락을 통해 범인을 추리해내는 탐정의 퍼포먼스로 유명세를 탄 소설이다.",
            bookList[5] + "소장본이다.\n소금과 후추가 동봉되어있는데다가, 정말 먹을 수 있는 종이로 만들어 너도 나도 먹어치우는 바람에 1만부를 찍었음에도 현재까지 남아있는건 고작 500부 정도라지.",
            "맙소사, "+bookList[6]+"이다!\n미안하다. 사실 어떤 책을 더 추가할지 생각이 떠오르지 않았다."

        };
        protected int[] check = new int[10];    //초기값 0

        public string FindText(int randNum)
        {
            check[randNum] = 1; //1로 값을 바꿔주어 획득한 책임을 표시
            return bookText[randNum];   
        }

    }
}

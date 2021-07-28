using System;
using System.Collections.Generic;
using System.Text;

namespace TheBookHunter
{
    class Blank //꽝 5개
    {
        static string[] blankList =
        {
            "...아무것도 없다. 이건…. 박쥐 똥인가? 흡혈괴조만 아니길.\n그런데 흡혈괴조도 이런 변을 배출하는 걸까?\n별로 생각하고 싶지 않은 주제다.",
            "이미 쓸만한 건 전부 털렸는지 낡아빠진 책 몇 권만이 무너진 책장을 지키고 있다.",
            "이름 모를 책 사냥꾼의 유해다. 속옷만 빼고 싹 다 털려있다.\n다른 책 사냥꾼과의 결투에서 진 모양이군.",
            "앗, 이건! <피비린내 나는 책> 이다!!!\n...아니, 다시 보니 <피비린내 날 뻔한 책>이군. 짝퉁이야.",
            "고요하다.\n낮고, 슬픈. 어쩌면 소름끼치는 그림자 제왕의 한숨소리도 이젠 들리지 않는다."

        };

        public void Blanked()
        {
            Random rand = new Random();
            int randN = rand.Next(blankList.Length);
            Console.WriteLine(blankList[randN]);
        }
    }
}

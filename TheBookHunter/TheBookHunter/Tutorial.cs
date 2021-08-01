﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TheBookHunter
{
    public class Tutorial
    {
        public Tutorial()
        {
            GuideStart();
        }
        public void GuideStart()
        {
            Console.WriteLine("\n||---지하묘지 책 사냥꾼 가이드---||\n");

            Console.WriteLine("[조작법: 해당하는 선택지의 숫자를 입력 후 Enter키를 누릅니다.]\n\n\n");

            bool stop = true;
            while(stop == true)
            {
                Console.WriteLine("▶쿨하고, 친절하며, 쩌는 베테랑 책 사냥꾼의 설명이 필요하다. [1: 예!    2: 어…. 아니요.]");
                string YOrN = Console.ReadLine();
                if (YOrN == "1")
                {
                    //이름+설명
                }
                else if (YOrN == "2")
                {
                    //이름+스킵
                }
                else
                {
                    Console.WriteLine("이보쇼! 날 곤란하게 하고 싶은게 아니라면 1이나 2, 둘 중 하나만 골라서 입력하고 Enter 키를 누르도록 하라고!\n");
                    stop = false;
                }
            }
        }
    }
}
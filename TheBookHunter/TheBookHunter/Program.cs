using System;

namespace TheBookHunter
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Tutorial tutorial = new Tutorial();
            tutorial.GuideStart(player);
            //TODO: 진행 시작
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlayer
{
    public class GuessGame : IGame
    {
        int guess;
        int input;
        public void Play()
        {
            guess = new Random().Next(100);

            //Console.WriteLine($"你輸入的最大範圍是{max}");
            while (true)  //game loop 
            {
                int counttime=0;
                //離開條件 
                if (input == guess)
                {
                    Console.WriteLine("恭喜你答對了!");
                    break;
                }
                //提示
                Console.WriteLine("猜錯了，再來一次！");
                Setup();
            }

            Console.WriteLine("PAUSE");
        }

        public void Setup()
        {
            //決定輸入內容
            Console.WriteLine("請輸入一個數字(0-100):");
            string input_str = Console.ReadLine();  //input  string 
            input = int.Parse(input_str);
        }
    }
}

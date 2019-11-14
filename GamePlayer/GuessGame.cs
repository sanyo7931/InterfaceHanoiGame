using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlayer
{
    public class GuessGame : IGame
    {
        int max = 0;
        public void Play()
        {
            Console.WriteLine($"你輸入的最大範圍是{max}");
        }

        public void Setup()
        {
            Console.WriteLine("請輸入範圍:");
            string input = Console.ReadLine();
            max = int.Parse(input);
        }
    }
}

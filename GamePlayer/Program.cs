using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            IGame game = null;

            Console.WriteLine("選擇遊戲1:Hanoi or 2:Guess");
            string input_string = Console.ReadLine();
            int input = int.Parse(input_string);

            switch(input)
            {
                case 1:
                    game = new HanoiGame();
                    break;
                case 2:
                    game = new GuessGame();

                    break;
            }
            game.Setup();
            game.Play();
            Console.ReadKey();
        }
    }
}

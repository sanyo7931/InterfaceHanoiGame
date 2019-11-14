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
            IGame game = new HanoiGame();
            game.Setup();
            game.Play();
            Console.ReadKey();
        }
    }
}

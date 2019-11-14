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
            IGame game = new GuessGame();
            game.Setup();
            game.Play();
            Console.ReadKey();
        }
    }
}

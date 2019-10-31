using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // 커서 없애기
            Console.CursorVisible = false;
            Gameloop gameloop = new Gameloop();

            gameloop.Run();
        }
    }
}

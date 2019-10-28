using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManGame
{
    class Gameloop
    {
        Player player = new Player();

        public void Run()
        {
            while(true)
            {
                Print(player.x, player.y, player.playerImage[player.direction]);
                MovePlayer();

                System.Threading.Thread.Sleep(10);
                Console.Clear();
            }
        }

        public void Print(int x, int y, string Image)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(Image);
        }

        void MovePlayer()
        {
            ConsoleKeyInfo move = Console.ReadKey(true);

            switch(move.Key)
            {
                case ConsoleKey.LeftArrow:
                    player.x--;
                    player.direction = 0;
                    break;

                case ConsoleKey.RightArrow:
                    player.x++;
                    player.direction = 2;
                    break;

                case ConsoleKey.UpArrow:
                    player.y--;
                    player.direction = 4;
                    break;

                case ConsoleKey.DownArrow:
                    player.y++;
                    player.direction = 6;
                    break;
            }

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManGame
{
    class Gameloop
    {
        enum Direction { LEFT = 0, RIGHT, UP, DOWN }

        Player player = new Player();
        Map map = new Map();
        Draw draw = new Draw();

        public void Run()
        {
            map.LoadMap("map.txt");

            while(true)
            {
                map.PrintMap();

                draw.Print(player.x, player.y, player.playerImage[player.ImageNumber]);
                MovePlayer();

                draw.TextPrint(100, 10, player.x.ToString());
                draw.TextPrint(100, 11, player.y.ToString());
                System.Threading.Thread.Sleep(100);
                Console.Clear();
            }
        }

        void MovePlayer()
        {
            // Console.KeyAvailable는 kbhit()와 같은 기능으로
            // 입력 버퍼에 값이 있는지 보고 없으면 즉시 리턴한다
            while(Console.KeyAvailable == true)
            {
                // Console.ReadKey는 키입력을 기다린다 - 무한루프가 안됨
                ConsoleKeyInfo move = Console.ReadKey(true);

                switch(move.Key)
                {
                    case ConsoleKey.LeftArrow:
                        player.direction = (int)Direction.LEFT;
                        break;

                    case ConsoleKey.RightArrow:
                        player.direction = (int)Direction.RIGHT;
                        break;

                    case ConsoleKey.UpArrow:
                        player.direction = (int)Direction.UP;
                        break;

                    case ConsoleKey.DownArrow:
                        player.direction = (int)Direction.DOWN;
                        break;
                }
            }

            switch(player.direction)
            {
                case (int)Direction.LEFT:
                    if (map.map[player.y, player.x - 1] != '1')
                    {
                        player.x--;

                        if (player.ImageNumber != 0)
                            player.ImageNumber = 0;
                        else
                            player.ImageNumber = 1;
                    }
                    break;

                case (int)Direction.RIGHT:
                    if (map.map[player.y, player.x + 1] != '1')
                    {
                        player.x++;

                        if (player.ImageNumber != 2)
                            player.ImageNumber = 2;
                        else
                            player.ImageNumber = 3;
                    }
                    break;

                case (int)Direction.UP:
                    if (map.map[player.y - 1, player.x] != '1') 
                    {
                        player.y--;

                        if (player.ImageNumber != 4)
                            player.ImageNumber = 4;
                        else
                            player.ImageNumber = 5;
                    }
                    break;

                case (int)Direction.DOWN:
                    if (map.map[player.y + 1, player.x] != '1')
                    {
                        player.y++;

                        if (player.ImageNumber != 6)
                            player.ImageNumber = 6;
                        else
                            player.ImageNumber = 7;
                    }
                    break;
            }
        }
    }
}
